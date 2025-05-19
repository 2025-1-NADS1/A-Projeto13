
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace EcoWatt
{
    public partial class DashBoard_Form : Form
    {
        string caminhoCSV_Base = "BD_Casa_Inteligente.csv";
       
        string  id_Sensor_String;
        List<string> listaFiltrado;
        List<string> listaOrdenada;
        List<string> listaGastoOrdenada;
        public static int id_sensor_int = 1;
        Morador morador;

        DateTime dataRequisicao;
        TimeSpan horasAtivo;
        Double horas, potenciaWatts, consumoWH;

        string[] formatos = {
            "d/M/yy",
            "dd/MM/yyyy",
            "d/M/yy",
            "dd/M/yy"
            };


        public DashBoard_Form()
        {
            InitializeComponent();
            loadForm(new home_Pag());
            NomeMorador_dash.Text = $"{TelaLogin.morador.Nome}";
            
            for (id_sensor_int = 1; id_sensor_int <= 5; id_sensor_int++) // <- Sensor de 1 a 5
            {
                Escolha(); // Ajusta id_Sensor_String e potenciaWatts
                listaGastoOrdenada = new List<string>();
                listaGastoOrdenada.Add("Data;Sensor;Hora_Ativo;ConsumoWH");
                for (int mes = 1; mes <= 7; mes++) // <- Janeiro até Julho
                {
                    int diasMes = DateTime.DaysInMonth(2025, mes);
                    // <-- Inicia nova lista para cada mês

                    for (int dia = 1; dia <= diasMes; dia++)
                    {
                        dataRequisicao = new DateTime(2025, mes, dia);
                        FiltroListaCSV(dataRequisicao);
                        CalculoWattsH(potenciaWatts);
                        
                        // Aqui preenche listaGastoOrdenada
                        string registro = $"{dataRequisicao:dd/MM/yyyy};{id_Sensor_String};{horasAtivo};{consumoWH:F2}";
                        listaGastoOrdenada.Add(registro);
                    }

                    
                    
                }
                // Depois de terminar o mês, salva
                string nomeArquivo = $"Ordenado_{id_Sensor_String}_2025.csv";
                File.WriteAllLines(nomeArquivo, listaGastoOrdenada);
            }
            Program.dashBoarCarregado = true;

        }

       


        public void Escolha()
        {

            switch (id_sensor_int)
            {
                case 1:
                    id_Sensor_String = "Quarto 01";
                    potenciaWatts = 1500;
                    break;
                case 2:
                    id_Sensor_String = "Quarto 02";
                    potenciaWatts = 1500;
                    break;
                case 3:
                    id_Sensor_String = "Sala";
                    potenciaWatts = 50;
                    break;
                case 4:
                    id_Sensor_String = "Cozinha";
                    potenciaWatts = 3000;
                    break;
                case 5:
                    id_Sensor_String = "Piscina";
                    potenciaWatts = 7000;
                    break;
            }

           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        bool menuExpand = false;
        private void MenuTransition_Tick(object sender, EventArgs e)
        {
            if (!menuExpand)
            {
                MenuContainer.Height += 10;
                  if(MenuContainer.Height >= 330)
                {
                    MenuTransition.Stop();
                    menuExpand = true;
                }
                
            }
            else
            {
                MenuContainer.Height -= 10;
                if(MenuContainer.Height <= 55)
                {
                    MenuTransition.Stop();
                    menuExpand = false;
                }
            }


        }

        private void bnt_Home_Click(object sender, EventArgs e)
        {
            MenuTransition.Start();
            loadForm(new home_Pag());

        }

        private void Panel_main_Paint(object sender, PaintEventArgs e)
        {

        }

        public void loadForm(object form)
        {
            if (this.Panel_main.Controls.Count > 0)
            {
                this.Panel_main.Controls.RemoveAt(0);
            }
            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.Panel_main.Controls.Add(f);
            this.Panel_main.Tag = f;
            f.Show();
        }

        private void btn_Qrt1_Click(object sender, EventArgs e)
        {
            loadForm(new AmbientePag(1,"Quarto 01", "1,5"));
        }

        private void btn_Qrt2_Click(object sender, EventArgs e)
        {
            loadForm(new AmbientePag(1, "Quarto 02", "1,5"));
        }

        private void bnt_sala_Click(object sender, EventArgs e)
        {
            loadForm(new AmbientePag(1, "Sala", "0,05"));
        }

        private void btn_sala_Click(object sender, EventArgs e)
        {
            loadForm(new AmbientePag(1, "Cozinha", "3"));
        }

        private void btn_Piscina_Click(object sender, EventArgs e)
        {
            loadForm(new AmbientePag(1, "Piscina", "7"));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadForm(new RankingForms());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadForm(new Gasto(1, "Quarto 01"));
        }

        private void exit_bnt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loadForm(new InformacaoPessoal());
        }

        public void FiltroListaCSV(DateTime dataRequisicao)
        {
            string[] linhas = File.ReadAllLines(caminhoCSV_Base);
            listaOrdenada = new List<string>();
            listaOrdenada.Add(linhas[0]); // Mantém o cabeçalho

            for (int i = 1; i < linhas.Length; i++)
            {
                string linhaAtual = linhas[i];
                string linhaSeparada = linhaAtual.Replace(" ", ";");
                string[] coluna = linhaSeparada.Split(';');
                
                //if (coluna.Length < 6) continue; // Previne erro se a linha for incompleta

                if (coluna[2] == id_sensor_int.ToString())
                {                    

                    if (DateTime.TryParseExact(coluna[0], formatos, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data))
                    {
                       
                        if (TimeSpan.TryParse(coluna[1], out TimeSpan hora))
                        {
                            if (data.Date == dataRequisicao.Date)
                            {
                                string novaLinha = data.ToString("dd/MM/yyyy") + ";" + hora.ToString(@"hh\:mm") + ";" + string.Join(";", coluna.Skip(2));
                                listaOrdenada.Add(novaLinha);
                                //Console.WriteLine("Adicionado:" + novaLinha + " a lista");
                                
                            }
                        }
                    }
                }
            }
            File.WriteAllLines("teste", listaOrdenada);


            // Ordenar listaOrdenada por data e hora
            listaOrdenada.Sort((linha1, linha2) =>
            {
                string[] coluna1 = linha1.Split(';');
                string[] coluna2 = linha2.Split(';');
                int comparadaData = string.Compare(coluna1[0], coluna2[0], StringComparison.OrdinalIgnoreCase);
                if (comparadaData == 0)
                {
                    return string.Compare(coluna1[1], coluna2[1], StringComparison.OrdinalIgnoreCase);
                }
                return comparadaData;
            });

            listaFiltrado = new List<string>();
            listaFiltrado.AddRange(listaOrdenada);

            // Calcular horas ativas
            DateTime horaMaior = DateTime.Parse("00:00");
            DateTime horaMenor = DateTime.Parse("00:00");
            horasAtivo = TimeSpan.Zero;

            for (int i = listaOrdenada.ToArray().Length -1 ; i >= 0; i--)
            {
                string[] coluna = listaOrdenada[i].Split(';');

                if (coluna.Length < 6) continue; // Segurança extra

                if (coluna[5] == "1" && TimeSpan.TryParse(coluna[1], out TimeSpan horaAtual))
                {
                    if (horaAtual > horaMaior.TimeOfDay)
                    {
                        horaMaior = DateTime.ParseExact(coluna[1], "HH:mm", CultureInfo.InvariantCulture);
                    }
                }
                if (coluna[5] == "0" && horaMaior > horaMenor || i == 0 && horaMaior > DateTime.Parse("00:00"))
                {
                    horaMenor = DateTime.ParseExact(coluna[1], "HH:mm", CultureInfo.InvariantCulture);
                   
                    horasAtivo += horaMaior - horaMenor;
                    horaMaior = DateTime.Parse("00:00");
                }
            }
            if(horasAtivo <= TimeSpan.Parse("00:00"))
            {
                horasAtivo = TimeSpan.Parse("01:00");
            }

           
        }


        

        public void CalculoWattsH(double potenciaWH)
        {
            horas = horasAtivo.TotalHours;
            consumoWH = potenciaWH * horas;
        }
    }
}
