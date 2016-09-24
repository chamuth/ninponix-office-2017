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
    public partial class AddImage : Form
    {
        string TextRich;
        public string ReturnText;
        string project_loc = "";

        public AddImage(string Text, string project_location)
        {
            InitializeComponent();
            TextRich = Text;
            ReturnText = TextRich;
            project_loc = project_location;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Select Image...";
            open.Filter = "Image Files|*.jpeg;*.jpg;*.png;*.bmp;*.gif";

            if (open.ShowDialog() == DialogResult.OK)
            {
                name_txt.Text = open.FileName;
                Image img = Image.FromFile(open.FileName);
                width_txt.Text = img.Size.Width.ToString();
                height_txt.Text = img.Size.Height.ToString();

            }
        }

        private void AddImage_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Line = "";
            if (copy_check.Checked)
            {
                if (System.IO.File.Exists(name_txt.Text))
                {
                    DateTime d = DateTime.Now;
                    long counter = d.Ticks;

                    try
                    { //{IMAGE>200,200;200,200}F:\Ninponix\Youtube\Games & Media\Subway Surfers  Miami - Samsung Galaxy S3 Gameplay #2.mp4.jpg
                        System.IO.File.Copy(name_txt.Text, project_loc.ToString() + "\\" + counter.ToString() + ".png");
                        Line = "{IMAGE>" + x_txt.Text.ToString() + "," + y_txt.Text.ToString() + ";" + width_txt.Text.ToString() + "," + height_txt.Text.ToString() + "}..\\" + counter.ToString() + ".png";
                        ReturnText = TextRich + "\n" + Line.ToString();
                        Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Cannot copy the image to the project directory", "Ninponix Office 2017", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Close();
                    }
                }
            }
            else
            {
                Line = "{IMAGE>" + x_txt.Text.ToString() + "," + y_txt.Text.ToString() + ";" + width_txt.Text.ToString() + "," + height_txt.Text.ToString() + "}" + name_txt.Text.ToString();
                ReturnText = TextRich + "\n" + Line.ToString();
                Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReturnText = TextRich;
            Close();
        }

        private void name_txt_TextChanged(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(name_txt.Text) == false)
            {
                name_txt.BackColor = Color.Red;
            }
            else
            {
                name_txt.BackColor = Color.White;

                Image img = Image.FromFile(name_txt.Text);
                image_preview.Size = img.Size;
                image_preview.Image = img;
            }
        }

        private void width_txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int w = int.Parse(width_txt.Text);
                image_preview.Width = w;
                width_txt.BackColor = Color.White;
            }
            catch (Exception)
            {
                width_txt.BackColor = Color.Red;
            }
        }

        private void height_txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int h = int.Parse(height_txt.Text);
                image_preview.Height = h;
                height_txt.BackColor = Color.White;
            }
            catch (Exception)
            {
                height_txt.BackColor = Color.Red;
            }
        }

        private void x_txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(x_txt.Text);
                image_preview.Location = new Point(x, image_preview.Location.Y);
                x_txt.BackColor = Color.White;
            }
            catch (Exception)
            {
                x_txt.BackColor = Color.Red;
            }
        }

        private void y_txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int y = int.Parse(y_txt.Text);
                image_preview.Location = new Point(y, image_preview.Location.Y);
                y_txt.BackColor = Color.White;
            }catch (Exception)
            {
                y_txt.BackColor = Color.Red;
            }
        }
    }
}
