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
        
        public DashBoard_Form()
        {
            InitializeComponent();
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

        }
    }
}
