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
    public partial class InformationEditor : Form
    {

        //PUBLIC VARIABLES 
        public string currentCode, RETURNCODE = "";

        private void InformationEditor_Load(object sender, EventArgs e)
        {
            try
            {
                foreach (string line in currentCode.Split('\n'))
                {
                    if (line.TrimStart().StartsWith("[NAME"))
                    {
                        string currentname = line.Split(':')[1].Replace("]", "");
                        textBox1.Text = currentname;
                    }
                }
            }
            catch (Exception)
            {
                Message msg = new Message("Ninponix Office 2017", "Corrupted NVL Code in the script. Please fix it to continue", MessageIcon.MessageIconType.Error, MessageIcon.MessageMode.Presentation);
                msg.ShowDialog();
                Open = false;
            }
        }

        bool Open = true;
        bool Force = false;
        private void start_animation_Tick(object sender, EventArgs e)
        {
            if (Open == true)
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProcessCode()
        {
            string newcodecontainer = "";

            //Process the inputscript in to the output
            foreach (string line in currentCode.Split('\n'))
            {
                if (line.TrimStart().StartsWith("[NAME") == false)
                {
                    newcodecontainer += line.ToString() + "\n";
                }
            }

            string newTitle = "";

            if (textBox1.Text.Trim() == "")
                newTitle = "Untitled";
            else
                newTitle = textBox1.Text;

            RETURNCODE = "[NAME:" + newTitle.ToString() + "]" + "\n" + newcodecontainer;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Open = false;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                Open = false;
                ProcessCode();
            }
        }

        private void InformationEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Force == false)
            {
                e.Cancel = true;
                Open = false;
            }
        }

        public InformationEditor()
        {
            InitializeComponent();
        }

    }
}
