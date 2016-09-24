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
    public partial class Presentation : Form
    {
        public Presentation()
        {
            InitializeComponent();
        }

        public bool GoHome = true;
        public bool Force = false;
        public bool Open = true;

        private void start_animation_Tick(object sender, EventArgs e)
        {
            if (Open)
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
                    Force = true;
                    Close();
                }
            }
        }

        public void GetName()
        {
            int counter = 0;

            while (true)
            {
                counter++;

                if (System.IO.File.Exists(document_url.Text + "\\" + "Presentation" + counter.ToString() + ".nopres") == false)
                {
                    break;
                }
            }

            document_name.Text = "Presentation" + counter.ToString();
        }

        private void Presentation_Load(object sender, EventArgs e)
        {
            GetName();

            document_url.Items.Add(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments).ToString());
            document_url.Items.Add("Custom Location");
            document_url.SelectedIndex = 0;

            create_panel.Enabled = true;
            color_sync();

            document_name.Focus();
        }

        private void Presentation_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Force == false)
            {
                e.Cancel = true;
                Open = false;
            }
            else
            {
                if (GoHome == true)
                {
                    Form1 frm = new Form1();
                    frm.Show();
                }
            }
        }

        public void color_sync()
        {
            //Sync the color names and the rgb values in to the labels in the form
            if (selected_1.BackColor.IsKnownColor == true)
            {
                selected_label_1.Text = selected_1.BackColor.Name;
            }
            else
            {
                selected_label_1.Text = "Unknown";
            }

            selected_rgb_1.Text = "(" + selected_1.BackColor.R.ToString() + "," + selected_1.BackColor.G.ToString() + "," + selected_1.BackColor.B.ToString() + ")";

            if (selected_2.BackColor.IsKnownColor == true)
            {
                selected_label_2.Text = selected_2.BackColor.Name;
            }
            else
            {
                selected_label_2.Text = "Unknown";
            }

            selected_rgb_2.Text = "(" + selected_2.BackColor.R.ToString() + "," + selected_2.BackColor.G.ToString() + "," + selected_2.BackColor.B.ToString() + ")";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ColorDialog col = new ColorDialog();
            col.Color = selected_2.BackColor;
            col.AllowFullOpen = true;
            col.FullOpen = true;
            col.AnyColor = true;

            if (col.ShowDialog() == DialogResult.OK)
            {
                selected_2.BackColor = col.Color;
                color_sync();
            }
        }

        private void selected_2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ColorDialog col = new ColorDialog();
            col.Color = selected_2.BackColor;
            col.AllowFullOpen = true;
            col.FullOpen = true;
            col.AnyColor = true;

            if (col.ShowDialog() == DialogResult.OK)
            {
                selected_2.BackColor = col.Color;
                color_sync();
            }
        }

        private void selected_1_BackColorChanged(object sender, EventArgs e)
        {
            color_sync();
        }

        private void selected_2_BackColorChanged(object sender, EventArgs e)
        {
            color_sync();
        }

        private void panel11_Click(object sender, EventArgs e)
        {
            selected_1.BackColor = color_1.BackColor;
        }

        private void panel13_Click(object sender, EventArgs e)
        {
            selected_1.BackColor = color_2.BackColor;
        }

        private void panel14_Click(object sender, EventArgs e)
        {
            selected_1.BackColor = color_3.BackColor;
        }

        private void panel15_Click(object sender, EventArgs e)
        {
            selected_1.BackColor = color_4.BackColor;
        }

        private void panel16_Click(object sender, EventArgs e)
        {
            selected_1.BackColor = color_5.BackColor;
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            selected_2.BackColor = color2_1.BackColor;
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            selected_2.BackColor = color2_2.BackColor;
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            selected_2.BackColor = color_2_3.BackColor;
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            selected_2.BackColor = color_2_4.BackColor;
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            selected_2.BackColor = color2_5.BackColor;
        }

        private void panel8_Click(object sender, EventArgs e)
        {
            selected_2.BackColor = color2_6.BackColor;
        }

        private void panel9_Click(object sender, EventArgs e)
        {
            selected_2.BackColor = color2_7.BackColor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Open = false;
        }

        int counter = 0;
        int realw = Screen.PrimaryScreen.WorkingArea.Width;
        int realh = Screen.PrimaryScreen.WorkingArea.Height;

        public void MakeCentre()
        {
            Location = new Point((realw / 2) - (Width / 2), (realh / 2) - (Height / 2));
        }

        private void maximize_timer_Tick(object sender, EventArgs e)
        {
            counter++;

            switch (counter)
            {
                case 1:
                    Size = new Size(realw - 20,realh - 20);
                    MakeCentre();
                    break;
                case 2:
                    Size = new Size(realw - 10, realh - 10);
                    MakeCentre();
                    break;
                case 3:
                    Size = new Size(realw - 5, realh - 5);
                    MakeCentre();
                    break;
                case 4:
                    Size = new Size(realw - 2, realh - 2);
                    MakeCentre();
                    break;
                case 5:
                    Size = new Size(realw - 1, realh - 1);
                    MakeCentre();
                    break;
                case 6:
                    Size = new Size(realw, realh);
                    MakeCentre();
                    maximize_timer.Stop();
                    break;
            }
        }

        private void template1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void custom_btn2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ColorDialog cl = new ColorDialog();
            cl.Color = selected_1.BackColor;
            cl.FullOpen = true;
            cl.AllowFullOpen = true;
            cl.AnyColor = true;
            
            if (cl.ShowDialog() == DialogResult.OK)
            {
                selected_1.BackColor = cl.Color;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void create_button_Click(object sender, EventArgs e)
        {
            //Creation code implements right here

            try
            {
                if (System.IO.Directory.Exists(document_url.Items[document_url.SelectedIndex].ToString()))
                {
                    //The directory can be accessed and available
                    using (System.IO.StreamWriter sw = new System.IO.StreamWriter(document_url.Items[document_url.SelectedIndex].ToString() + "\\" + document_name.Text.ToString() + ".nopres"))
                    {
                        sw.WriteLine("[NVL:PRESENTATION");
                        sw.WriteLine("[NAME:" + document_name.Text.ToString() + "]");
                        sw.WriteLine("[SLIDE]");
                        sw.WriteLine("[/SLIDE]");

                        sw.Flush();
                        sw.Close();
                    }

                    Presentation_Editor edit = new Presentation_Editor((document_url.Items[document_url.SelectedIndex].ToString() + "\\" + document_name.Text.ToString() + ".nopres"));
                    edit.Show();
                    GoHome = false;
                    Open = false;
                }
                else
                {
                    Message msg = new Message("Ninponix Office 2017", "Ninponix Office cannot find the directory that you have mentioned", MessageIcon.MessageIconType.Error, MessageIcon.MessageMode.Presentation);
                    msg.ShowDialog();
                }
            }
            catch (Exception)
            {
                Message msg = new Message("Ninponix Office 2017", "Ninponix Office cannot access the location that you have mentioned", MessageIcon.MessageIconType.Error, MessageIcon.MessageMode.Presentation);
                msg.ShowDialog();
            }
        }

        private void document_url_SelectedValueChanged(object sender, EventArgs e)
        {
            if (document_url.Items[document_url.SelectedIndex].ToString() == "Custom Location")
            {
                FolderBrowserDialog folder = new FolderBrowserDialog();
                folder.Description = "Please select the directory to save the presentation";

                if (folder.ShowDialog() == DialogResult.OK)
                {
                    document_url.Items.Clear();
                    document_url.Items.Add(folder.SelectedPath);
                    document_url.Items.Add("Custom Location");
                    document_url.SelectedIndex = 0;
                }
            }
        }
    }
}
