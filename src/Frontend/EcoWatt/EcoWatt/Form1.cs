
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace EcoWatt
{
    public partial class DashBoard_Form : Form
    {
        string caminhoCSV_Base = "BD_Casa_Inteligente.csv";
        List<string> listaOrdenada;
        List<string> listaGastoOrdenada;

        DateTime dataRequisicao;
        TimeSpan horasAtivo;
        Double horas, potencialWatts, ConsumoWH;
 
       
        public DashBoard_Form()
        {
            InitializeComponent();
            loadForm(new home_Pag());
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

        private void exit_bnt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
