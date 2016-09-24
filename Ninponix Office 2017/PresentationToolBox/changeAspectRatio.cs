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
    public partial class changeAspectRatio : Form
    {
        public string CurrentCode;
        public string RETURNCODE;

        public changeAspectRatio()
        {
            InitializeComponent();
        }

        private void changeAspectRatio_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string catcher = "";

                foreach (string line in CurrentCode.Split('\n'))
                {
                    if (line.TrimStart().StartsWith("[NVL:PRESENTATION"))
                    {
                        //It's the presentation field
                    }
                    else
                    {
                        catcher += line + "\n";
                    }
                }

                string code = "[NVL:PRESENTATION;(" + comboBox1.Items[comboBox1.SelectedIndex].ToString().Replace(":", ",") + ")]";

                RETURNCODE = code + "\n" + catcher.ToString();
                open = false;
            }
            catch (Exception)
            {

            }
        }

        bool open = true;
        bool Force = false;

        private void start_animation_Tick(object sender, EventArgs e)
        {
            if (open == true)
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
                    Close();
                    Force = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RETURNCODE = CurrentCode;
            open = false;
        }

        private void learn_more_button_Click(object sender, EventArgs e)
        {
            try
            {
                string link = Links.GetLinkByKey("HELP_ASPECT_RATIO");
                System.Diagnostics.Process.Start(link);
            }
            catch (Exception)
            {

            }
        }

        private void changeAspectRatio_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Force == false)
            {
                e.Cancel = true;
                open = false;
            }
        }
    }
}
