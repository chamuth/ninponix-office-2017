using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ninponix_Office
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void About_Load(object sender, EventArgs e)
        {

        }

        private void About_Timer_Tick(object sender, EventArgs e)
        {
            if (panel1.Location.Y != -panel1.Height)
            {
                int i = panel1.Location.Y;
                i--;
                panel1.Location = new Point(panel1.Location.X, i);
            }
            else
            {
                panel1.Location = new Point(panel1.Location.X, about_container.Height + 200);
            }
        }
    }
}
