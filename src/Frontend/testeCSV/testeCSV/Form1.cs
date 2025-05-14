using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace testeCSV
{
    public partial class Form1 : Form
    {
        
        string[] linhas,  cabecalho;
        string linhaFinal;
        static DataTable tabela = new DataTable();
        List<string> MatrizOrdenada;
        List<string> matrizGasto;
        DataView view = new DataView(tabela);

        String caminhoArquivo = "BD_Casa_Inteligente.csv";
        DateTime dataLimite;
        String id_Sensor = "1";
        String sensorString = "Quarto 01";
        TimeSpan tempoGasto;
        Double horas, potenciaWatts, consumoWH;

        int mes = 1;
        int sensor = 1;


        public Form1()
        {

            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            for (int x = 1; x <= 5; x++)
            {
                matrizGasto = new List<string>();
                matrizGasto.Add("DATA;ID_SENSOR;TimeAtive;TotalGastoWatts");
                id_Sensor = x.ToString();
                switch (id_Sensor)
                {
                    case "1":
                        potenciaWatts = 1500;
                        break;
                    case "2":
                        potenciaWatts = 1500;
                        break;
                    case "3":
                        potenciaWatts = 50;
                        break;
                    case "4":
                        potenciaWatts = 3000;
                        break;
                    case "5":
                        potenciaWatts = 7000;
                        break;

                }
                for (int i = 1; i <= 7; i++) // Meses
                {
                    
                    int diasNoMes = DateTime.DaysInMonth(2025, i);
                    for (int j = 1; j <= diasNoMes; j++) // Dias
                    {
                        dataLimite = new DateTime(2025, i, j);
                        GuardaTabela(dataLimite);
                        FiltrarMatriz();
                        AnaliseMatriz();
                        CalculoWattsH(potenciaWatts);
                        if (horas> 0)
                        {
                            matrizGasto.Add(dataLimite.ToString() + ";" + id_Sensor + ";" + tempoGasto.ToString() + ";" + consumoWH);
                        }
                        


                    }
                    
                    


                }
                
                File.WriteAllLines("GastoHora_Sensor_"+ id_Sensor + ".csv", matrizGasto);
            }
            



        }
        private void Grafico(int mes, string sensor)
        {
            string nomeMatriz = "Gasto_";
            int sensorInt = 1;
            int diasMes = DateTime.DaysInMonth(2025, mes);
            double[] x = new double[diasMes];
            double[] y = new double[1000];
            

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

            switch (sensor)
            {
                case "Quarto 01":
                    sensorInt = 1;
                    break;
                case "Quarto 02":
                    sensorInt = 2;
                    break;
                case "Sala":
                    sensorInt = 3;
                    break;
                case "Cozinha":
                    sensorInt = 4;
                    break;
                case "Piscina":
                    sensorInt = 5;
                    break;
            }
            string[] matriz = File.ReadAllLines("GastoHora_Sensor_" + sensorInt.ToString() + ".csv");
            string[] coluna;
            string linha;

            int index = 0;
            for(int j =1; j< matriz.Length; j++)
            {
                linha = matriz[j];
                coluna = linha.Split(';');


                if (DateTime.TryParse(coluna[0], out DateTime data) && int.TryParse(coluna[1], out int sensor_Id))
                {


                    if (data.Month == mes && sensor_Id == sensorInt)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void Carregar_Click(object sender, EventArgs e)
        {
            
                linhas = File.ReadAllLines("GastoHora_Sensor_1.csv");

                tabela = new DataTable();
                cabecalho = linhas[0].Split(';');

                foreach (var coluna in cabecalho)
                    tabela.Columns.Add(coluna);

                foreach (var linha in linhas.Skip(1))
                {
                    
                    tabela.Rows.Add(linha.Split(';'));
                }

            
            dataGridView1.DataSource = tabela;
            
           
        }        

        private void button1_Click(object sender, EventArgs e)
        {
            Grafico(1,sensorString);


        }
        
        public void GuardaTabela(DateTime dataLimite)
        {

            string caminhoArquivo = "BD_Casa_Inteligente.csv";
            string[] linhas = File.ReadAllLines(caminhoArquivo);
            //dataLimite = new DateTime(2025, 01, 02);
            List<string> resultado = new List<string>();
            

            // Adiciona o cabeçalho
            resultado.Add(linhas[0]);
            string[] formatos = {
            "d/M/yy",
            "dd/MM/yy",
            "d/M/yy",
            "dd/M/yy"
            };

            for (int i = 1; i < linhas.Length; i++)
            {
                string linha = linhas[i];
                linhaFinal = linha.Replace(" ", ";");
                string[] colunas = linhaFinal.Split(';');
                string dataHoraStr = colunas[0]; // primeira coluna é data + hora juntas

                

                if (colunas[2] == id_Sensor)
                {

                    if (DateTime.TryParseExact(colunas[0], formatos, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data))
                    {
                        if (TimeSpan.TryParse(colunas[1], out TimeSpan hora))
                        {
                            if (data.Date == dataLimite.Date)
                            {
                                string novaLinha = data.ToString("dd/MM/yyyy") + ";" + hora.ToString(@"hh\:mm") + ";" +
                                                   string.Join(";", colunas.Skip(2));

                                resultado.Add(novaLinha);
                            }
                        }
                    }
                }

            }
                // Salvar resultado em outro arquivo
                File.WriteAllLines("filtrado.csv", resultado);
            
            
        }

        private void grafic1_Load(object sender, EventArgs e)
        {

        }

        private void voltaMes_Click(object sender, EventArgs e)
        {
            
            if (mes > 1 )
            {
                grafic1.GraphPane.CurveList.Clear();
                mes--;
                Grafico(mes, sensorString);
                grafic1.Refresh();
            }
        }

        private void proximoMes_Click(object sender, EventArgs e)
        {
            if (mes < 12)
            {
                
                mes++;
                Grafico(mes, sensorString);
                grafic1.Refresh();
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

       

        private void ConfirmarSensorBT_Click(object sender, EventArgs e)
        {
            sensorString = SensorTB.Text;
            Grafico(mes,sensorString );
            
        }

        private void FiltrarMatriz()
        {
            string[] linhas = File.ReadAllLines("filtrado.csv");

            // Separar cabeçalho das linhas de dados
            string cabecalho = linhas[0];
            List<string> dados = new List<string>(linhas.Skip(1));
            dados.Sort((linha1, linha2) =>
            {
                string[] colunas1 = linha1.Split(';');
                string[] colunas2 = linha2.Split(';');

                int comparacaoData = string.Compare(colunas1[0], colunas2[0], StringComparison.OrdinalIgnoreCase);
                if (comparacaoData == 0)
                {
                    // Se a data for igual, compara pela hora
                    return string.Compare(colunas1[1], colunas2[1], StringComparison.OrdinalIgnoreCase);
                }
                return comparacaoData;
            });
            // Montar arquivo final
            MatrizOrdenada = new List<string> { cabecalho };
            MatrizOrdenada.AddRange(dados);

            // Pode salvar ou mostrar no console
            

            // Para salvar no arquivo descomente:
             File.WriteAllLines("Ordenado.csv", MatrizOrdenada);
            AnaliseMatriz();

        }
        
        public void AnaliseMatriz()
        {
            DateTime horaMaior = DateTime.Parse("00:00");
            DateTime horaMenor = DateTime.Parse("00:00");
            tempoGasto = horaMenor - horaMaior;
            string[] matriz = MatrizOrdenada.ToArray();
            for(int i = matriz.Length - 1; i >= 0; i--)
            {
                string linhas = matriz[i];
                
                string[] colunas1 = linhas.Split(';');
                if (colunas1[5] == "1" && DateTime.Parse(colunas1[1]) > horaMaior)
                {                       
                    horaMaior = DateTime.Parse((string)colunas1[1]);
                    
                }
                if (colunas1[5] == "0" && horaMaior > horaMenor || i == 1 && horaMaior > DateTime.Parse("00:00"))
                {
                    horaMenor = DateTime.Parse((String)colunas1[1]);
                   
                    tempoGasto += horaMaior - horaMenor;
                    horaMaior = DateTime.Parse("00:00");
                }
                
               

            }
        }

        public void CalculoWattsH(double potenciaWH)
        {
            horas = tempoGasto.TotalHours;
            consumoWH = potenciaWH * horas;
        }

    }
    }
