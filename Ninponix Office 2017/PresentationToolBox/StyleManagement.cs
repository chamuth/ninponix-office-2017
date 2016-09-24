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
    public partial class StyleManagement : Form
    {
        public string CurrentCode;
        public string RETURN_CODE;

        public StyleManagement()
        {
            InitializeComponent();

        }

        private void Sync()
        {
            try
            {
                styleBox.Items.Clear();
                foreach (string line in CurrentCode.Split('\n'))
                {
                    //Check for stylings
                    if (line.TrimStart().StartsWith("{STYLE:"))
                    {
                        string name = line.TrimStart().Split(':')[1].Split(';')[0];
                        styleBox.Items.Add(name);
                    }
                }
            }
            catch (Exception)
            {

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


        private void StyleManagement_Load(object sender, EventArgs e)
        {
            Sync();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddStyle_NAME add = new AddStyle_NAME(CurrentCode);
            add.ShowDialog();

            if (add.RETURN_CODE == null)
            {

            }
            else
            {
                CurrentCode = add.RETURN_CODE;
            }

            Sync();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (styleBox.Items[styleBox.SelectedIndex] != null)
                {
                    string new_code = "";

                    foreach (string line in CurrentCode.Split('\n'))
                    {
                        if (line.TrimStart().StartsWith("{STYLE:"))
                        {
                            string name = line.TrimStart().Split(':')[1].Split(';')[0];
                            
                            if (name != styleBox.Items[styleBox.SelectedIndex].ToString())
                            {
                                new_code += line + "\n";
                            }
                        }
                    }

                    CurrentCode = new_code;
                    Sync();
                }
            }
            catch (Exception)
            {
                Message msg = new Message("Ninponix Office 2017", "Please select a style from the list to continue removing it from the code", MessageIcon.MessageIconType.Warning, MessageIcon.MessageMode.Presentation);
                msg.ShowDialog();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string new_code = "";

                foreach (string line in CurrentCode.Split('\n'))
                {
                    if (line.TrimStart().StartsWith("{STYLE:") == false)
                    {
                        new_code += line + "\n";
                    }
                }

                CurrentCode = new_code;
                Sync();
            }
            catch (Exception)
            {
                Message msg = new Message("Ninponix Office 2017", "An unexpected error occured with the Style Heap. Please try again", MessageIcon.MessageIconType.Warning, MessageIcon.MessageMode.Presentation);
                msg.ShowDialog();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RETURN_CODE = CurrentCode;
            Open = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Open = false;
        }

        private void StyleManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Force == false)
            {
                Open = false;
                e.Cancel = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Open = false;
        }
    }
}
