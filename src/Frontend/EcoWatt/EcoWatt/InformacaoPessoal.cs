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
    public partial class InformacaoPessoal : Form
    {
        public InformacaoPessoal()
        {
            Morador morador = TelaLogin.morador;
            InitializeComponent();
            Nome_text_input.Texts = $"{morador.Nome}";
            cpf_text_input.Texts = $"{morador.CPF}";
            idade_text_input.Texts = $"{morador.Idade}";
            endereço_text_input.Texts = $"{morador.Endereco}";
            Login_text_input.Texts = Program.loginText.ToString();
        }

        private void senha_input_text_Click(object sender, EventArgs e)
        {

        }
    }
}
