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
        int mesAtualInt;       
        int sensorNum = 0;
        string[] sensorVetor =
        {
            "Quarto 01",
            "Quarto 02",
            "Sala",
            "Cozinha",
            "Piscina"

        };      

        
        List<String> listaDias = new List<string>();

        public Gasto(int mes, string sensor_String)
        {
            mesAtualInt = mes;
            InitializeComponent();
            Grafico(mesAtualInt, sensor_String);
            sensor_label.Text = sensorVetor[sensorNum].ToString();
        }

        private void sataPanel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void Grafico(int mes, string sensor)
        {


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
            float valorMes =0;
            float valorAnterior = 0;
            float valorProximo = 0;
            float economia = 0;


            Gasto_grafSata.MaxValue = 0;
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
                        valorMes += float.Parse(coluna[3]) / 1000;
                        if (valor > Gasto_grafSata.MaxValue)
                        {
                            Gasto_grafSata.MaxValue = valor;
                        }
                    }
                    else if (data.Month == mes - 1)
                    {
                        dadosMesAnterior.Add(valor);
                        valorAnterior += float.Parse(coluna[3]) / 1000;
                    }
                    else if (data.Month == mes + 1)
                    {
                        dadosMesProximo.Add(valor);
                        valorProximo += float.Parse(coluna[3]) / 1000;
                    }
                }
            }

            string nomeMes = NomeMes(mes);
            string nomeAnterior = NomeMes(mes - 1);
            string nomeProximo = NomeMes(mes + 1);

        
            if (Economia(valorMes, valorAnterior, economia) < 0)
            {
                AnterioAtual_label.Text = "Você economizou " + (Economia(valorMes, valorAnterior, economia) * -1).ToString("F2") + "% a mais que mes passado";
            }
            else
            {
                AnterioAtual_label.Text = "Você gastou " + Economia(valorMes, valorAnterior, economia).ToString("F2") + "% a mais que mes passado";
            }
            
            
            mes_label.Text = nomeMes;
            Gasto_grafSata.DataSets = new List<SATALineChart.DataSet>
        {

            LinhaGrafico($"{nomeAnterior}_{sensor}", dadosMesAnterior.ToArray(), Color.Silver, Color.Transparent),            
            LinhaGrafico($"{nomeMes}_{sensor}", dadosMesAtual.ToArray(), Color.Red, Color.Transparent)
        };

            Gasto_grafSata.CustomXAxis = diasLabels.ToArray();
        }

        private void proximoMes_bnt_Click(object sender, EventArgs e)
        {
            if (mesAtualInt < 7)
            {
                mesAtualInt++;
                Grafico(mesAtualInt, sensorVetor[sensorNum]);
            }

        }

        private void VoltaMes_bnt_Click(object sender, EventArgs e)
        {
            if (mesAtualInt > 1)
            {
                mesAtualInt--;
                Grafico(mesAtualInt, sensorVetor[sensorNum]);
            }

        }

        private SATALineChart.DataSet LinhaGrafico(string nome, float[] pontos, Color cor, Color pointColor)
        {
            return new SATALineChart.DataSet
            {
                Label = nome,
                Points = pontos,
                LineColor = cor,
                PointColor = pointColor
            };
        }

        private void AnterioAtual_label_Click(object sender, EventArgs e)
        {

        }

        private void VoltaSensor_bnt_Click(object sender, EventArgs e)
        {
            
            if (sensorNum > 0)
            {
                sensorNum--;
                sensor_label.Text = sensorVetor[sensorNum].ToString();
                Grafico(mesAtualInt, sensorVetor[sensorNum]);
            }
            
        }

        private void AvançaSensor_bnt_Click(object sender, EventArgs e)
        {
            if (sensorNum < sensorVetor.Length -1)
            {
                sensorNum++;
                sensor_label.Text = sensorVetor[sensorNum].ToString();
                Grafico(mesAtualInt, sensorVetor[sensorNum]);
            }
            
        }

        private void sensor_label_Click(object sender, EventArgs e)
        {

        }

        private void mes_label_Click(object sender, EventArgs e)
        {

        }

        private string NomeMes(int mes)
        {
            return new[] { "", "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho",
        "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" }
                .ElementAtOrDefault(mes) ?? "Desconhecido";
        }
        public float Economia(float valor1, float valor2, float valorEconomia)
        {
            if (valor1 > valor2)
            {
                valorEconomia = ((valor1 - valor2) / valor1) * 100;
            }
            else
            {
                if (valor2 > valor1)
                {
                    valorEconomia = ((valor2 - valor1) / valor2) * 100 *-1  ;
                }

            }
            
                return valorEconomia;
            
            
        }

    }

    



    
    public class Dados
    {
        public int dados1 { get; set; }
        public int dados2 { get; set; }
    }
}
