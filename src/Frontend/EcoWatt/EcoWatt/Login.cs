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
    public partial class TelaLogin : Form
    {
        public static string cpfMorador;
        public static Morador morador;
        public static Form proximaTela;
        bool valido = false;
        public TelaLogin()
        {
            
            InitializeComponent();
            
        }

       

        private void sataTextBox2_Click(object sender, EventArgs e)
        {
            
        }

        private async void ConectaBnt_Click(object sender, EventArgs e)
        {
            valido = await Program.VerificaLogin(Login_input_text.Texts, senha_input_text.Texts);
            morador = Program.morador;
            if (valido == true)
            {
                Console.WriteLine("login: " + Login_input_text.Texts + " senha: " + senha_input_text.Texts + " " + valido.ToString());               
                loadForm(new LoadForms());
                Console.WriteLine($"{morador.Nome}");
                

                await Task.Delay(3000); // Pode ser carregar dados, etc.

                // Agora exibe o formulário já carregado
                loadForm(proximaTela);

            }
            else
            {
                ErroText.Text = "Usuário ou senha invalidos!";
                await Task.Delay(2000);
                ErroText.Text = "";
            }
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

        private void ErroText_Click(object sender, EventArgs e)
        {

        }
    }
}
