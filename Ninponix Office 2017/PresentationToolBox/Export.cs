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
    public partial class Export : Form
    {
        string _CODE;
        string _NAME;

        public Export(string CODE, string name)
        {
            InitializeComponent();
            _CODE = CODE;
            _NAME = name;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Export the presentation

            if (System.IO.Directory.Exists(textBox1.Text) == true)
            {
                bool good = true;

                foreach (string file in listBox1.Items)
                {
                    good = System.IO.File.Exists(file);
                }

                if (good == true)
                {
                    try
                    {
                        //Good to export the project
                        if (textBox1.Text.TrimEnd().EndsWith("\\"))
                        {
                            using (System.IO.StreamWriter sw = new System.IO.StreamWriter(textBox1.Text + "Presentation.nopres"))
                            {
                                sw.Write(_CODE);
                                sw.Flush();
                                sw.Close();
                            }

                            //Copy each of the files in the resources list
                            foreach (string file in listBox1.Items)
                            {
                                System.IO.FileInfo fl = new System.IO.FileInfo(file);

                                System.IO.File.Copy(file, textBox1.Text + fl.Name);
                            }

                        }
                        else
                        {
                            using (System.IO.StreamWriter sw = new System.IO.StreamWriter(textBox1.Text + "\\Presentation.nopres"))
                            {
                                sw.Write(_CODE);
                                sw.Flush();
                                sw.Close();
                            }

                            //Copy each of the files in the resources list
                            foreach (string file in listBox1.Items)
                            {
                                System.IO.FileInfo fl = new System.IO.FileInfo(file);

                                System.IO.File.Copy(file, textBox1.Text + "\\" + fl.Name);
                            }

                        }


                        if (MessageBox.Show("The project / presentation has been successfully exported. Do you want to preview it in the explorer?", "Ninponix Office 2017", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            System.Diagnostics.Process.Start("explorer", textBox1.Text);
                            Close();
                        }
                        else
                        {
                            Close();
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("The project export failed to proceed", "Ninponix Office 2017", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    Message m = new Message("Ninponix Office 2017", "Ninponix Office cannot find the resources that you have mentioned in the list.", MessageIcon.MessageIconType.Error, MessageIcon.MessageMode.Presentation);
                    m.ShowDialog();
                }
            }
            else
            {
                Message m = new Message("Ninponix Office 2017", "Ninponix Office cannot find the directory that you have mentioned", MessageIcon.MessageIconType.Error, MessageIcon.MessageMode.Presentation);
                m.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog d = new FolderBrowserDialog();
            d.Description = "Select where to export the presentation";

            if (d.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = d.SelectedPath;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.FileName = "";
                open.Filter = "All Files|*.*";
                open.Title = "Select resource to continue";

                if (open.ShowDialog() == DialogResult.OK)
                {
                    listBox1.Items.Add(open.FileName);
                }
            }
            catch (Exception)
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }catch (Exception)
            {

            }
        }

        private void Export_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
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

        private void Export_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Force == false)
            {
                e.Cancel = true;
                open = false;
            }
        }
    }
}
