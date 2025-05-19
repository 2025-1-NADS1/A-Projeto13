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
    public partial class LoadForms : Form
    {
       
        
       
        public  LoadForms()
        {
            
            InitializeComponent();
            Morador morador = TelaLogin.morador;

            NomeMorador_text.Text = $"{morador.Nome}";
            ProximaTela();


        }
        public async void ProximaTela()
        {
            await Task.Delay(1000);
            TelaLogin.proximaTela = new DashBoard_Form();
        }

        

      

       
    }
}
