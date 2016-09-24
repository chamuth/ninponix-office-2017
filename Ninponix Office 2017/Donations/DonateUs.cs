using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ninponix_Office.Donations
{
    public partial class DonateUs : Form
    {
        public DonateUs()
        {
            InitializeComponent();
        }

        bool open = true;

        private void entrance_close_animation_Tick(object sender, EventArgs e)
        {
            if (open)
            {
                if (Opacity != 1)
                {
                    Opacity += 0.1;
                }
            }
            else
            {
                if (Opacity != 0)
                {
                    Opacity -= 0.1;
                }
                else
                {
                    force = true;
                    Close();
                }
            }
        }

        bool force = false;

        private void DonateUs_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (force == false)
            {
                e.Cancel = true;
                open = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            open = false;
        }
    }
}
