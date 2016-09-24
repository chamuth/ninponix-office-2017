using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ninponix_Office.LearnMore
{
    public partial class VisualDocument : Form
    {
        public VisualDocument()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //SET THE VALUE IN THE SETTINGS PANEL
            Properties.Settings.Default.LearnMore = !(Properties.Settings.Default.LearnMore);
            Properties.Settings.Default.Save();
        }
    }
}
