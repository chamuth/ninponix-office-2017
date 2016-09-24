using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ninponix_Office.VisualDocumentToolBox
{
    public partial class ExternalOpen : Form
    {
        string Path = "";
        public ExternalOpen(string URL)
        {
            InitializeComponent();
            Path = URL;
        }

        private void ExternalOpen_Load(object sender, EventArgs e)
        {
            button1.Select();
        }

        private void ExternalOpen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("notepad.exe", Path.ToString());
                Close();
            }catch (Exception)
            {
                Close();
            }
        }
    }
}
