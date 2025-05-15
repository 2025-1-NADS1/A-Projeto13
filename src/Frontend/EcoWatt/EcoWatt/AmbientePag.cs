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
            Grafico(mesVar, sensorVar_String);
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

        private void Grafico(int mes, string sensor)
        {

            GraphPane graficPane = grafic1.GraphPane;
            
            string nomeMatriz = "Gasto_";
            string caminho = "Ordenado_" + sensor + "_2025.csv";
            string[] matriz = File.ReadAllLines(caminho);
            string[] coluna;
            string linha;
            int diasMes = DateTime.DaysInMonth(2025, mes);
            double[] x = new double[diasMes];
            double[] y = new double[1000];
            WattMenor.Text = "200000";
            double maior = double.MinValue;
            double meio = double.MinValue;
            double menor = double.MinValue;

            string dataMaiorStr = "";
            string dataMeioStr = "";
            string dataMenorStr = "";
            int index = 0;
            for (int j = 1; j < matriz.Length; j++)
            {

                linha = matriz[j];
                coluna = linha.Split(';');

                string proximalinha;

                if (DateTime.TryParse(coluna[0], out DateTime data) && coluna[1] == sensor)
                {
                    if (data.Month == mes)
                    {
                        //Console.WriteLine(data.Day.ToString() + "/" + data.Month.ToString() + " - " + (double.Parse(coluna[3]) / 1000).ToString());

                        x[index] = data.Day;
                        y[index] = double.Parse(coluna[3]) / 1000;
                        index++;

                        if (coluna.Length > 3 && double.TryParse(coluna[3], out double valorAtual))
                        {
                            string dataAtual = coluna[0];

                            if (valorAtual > maior)
                            {
                                // Empurra os outros
                                menor = meio;
                                dataMenorStr = dataMeioStr;

                                meio = maior;
                                dataMeioStr = dataMaiorStr;

                                maior = valorAtual;
                                dataMaiorStr = dataAtual;
                            }
                            else if (valorAtual > meio)
                            {
                                menor = meio;
                                dataMenorStr = dataMeioStr;

                                meio = valorAtual;
                                dataMeioStr = dataAtual;
                            }
                            else if (valorAtual > menor)
                            {
                                menor = valorAtual;
                                dataMenorStr = dataAtual;
                            }
                        }

                        // Atribui os resultados
                        dataMaior.Text = dataMaiorStr;
                        dataMeio.Text = dataMeioStr;
                        dataMenor.Text = dataMenorStr;
                        WattMaior.Text = (maior/1000).ToString() + " KWatts";
                        WattsMeio.Text = (meio / 1000).ToString() + " KWatts";
                        WattMenor.Text = (menor / 1000).ToString() +  " KWatts";

                    }
                }

            }
            Array.Resize(ref x, index);

            Array.Resize(ref y, index);

            switch (mes)
            {
                case 1:
                    nomeMatriz += "Janeiro";
                    break;
                case 2:
                    nomeMatriz += "Fevereiro";
                    break;
                case 3:
                    nomeMatriz += "Março";
                    break;
                case 4:
                    nomeMatriz += "Abril";
                    break;
                case 5:
                    nomeMatriz += "Maio";
                    break;
                case 6:
                    nomeMatriz += "Junho";
                    break;
                case 7:
                    nomeMatriz += "Julho";
                    break;

            }

            grafic1.GraphPane.CurveList.Clear();
            grafic1.GraphPane.GraphObjList.Clear();
            grafic1.GraphPane.AddCurve(" ", x, y, Color.Black);
            graficPane.Title.Text = nomeMatriz + "_" + sensor.ToString();
            grafic1.RestoreScale(grafic1.GraphPane);
            grafic1.Refresh();

           
                LineItem curva = (LineItem)graficPane.CurveList[0];
                graficPane.Fill = new Fill(Color.Black);
                graficPane.Chart.Fill = new Fill(Color.Black);
                curva.Color = Color.WhiteSmoke;
                curva.Line.Width = 2.0f;
                graficPane.Title.FontSpec.FontColor = Color.WhiteSmoke;
                graficPane.XAxis.Title.Text = "KWatts";
                graficPane.YAxis.Title.Text = "Dias";

                graficPane.XAxis.Scale.FontSpec.FontColor = Color.WhiteSmoke;
                graficPane.YAxis.Scale.FontSpec.FontColor = Color.WhiteSmoke;
                
                graficPane.XAxis.Title.FontSpec.FontColor = Color.WhiteSmoke;
                graficPane.YAxis.Title.FontSpec.FontColor = Color.WhiteSmoke;
            
               
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
                Grafico(mesVar, sensorVar_String);
                grafic1.Refresh();
            }
        }

        private void avanca_mes_MouseClick(object sender, MouseEventArgs e)
        {
            if (mesVar < 7)
            {
                mesVar++;
                Grafico(mesVar, sensorVar_String);
                grafic1.Refresh();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
