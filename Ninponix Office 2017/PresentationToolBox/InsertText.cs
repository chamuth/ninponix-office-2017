using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ninponix_Office.PresentationToolBox
{
    public partial class InsertText : Form
    {
        public string publicURL = "";
        public int selslide = 0;

        public string NEWcode = "";

        public InsertText(string URL, int SelectedSlide)
        {
            InitializeComponent();
            publicURL = URL;
            selslide = SelectedSlide;
        }

        private void InsertText_FormClosing(object sender, FormClosingEventArgs e)
        {

            choose_style cs = new choose_style(publicURL, textBox1.Text, selslide);
            cs.ShowDialog();
            NEWcode = cs.NEWCODE;

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //Text Recieved
                // SEND text to the style selection window

                Close();
            }
        }

        
        private void close_btn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}