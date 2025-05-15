using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;
using SATAUiFramework;
using FrameworkTest.Charts;
using static System.Windows.Forms.LinkLabel;
using System.Drawing.Drawing2D;
using System.Reflection;

namespace EcoWatt
{
    
    public partial class Gasto : Form
    {
        int mesAtualInt, mesProximoInt, mesAnteriorint;
        string nomeMatriz = "Gasto_";
        string[] sensorStr = 
        {
            "Quarto 01",
            "Quarto 02",
            "Sala",
            "Cozinha",
            "Piscina"
        
        };

        float[] MesAtual;
        float[] MesProximo;
        float[] MesAnterior;

        int numSensor = 1;
        List<String> listaDias = new List<string>();

        public Gasto(int mes, string sensor_String)
        {
            mesAtualInt = mes;
            InitializeComponent();
            Grafico(mesAtualInt, sensor_String);
        }

        private void sataPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
               

        

        private void Grafico(int mes, string sensor)
        {

            mesAnteriorint = mesAtualInt - 1;
            mesProximoInt = mesProximoInt + 1;
            
            Gasto_grafSata.DataSets.Clear();
            int diasMes = 31;

            int[] x = new int[31];
            
            

            double maior = double.MinValue;
            double meio = double.MinValue;
            double menor = double.MinValue;

            string dataMaiorStr = "";
            string dataMeioStr = "";
            string dataMenorStr = "";
            List<String> novoDia = new List<string>();
            int index = 0;
            LeituraArquivo(sensor, mes);





        }

        public void LeituraArquivo(string sensor, int mes)
        {
            string caminho = "Ordenado_" + sensor + "_2025.csv";
            string[] linhas = File.ReadAllLines(caminho);
            var dadosMesAtual = new List<float>();
            var dadosMesAnterior = new List<float>();
            var dadosMesProximo = new List<float>();
            var diasLabels = new List<string>();

            foreach (var linha in linhas.Skip(1))
            {
                var coluna = linha.Split(';');
                if (DateTime.TryParse(coluna[0], out DateTime data) && coluna[1] == sensor)
                {
                    float valor = float.Parse(coluna[3]) / 1000;
                    if (data.Month == mes)
                    {
                        dadosMesAtual.Add(valor);
                        diasLabels.Add(data.Day.ToString());
                    }
                    else if (data.Month == mes - 1)
                    {
                        dadosMesAnterior.Add(valor);
                    }
                    else if (data.Month == mes + 1)
                    {
                        dadosMesProximo.Add(valor);
                    }
                }
            }

            string nomeMes = NomeMes(mes);
            string nomeAnterior = NomeMes(mes - 1);
            string nomeProximo = NomeMes(mes + 1);

        Gasto_grafSata.DataSets = new List<SATALineChart.DataSet>
        {
            
            LinhaGrafico($"{nomeAnterior}_{sensor}", dadosMesAnterior.ToArray(), Color.Gray),
            LinhaGrafico($"{nomeProximo}_{sensor}", dadosMesProximo.ToArray(), Color.DarkGray),
            LinhaGrafico($"{nomeMes}_{sensor}", dadosMesAtual.ToArray(), Color.Green)
        };

            Gasto_grafSata.CustomXAxis = diasLabels.ToArray();
        }

        private SATALineChart.DataSet LinhaGrafico(string nome, float[] pontos, Color cor)
        {
            return new SATALineChart.DataSet
            {
                Label = nome,
                Points = pontos,
                LineColor = cor,
                PointColor = cor
            };
        }

        private string NomeMes(int mes)
        {
            return new[] { "", "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho",
        "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" }
                .ElementAtOrDefault(mes) ?? "Desconhecido";
        }
   
        

        private void VoltaMes_bnt_Click(object sender, EventArgs e)
        {
            if(mesAtualInt > 1)
            {
                mesAtualInt--;
                Grafico(mesAtualInt, sensorStr[numSensor]);
            }
            
        }
        private void proximoMes_bnt_Click(object sender, EventArgs e)
        {
            if (mesAtualInt < 7)
            {
                mesAtualInt++;
                Grafico(mesAtualInt, sensorStr[numSensor]);
            }

        }
    }
    public class Dados
    {
        public int dados1 { get; set; }
        public int dados2 { get; set; }
    }
}
