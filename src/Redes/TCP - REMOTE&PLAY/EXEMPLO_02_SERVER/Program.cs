﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using CsvHelper;
using CsvHelper.Configuration;

namespace EXEMPLO_02_SERVER
{
    public class IntelligentHouse
    {
        public string Ambiente { get; set; }
        public string NomeSensor { get; set; }
        public int StatuSensor { get; set; }
    }

    public sealed class IntelligentHouseMap : ClassMap<IntelligentHouse>
    {
        public IntelligentHouseMap()
        {
            Map(m => m.Ambiente).Name("Ambiente");
            Map(m => m.NomeSensor).Name("Sensor");
            Map(m => m.StatuSensor).Name("status");
        }
    }

    public class LeituraCSV
    {
        public IEnumerable<IntelligentHouse> LerSensor()
        {
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                Delimiter = ";",
                Encoding = Encoding.UTF8,
                HeaderValidated = null,
                MissingFieldFound = null
            };

            using (var reader = new StreamReader("ambiente-sensores.csv"))
            using (var csv = new CsvReader(reader, config))
            {
                csv.Context.RegisterClassMap<IntelligentHouseMap>();
                return csv.GetRecords<IntelligentHouse>().ToList();
            }
        }
    }

    class Program
    {
        static LeituraCSV leitor;
        static TcpListener tcpServer;
        static bool fim = false;
        static bool summerTime = false;

        static void Main(string[] args)
        {
            leitor = new LeituraCSV();
            tcpServer = new TcpListener(IPAddress.Parse("127.0.0.1"), 80);
            tcpServer.Start();
            Console.WriteLine("Servidor iniciado...");

            Thread serverThread = new Thread(serverListener);
            serverThread.Start();
        }

        public static void serverListener()
        {
            while (!fim)
            {
                TcpClient client = tcpServer.AcceptTcpClient();
                
                Thread thread = new Thread(() => responseMessage(client));
                thread.Start();
            }
        }

        public static void responseMessage(TcpClient client)
        {
            Console.WriteLine($"Conexão recebida de {client.Client.RemoteEndPoint}");
            Thread.Sleep(50);
            string msg = receiveTCPMessage(client);            
            Console.WriteLine("Comando recebido: " + msg);
            string resposta = parseMsg(msg);
            sendTCPMessage(client, resposta);
        }

        private static string parseMsg(string msg)
        {
            string[] partes = msg.Split(' ');
            //if (partes.Length < 2) return "Comando inválido.";
            
            if (partes[0].ToUpper() == "GET")
            {
                if (partes[1].ToUpper() == "AMBIENTE")
                {
                    string nomeAmbiente = string.Join(" ", partes.Skip(2));
                    return MostrarSensoresDoAmbiente(nomeAmbiente);
                }              
               
            }            
            
            return "Comando não reconhecido.";
        }

        public static string MostrarSensoresDoAmbiente(string ambiente)
        {
            var sensores = leitor.LerSensor();
            var filtrados = sensores.Where(s => s.Ambiente.Equals(ambiente, StringComparison.OrdinalIgnoreCase)).ToList();

            if (!filtrados.Any())
                return $"Nenhum ambiente selecionado '{ambiente}'.";

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Sensores no ambiente '{ambiente}':");
            foreach (var sensor in filtrados)
            {
                string txtStatus;
                if(sensor.StatuSensor == 0) { txtStatus = "Inativo"; }
                else { txtStatus = "Ativo"; }
                    sb.AppendLine($"- Sensor: {sensor.NomeSensor}, Status: {txtStatus}");
            }
            return sb.ToString();
        }

        public static string receiveTCPMessage(TcpClient client)
        {
            NetworkStream stream = client.GetStream();
            byte[] buffer = new byte[client.ReceiveBufferSize];
            int bytesRead = 0;
            int tentativas = 0;

            while (!stream.DataAvailable && tentativas < 10)
            {
                Thread.Sleep(50);
                tentativas++;
            }

            while (stream.DataAvailable)
            {
                bytesRead += stream.Read(buffer, bytesRead, buffer.Length - bytesRead);
            }

            return Encoding.UTF8.GetString(buffer, 0, bytesRead);
        }

        public static void sendTCPMessage(TcpClient client, string msg)
        {
            NetworkStream stream = client.GetStream();
            byte[] buffer = Encoding.UTF8.GetBytes(msg);

            if (stream.CanWrite)
            {
                stream.Write(buffer, 0, buffer.Length);
                stream.Flush();
            }
            
            //client.Close();
        }
    }
}
