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
    public partial class AddImage : Form
    {
        public string code;
        public string URL;
        public int selected_slide = 0;
        public string PATH;
        public string GET_CODE = "";

        public AddImage(string CODE, int selection, string filename)
        {
            InitializeComponent();
            code = CODE;
            selected_slide = selection;
            try
            {
                System.IO.FileInfo fi = new System.IO.FileInfo(filename);
                PATH = fi.DirectoryName;
            }
            catch (Exception)
            {
                
            }
        }

        ////{IMAGE:/hello.png;(0,0);(25%,25%)}
        private void AddImage_Load(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.FileName = "";
            open.Filter = "Image Files|*.png;*.jpeg;*.gid;*.bmp;*.jpg";
            open.Title = "Select Image to continue";

            if (open.ShowDialog() == DialogResult.OK)
            {
                System.IO.FileInfo fi = new System.IO.FileInfo(open.FileName);
                
                if (fi.DirectoryName == PATH)
                {
                    //The image is already inside the project folder
                    URL = "/" + fi.Name;        
                }
                else
                {
                    URL = fi.FullName;
                }

                textBox1.Text = URL;

                try
                {
                    PictureBox pic = new PictureBox();
                    pic.SizeMode = PictureBoxSizeMode.AutoSize;
                    pic.Image = Image.FromFile(open.FileName);

                    if (checkBox1.Checked == false)
                    {
                        image_width.Value = pic.Image.Width;
                        image_height.Value = pic.Image.Height;
                    }
                    else
                    {
                        image_width.Value = 0;
                        image_height.Value = 0;
                    }
                }
                catch (Exception)
                {

                }
            }
            else
            {
                Close();
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.FileName = "";
            open.Filter = "Image Files|*.png;*.jpeg;*.gid;*.bmp;*.jpg";
            open.Title = "Select Image to continue";

            if (open.ShowDialog() == DialogResult.OK)
            {
                System.IO.FileInfo fi = new System.IO.FileInfo(open.FileName);

                if (fi.DirectoryName == PATH)
                {
                    //The image is already inside the project folder
                    URL = "/" + fi.Name;
                }
                else
                {
                    URL = fi.FullName;
                }

                textBox1.Text = URL;

                try
                {
                    PictureBox pic = new PictureBox();
                    pic.SizeMode = PictureBoxSizeMode.AutoSize;
                    pic.Image = Image.FromFile(open.FileName);

                    if (checkBox1.Checked == false)
                    {
                        image_width.Value = pic.Image.Width;
                        image_height.Value = pic.Image.Height;
                    }
                    else
                    {
                        image_width.Value = 0;
                        image_height.Value = 0;
                    }
                }
                catch (Exception)
                {

                }
            }
            else
            {
                Close();
            }
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(textBox1.Text))
            {
                //The file exists
                if (image_width.Value == 0 || image_height.Value == 0)
                {
                    Message msg = new Message("Ninponix Office 2017", "Insert image size to continue", MessageIcon.MessageIconType.Warning, MessageIcon.MessageMode.Presentation);
                    msg.ShowDialog();
                }
                else
                {
                    //You're good to go!
                    //{IMAGE:/hello.png;(0,0);(25%,25%)}

                    int line_counter = 0;
                    bool found = false;
                    foreach (var lines in code.Split('\n'))
                    {
                        if (found == false)
                        {
                            //Foreach lines in the code
                            if (lines.TrimStart().ToUpper().StartsWith("[SLIDE]"))
                            {
                                line_counter++;
                            }

                            GET_CODE += lines + "\n";

                            if (line_counter == selected_slide)
                            {
                                MessageBox.Show(selected_slide.ToString());
                                //The slide that we want is this!
                                string line_content = "";
                                if (checkBox1.Checked == true)
                                    line_content = "{IMAGE:" + URL + ";(" + x_location.Value.ToString() + "," + y_location.Value.ToString() + ");(" + image_width.Value.ToString() + "%," + image_height.Value.ToString() + "%)}";
                                else
                                    line_content = "{IMAGE:" + URL + ";(" + x_location.Value.ToString() + "," + y_location.Value.ToString() + ");(" + image_width.Value.ToString() + "," + image_height.Value.ToString() + ")}";

                                GET_CODE += line_content + "\n";
                                found = true;
                            }
                        }
                        else
                        {
                            GET_CODE += lines + "\n";
                        }
                    }

                    Close();
                }
            }
            else
            {
                Message msg = new Message("Ninponix Office 2017", "Please select an image to continue adding it to the slide", MessageIcon.MessageIconType.Warning, MessageIcon.MessageMode.Presentation);
                msg.ShowDialog();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
            GET_CODE = "";

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

        private void AddImage_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Force == false)
            {
                e.Cancel = true;
                Open = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                image_width.Maximum = 100;
                image_height.Maximum = 100;
            }
            else
            {
                image_width.Maximum = 80000;
                image_height.Maximum = 80000;
            }
        }
    }
}
