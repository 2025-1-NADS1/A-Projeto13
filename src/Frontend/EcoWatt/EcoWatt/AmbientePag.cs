using FrameworkTest.Charts;
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

namespace EcoWatt
{
    public partial class AmbientePag : Form
    {
        string sensorVar_String;
        string[] proximaColuna = { "0" };
        int mesVar = 1;

        public AmbientePag(int mes, string sensor_String, string gastoKW)
        {
            InitializeComponent();
            sensorVar_String = sensor_String;
            mesVar = mes;
            LeituraArquivo(sensorVar_String, mesVar);
            Ambiente_text.Text = sensor_String;
            MediaGasto_text.Text = gastoKW + " KWatts-hora"; 
            
        }

        private void AmbientePag_Load(object sender, EventArgs e)
        {
            avanca_mes.BackColor = Color.Black;
            Volta_mes.BackColor = Color.Black;
            avanca_mes.ForeColor = Color.White;
            Volta_mes.ForeColor = Color.White;
            Volta_mes.FlatStyle = FlatStyle.Flat;
            avanca_mes.FlatStyle = FlatStyle.Flat;

            

        }
    public void LeituraArquivo(string sensor, int mes)
    {

            double maior = double.MinValue;
            double meio = double.MinValue;
            double menor = double.MinValue;

            string dataMaiorStr = "";
            string dataMeioStr = "";
            string dataMenorStr = "";

            string wattsMaiorStr = "";
            string wattMeioStr = "";
            string wattMenorStr = "";

            string caminho = "Ordenado_" + sensor + "_2025.csv";
        string[] linhas = File.ReadAllLines(caminho);
        var dadosMesAtual = new List<float>();
        var diasLabels = new List<string>();
            AmbienteChar.MaxValue = 0;
        foreach (var linha in linhas.Skip(1))
        {
            var coluna = linha.Split(';');
            if (DateTime.TryParse(coluna[0], out DateTime data) && coluna[1] == sensor)
            {


               
                if (data.Month == mes)
                {
                        float valor = float.Parse(coluna[3]) / 1000;
                        Console.WriteLine(valor + " = " + coluna[3]);
                        if (valor > AmbienteChar.MaxValue)
                        {
                            AmbienteChar.MaxValue = valor;
                        }
                        dadosMesAtual.Add(valor);
                    diasLabels.Add(data.Day.ToString());
                        if (coluna.Length > 3 && double.TryParse(coluna[3], out double valorAtual))
                        {
                            string dataAtual = coluna[0];


                            if (valor > maior)
                            {
                                // Desloca os valores para baixo
                                menor = meio;
                                dataMenorStr = dataMeioStr;
                                wattMenorStr = wattMeioStr;

                                meio = maior;
                                dataMeioStr = dataMaiorStr;
                                wattMeioStr = wattsMaiorStr;

                                maior = valorAtual;
                                dataMaiorStr = dataAtual;
                                wattsMaiorStr = valor.ToString();
                            }
                            else if (valorAtual > meio)
                            {
                                menor = meio;
                                dataMenorStr = dataMeioStr;
                                wattMenorStr = wattMeioStr;

                                meio = valorAtual;
                                dataMeioStr = dataAtual;
                                wattMeioStr = valor.ToString();
                            }
                            else if (valorAtual > menor)
                            {
                                menor = valorAtual;
                                dataMenorStr = dataAtual;
                                wattMenorStr = valor.ToString();
                            }
                        }
                        dataMaior.Text = dataMaiorStr;
                        dataMeio.Text = dataMeioStr;
                        dataMenor.Text = dataMenorStr;

                        WattMaior.Text = wattsMaiorStr + " KWatt";
                        WattsMeio.Text = wattMeioStr + " KWatt";
                        WattMenor.Text = wattMenorStr + " KWatt";

                    }             
               }
                // Atribui os textos das datas aos controles
                

            }

            string nomeMes = NomeMes(mes);
        string nomeAnterior = NomeMes(mes - 1);
        string nomeProximo = NomeMes(mes + 1);

           
           

            AmbienteChar.DataSets = new List<SATALineChart.DataSet>
        {
            LinhaGrafico($"{nomeMes}_{sensor}", dadosMesAtual.ToArray(), Color.Green)
        };

        AmbienteChar.CustomXAxis = diasLabels.ToArray();
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
        private void grafic1_Load(object sender, EventArgs e)
        {

        }

        private void Ambiente_text_Click(object sender, EventArgs e)
        {

        }

        private void Volta_mes_MouseClick(object sender, MouseEventArgs e)
        {
            if(mesVar > 1)
            {
                mesVar--;
                LeituraArquivo(sensorVar_String, mesVar);
                
            }
        }

        private void avanca_mes_MouseClick(object sender, MouseEventArgs e)
        {
            if (mesVar < 7)
            {
                mesVar++;
                LeituraArquivo(sensorVar_String, mesVar);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
