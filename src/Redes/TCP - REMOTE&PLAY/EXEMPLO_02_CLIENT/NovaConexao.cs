using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXEMPLO_02_CLIENT
{
    public partial class NovaConexao : Form
    {
       public string mensagem;

        public NovaConexao()
        {
            
            InitializeComponent();
            
        }

            
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Quarto2_bnt_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.NewConnection();
            if (quarto1_bnt.Checked == true)
            {
                mensagem = "QUARTO1";
            }
            if (quarto2_bnt.Checked == true)
            {
                mensagem = "QUARTO2";
            }
            if (sala_bnt.Checked == true)
            {
                mensagem = "SALA";
            }
            if (cozinha_bnt.Checked == true)
            {
                mensagem = "COZINHA";
            }
            if (piscina_bnt.Checked == true)
            {
                mensagem = "PISCINA";
            }
           

            //Program.EscolhaAmbiente(mensagem);
            Program.NewMensage("GET AMBIENTE " + mensagem);
            respota_label.Text = Program.Resposta();
        }

        private void respota_label_Click(object sender, EventArgs e)
        {

        }
    }
}
