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

namespace EcoWatt
{
    public partial class AmbientePag : Form
    {
        int id_sensor_int = 1;

        public AmbientePag()
        {
            InitializeComponent();
            Grafico(1,"Quarto 01");
        }

        private void AmbientePag_Load(object sender, EventArgs e)
        {
            


        }

        private void Grafico(int mes, string sensor)
        {
            string nomeMatriz = "Gasto_";
            string caminho = "Ordenado_" + sensor + "_2025.csv";
            string[] matriz = File.ReadAllLines(caminho);
            string[] coluna;
            string linha;
            int diasMes = DateTime.DaysInMonth(2025, mes);
            double[] x = new double[diasMes];
            double[] y = new double[1000];

            int index = 0;
            for (int j = 1; j < matriz.Length; j++)
            {
                linha = matriz[j];
                coluna = linha.Split(';');


                if (DateTime.TryParse(coluna[0], out DateTime data) && int.TryParse(coluna[1], out int sensor_Id))
                {


                    if (data.Month == mes && sensor_Id == id_sensor_int)
                    {
                        Console.WriteLine(data.Day.ToString() + "/" + data.Month.ToString() + " - " + (double.Parse(coluna[3]) / 100).ToString());

                        x[index] = data.Day;
                        y[index] = double.Parse(coluna[3]) / 1000;
                        index++;
                    }
                }

            }
            Array.Resize(ref x, index);
            Array.Resize(ref y, index);

            grafic1.GraphPane.CurveList.Clear();
            grafic1.GraphPane.GraphObjList.Clear();
            grafic1.GraphPane.AddCurve(nomeMatriz + "_" + sensor.ToString(), x, y, Color.Black);
            grafic1.RestoreScale(grafic1.GraphPane);
            grafic1.Refresh();

        }

    }
}
