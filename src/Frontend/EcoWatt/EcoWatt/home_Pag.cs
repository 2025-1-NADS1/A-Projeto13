using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace EcoWatt
{
    public partial class home_Pag : Form
    {

        String[] DicaEconomia;
        Random rnd = new Random();
        int numDica;

        public home_Pag()
        {
            InitializeComponent();
            DicaEconomia = new String[] { 
                                      "Monitore o consumo de energia no app com frequência",
                                      "Desligue aparelhos em stand-by",
                                      "Aproveite a luz natural",
                                      "Substitua lâmpadas comuns por LED",
                                      "Programe horários de uso para aparelhos",
                                      "Mantenha filtros e equipamentos limpos",
                                      "Evite abrir a geladeira várias vezes",
                                      "Desligue luzes ao sair de um ambiente",
                                      "Reduza o brilho de TVs e monitores",
                                      "Ative alertas no app para consumo elevado"
                                       };
            numDica = rnd.Next(DicaEconomia.Length);
            text_Dicas.Text = DicaEconomia[numDica];
        }
        private void home_Pag_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
