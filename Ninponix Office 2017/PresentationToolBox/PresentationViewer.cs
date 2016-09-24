using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Ninponix_Office.PresentationToolBox
{
    public partial class PresentationViewer : Form
    {
        public PresentationViewer()
        {
            InitializeComponent();
        }

        public string _URL;
        public TextBox code_box = new TextBox();
        public string _NAME;

        string[] detail_collection = { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };

        int width_prop = 16;
        int height_prop = 9;

        public int Execute()
        {
            int start = Environment.TickCount;

            try
            {
                for (int i = 0; i < detail_collection.Length; i++)
                {
                    detail_collection[i] = "";
                }


                if (slide.Height != 0)
                {
                    //clear the container before adding the content to the slide :D
                    slide.Controls.Clear();

                    int counter = 0;
                    string cur_details = "";
                    bool slide_container = false;

                    //CHECK FOR STYLES AND DECLARE THEM IN ORDER
                    foreach (var lines in code_box.Text.Split('\n'))
                    {
                        if (lines.ToUpperInvariant().StartsWith("{STYLE:"))
                        {
                            // IT's a style we have to implement it to the V2HEAP
                            string argumentation = lines.Split(':')[1].Replace("}", "");
                            string stylename = argumentation.Split(';')[0];

                            using (System.IO.StreamWriter sw = new System.IO.StreamWriter((Application.ExecutablePath.Replace("Ninponix Office.exe", "") + "\\" + @"Runtime\NVL\V2Heap\" + stylename + ".nvlsty")))
                            {
                                sw.Write(argumentation.ToString());
                                sw.Flush();
                                sw.Close();
                            }
                        }
                    }

                    foreach (var lines in code_box.Text.Split('\n'))
                    {
                        //LINES


                        //Declaration Mark "[", "]"

                        if (lines.ToUpperInvariant().StartsWith("[NAME:"))
                        {
                            //NAME TAG is HERE
                            string name = lines.Split(':')[1].Replace("]", "");
                            _NAME = name;
                            Text = "Ninponix Office Presentation: " + name.ToString();
                        }
                        if (lines.ToUpperInvariant().StartsWith("[NVL:"))
                        {
                            //Proportional Scales of the slides are stored right here;
                            try
                            {
                                string argumentation = lines.Split(':')[1];
                                string aspect_ratio = argumentation.Split(';')[1].Replace("]", "");

                                int width = int.Parse(aspect_ratio.Split(',')[0].ToString());
                                int height = int.Parse(aspect_ratio.Split(',')[1].ToString());

                                width_prop = width;
                                height_prop = height;
                            }
                            catch (Exception)
                            {

                            }

                        }
                        if (lines.ToUpperInvariant().StartsWith("[SLIDE]"))
                        {
                            //SLIDE TAG IS HERE
                            counter++;
                            slide_container = true;
                        }
                        if (lines.ToUpperInvariant().StartsWith("[/SLIDE]"))
                        {
                            // SLIDE TAG IS ENDING RIGHT HERE
                            slide_container = false;

                            if (cur_details.EndsWith("#"))
                            {
                                cur_details = cur_details.Remove(cur_details.Length - 1, 1);
                                detail_collection[counter - 1] = cur_details;
                                cur_details = "";
                            }
                            else
                            {
                                detail_collection[counter - 1] = cur_details;
                                cur_details = "";
                            }

                        }
                        else
                        {
                            if (lines.Replace(" ", "") != "")
                            {
                                if (slide_container == true)
                                {
                                    cur_details += lines.ToString() + "#";

                                }
                            }

                        }
                    }

                    //ACTIVATES THE SLIDSE / CREATES THE SLIDES

                    string code_for_slide = detail_collection[selected_slide - 1];
                    string[] codes = code_for_slide.Split('#');
                    try
                    {
                        foreach (var code in codes)
                        {

                            //EACH CODE LINE IN THE SLIDE CODE

                            if (code.ToUpperInvariant().StartsWith("{TEXT:"))
                            {
                                //TEXT DECLARATION
                                string argumentation = code.Split(':')[1].Replace("}", "");
                                string[] arguments = argumentation.Split(';');

                                string text = arguments[0];
                                string style_name = arguments[1];
                                string location = arguments[2];
                                string size = arguments[3];

                                string Style_argumentation = "";

                                //Get Style information
                                using (System.IO.StreamReader sr = new System.IO.StreamReader((Application.ExecutablePath.Replace("Ninponix Office.exe", "") + "\\" + @"Runtime\NVL\V2Heap\" + style_name + ".nvlsty")))
                                {
                                    Style_argumentation = sr.ReadToEnd();
                                    sr.Close();
                                }

                                string font_name = Style_argumentation.Split(';')[1];
                                string font_size = Style_argumentation.Split(';')[2];
                                string forecolor = Style_argumentation.Split(';')[3];
                                string backcolor = Style_argumentation.Split(';')[4];
                                string font_style = Style_argumentation.Split(';')[5];

                                Label lbl = new Label();
                                lbl.Text = text;

                                string colorargumentation1 = forecolor.Replace("(", "").Replace(")", "");

                                byte r1 = byte.Parse(colorargumentation1.Split(',')[0]);
                                byte g1 = byte.Parse(colorargumentation1.Split(',')[1]);
                                byte b1 = byte.Parse(colorargumentation1.Split(',')[2]);

                                lbl.ForeColor = Color.FromArgb(r1, g1, b1);

                                string colorargumentation2 = backcolor.Replace("(", "").Replace(")", "");
                                byte r2 = byte.Parse(colorargumentation2.Split(',')[0]);
                                byte g2 = byte.Parse(colorargumentation2.Split(',')[1]);
                                byte b2 = byte.Parse(colorargumentation2.Split(',')[2]);

                                lbl.BackColor = Color.FromArgb(r2, g2, b2);

                                font_style = font_style.Trim();
                                double differ = slide.Height / 120;
                                float newsize = (float)(int.Parse(font_size) * (differ));
                                font_size = newsize.ToString();

                                switch (font_style.ToUpperInvariant())
                                {
                                    case "REGULAR":
                                        lbl.Font = new Font(font_name, float.Parse(font_size), FontStyle.Regular);
                                        break;
                                    case "BOLD":
                                        lbl.Font = new Font(font_name, float.Parse(font_size), FontStyle.Bold);
                                        break;
                                    case "ITALIC":
                                        lbl.Font = new Font(font_name, float.Parse(font_size), FontStyle.Italic);
                                        break;
                                    case "UNDERLINE":
                                        lbl.Font = new Font(font_name, float.Parse(font_size), FontStyle.Underline);
                                        break;
                                    case "STRIKEOUT":
                                        lbl.Font = new Font(font_name, float.Parse(font_size), FontStyle.Strikeout);
                                        break;
                                    case "BOLDITALIC":
                                        lbl.Font = new Font(font_name, float.Parse(font_size), FontStyle.Bold | FontStyle.Italic);
                                        break;
                                    case "BOLDUNDERLINE":
                                        lbl.Font = new Font(font_name, float.Parse(font_size), FontStyle.Regular | FontStyle.Underline);
                                        break;
                                    case "BOLDSTRIKEOUT":
                                        lbl.Font = new Font(font_name, float.Parse(font_size), FontStyle.Regular | FontStyle.Strikeout);
                                        break;
                                    case "ITALICUNDERLINE":
                                        lbl.Font = new Font(font_name, float.Parse(font_size), FontStyle.Italic | FontStyle.Underline);
                                        break;
                                    case "ITALICSTRIKEOUT":
                                        lbl.Font = new Font(font_name, float.Parse(font_size), FontStyle.Italic | FontStyle.Strikeout);
                                        break;
                                    case "BOLDITALICUNDERLINE":
                                        lbl.Font = new Font(font_name, float.Parse(font_size), FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                                        break;
                                    case "BOLDITALICUNDERLINESTRIKEOUT":
                                        lbl.Font = new Font(font_name, float.Parse(font_size), FontStyle.Bold | FontStyle.Italic | FontStyle.Underline | FontStyle.Strikeout);
                                        break;
                                }

                                string location_argumentation = location.Replace("(", "").Replace(")", "");
                                int x = int.Parse(location_argumentation.Split(',')[0].ToString());
                                int y = int.Parse(location_argumentation.Split(',')[1].ToString());

                                double differ2 = (slide.Height / 120);

                                lbl.Location = new Point((int)(x * differ2), (int)(y * differ2));

                                if (size != "AUTO")
                                {
                                    lbl.AutoSize = false;

                                    string size_argumentation = size.Replace("(", "").Replace(")", "");
                                    int w = int.Parse(size_argumentation.Split(',')[0].ToString().Replace("}", ""));
                                    int h = int.Parse(size_argumentation.Split(',')[1].ToString().Replace("}", ""));

                                    lbl.Size = new Size(w, h);
                                }
                                else
                                {
                                    lbl.AutoSize = true;
                                }

                                //COMPLETED THE INITIALIZATION OF tHE OBJECT

                                slide.Controls.Add(lbl);


                            }

                            else if (code.ToUpperInvariant().StartsWith("{IMAGE:"))
                            {
                                //{IMAGE:/hello.png;(0,0);(25%,25%)}
                                //an Image declaration
                                string argumentation = code.Remove(0, 7);
                                argumentation = argumentation.Replace("}", "");

                                string[] arguments = argumentation.Split(';');

                                string filename = arguments[0];
                                string location = arguments[1];
                                string size = arguments[2];

                                PictureBox p = new PictureBox();

                                p.SizeMode = PictureBoxSizeMode.StretchImage;
                                if (filename.TrimStart().StartsWith("/"))
                                {
                                    //It's in the samefolder
                                    FileInfo f = new FileInfo(_URL);
                                    string realfilename = f.DirectoryName + filename;
                                    p.Image = Image.FromFile(realfilename);
                                }
                                else
                                {
                                    p.Image = Image.FromFile(filename.TrimStart().TrimEnd());
                                }

                                string[] location_array = location.Replace("(", "").Replace(")", "").Split(',');

                                int x = int.Parse(location_array[0]);
                                int y = int.Parse(location_array[1]);

                                p.Location = new Point(x, y);

                                string[] size_array = size.Replace("(", "").Replace(")", "").Split(',');

                                string w = size_array[0];
                                string h = size_array[1];

                                if (w.TrimStart().EndsWith("%"))
                                {
                                    //A width percentage
                                    int percentage = int.Parse(w.Remove(w.Length - 1, 1));
                                    p.Width = (slide.Width / 100) * percentage;
                                }
                                else
                                {
                                    p.Width = int.Parse(w);
                                }

                                if (h.TrimStart().EndsWith("%"))
                                {
                                    //A width percentage
                                    int percentage = int.Parse(h.Remove(h.Length - 1, 1));
                                    p.Height = (slide.Height / 100) * percentage;
                                }
                                else
                                {
                                    p.Height = int.Parse(h);
                                }

                                slide.Controls.Add(p);

                            }
                        }
                    }
                    catch (Exception)
                    {

                    }
                }
            }
            catch (InvalidCastException)
            {

            }

            int difference = Environment.TickCount - start;
            
            return 1;
        }

        public int selected_slide = 1;

        private void PresentationViewer_Load(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader(_URL))
            {
                code_box.Text = sr.ReadToEnd();
                sr.Close();
            }

            Execute();
        }

        private void PresentationViewer_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Close();
                    break;
                case Keys.N:
                    if (slide.Visible == true)
                    {
                        if (detail_collection[selected_slide].Length == 0)
                        {
                            slide.Visible = false;
                        }
                        else
                        {
                            selected_slide++;
                            Execute();
                        }
                    }
                    else
                    {
                        Close();
                    }
                    break;
                case Keys.P:
                    if (slide.Visible == true)
                    {
                        if (selected_slide != 1)
                        {
                            selected_slide--;
                            Execute();
                        }
                    }
                    else
                    {
                        slide.Visible = true;
                    }
                    break;
                case Keys.Enter:
                    if (slide.Visible == true)
                    {
                        if (detail_collection[selected_slide].Length == 0)
                        {
                            slide.Visible = false;
                        }
                        else
                        {
                            selected_slide++;
                            Execute();
                        }
                    }
                    else
                    {
                        Close();
                    }
                    break;
                case Keys.Left:
                    if (slide.Visible == true)
                    {
                        if (selected_slide != 1)
                        {
                            selected_slide--;
                            Execute();
                        }
                    }
                    else
                    {
                        slide.Visible = true;
                    }
                    break;
                case Keys.Right:
                    if (slide.Visible == true)
                    {
                        if (detail_collection[selected_slide].Length == 0)
                        {
                            slide.Visible = false;
                        }
                        else
                        {
                            selected_slide++;
                            Execute();
                        }
                    }
                    else
                    {
                        Close();
                    }
                    break;
            }
        }

        private void PresentationViewer_MouseDown(object sender, MouseEventArgs e)
        {
            if (slide.Visible == true)
            {
                if (detail_collection[selected_slide].Length == 0)
                {
                    slide.Visible = false;
                }
                else
                {
                    selected_slide++;
                    Execute();
                }
            }
            else
            {
                Close();
            }
        }
    }
}
