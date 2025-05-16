using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXEMPLO_02_CLIENT
{
    class Program
    {
        public static String IPServer = "127.0.0.1";
        public static String msg;
        public static TcpClient client;
        public static NetworkStream stream;
        public static Byte[] dados;
        public static String ambienteEscolha, numEscolha;
        static void Main(string[] args)
        {

            Application.Run(new NovaConexao());
            #region nova Entrada
            /*
            client = new TcpClient();
            client.Connect(IPServer, 80);
            msg = "SET SUMMOR TIME" ;            
            dados = System.Text.Encoding.UTF8.GetBytes(msg);
            stream = client.GetStream();
            stream.Write(dados, 0, dados.Length);
            client.Close();*/
            #endregion

            NewConnection();
            EscolhaAmbiente();
           //ambienteEscolha = "Cozinha";
            NewMensage(ambienteEscolha);

            try
            {
                dados = new Byte[client.ReceiveBufferSize];
                int tentativas = 0;

                while (!stream.DataAvailable && tentativas < 5)
                {
                    tentativas++;
                    Thread.Sleep(30);
                }

                int numBytes = stream.Read(dados, 0, dados.Length); // <- pode lançar IOException
                String resposta = "";

                tentativas = 0;
                while (numBytes > 0)
                {
                    resposta += System.Text.Encoding.UTF8.GetString(dados, 0, numBytes);
                    tentativas = 0;
                    numBytes = 0;

                    while (!stream.DataAvailable && tentativas < 5)
                    {
                        tentativas++;
                        Thread.Sleep(30);
                    }

                    if (stream.DataAvailable)
                    {
                        numBytes = stream.Read(dados, 0, dados.Length);
                    }
                }

                Console.WriteLine("Resposta recebida: " + resposta);
                Console.ReadKey();
            }
            catch (IOException ex)
            {
                Console.WriteLine("Erro de leitura na conexão: " + ex.Message);
                Console.ReadKey();
            }
            catch (SocketException ex)
            {
                Console.WriteLine("Erro de socket: " + ex.Message);
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro inesperado: " + ex.Message);
                Console.ReadKey();
            }

        }

        public static void NewConnection()
        {
            client = new TcpClient();
            client.Connect(IPServer, 80);
            
        }

        public static void NewMensage(String ambiente)
        {
            msg = "GET AMBIENTE " + ambiente;
            dados = System.Text.Encoding.UTF8.GetBytes(msg);
            stream = client.GetStream();
            stream.Write(dados, 0, dados.Length);
        }

        public static void EscolhaAmbiente()
        {
            bool escolhaValida = false;
            while (!escolhaValida)
            {
                Console.WriteLine("ESCOLHA O NÚMERO DO AMBIENTE");
                Console.WriteLine("1 - Quarto 1 \n2 - Quarto 2 \n3 - Sala \n4 - Cozinha \n5 - Piscina");

                numEscolha = Console.ReadLine().ToString();

                switch (numEscolha)
                {
                    case "1":
                        ambienteEscolha = "QUARTO1";
                        escolhaValida = true;
                        break;
                    case "2":
                        ambienteEscolha = "QUARTO2";
                        escolhaValida = true;
                        break;
                    case "3":
                        ambienteEscolha = "SALA";
                        escolhaValida = true;
                        break;
                    case "4":
                        ambienteEscolha = "COZINHA";
                        escolhaValida = true;
                        break;
                    case "5":
                        ambienteEscolha = "PISCINA";
                        escolhaValida = true;
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
            
        }

    }
}
