using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ninponix_Office
{
    public partial class Presentation_Editor : Form
    {
        public bool GoHome = true;

        //Fields
        string _URL = "";

        public string CurScript = "";
        public string _NAME = "";
        public Color Accent = new Color();
        public Color TextCol = new Color();

        public Presentation_Editor(string url)
        {
            InitializeComponent();

            _URL = url;

            //try
            //{
                using (System.IO.StreamReader sr = new System.IO.StreamReader(url))
                {
                code_box.Text = sr.ReadToEnd();
                    sr.Close();
                }

                Execute();

            
            Location = new Point(0, 0);
            //}
            //catch (Exception)
            //{
             //   Message msg = new Message("Ninponix Office 2017", "Cannot access the presentation / document file. Please make sure it's not in use", MessageIcon.MessageIconType.Error, MessageIcon.MessageMode.Presentation);
              //  msg.ShowDialog();
           // }

            Size = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
        }

        string[] detail_collection = { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };

        int width_prop = 16;
        int height_prop = 9;

        public int Execute()
        {
            int start = Environment.TickCount;

            try
            {
                
                if (selected_slide == 1)
                {
                    previous_slide.Enabled = false;
                }
                else
                {
                    previous_slide.Enabled = true;
                }

                if (detail_collection[selected_slide].Length == 0)
                {
                    next_slide.Enabled = false;
                }
                else
                {
                    next_slide.Enabled = true;
                }

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
                                string aspect_ratio = argumentation.Split(';')[1].Replace("]","");

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
                    try {
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
                    }catch (Exception)
                    {

                    }
                }
            }
            catch (InvalidCastException)
            {

            }

            int difference = Environment.TickCount - start;
            UpdateStatus("Rendered in " + difference + " ms");

            return 1;
        }

        public int selected_slide = 1;

        private void splitContainer1_Panel1_Resize(object sender, EventArgs e)
        {

        }

        bool Open = true;
        bool Force = false;

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

                    Form1 f = new Form1();
                    f.Show();

                    try
                    {
                        foreach (var file in System.IO.Directory.GetFiles(Application.ExecutablePath.Replace("Ninponix Office.exe", "") + @"Runtime\NVL\V2Heap"))
                        {
                            System.IO.File.Delete(file);
                        }
                    }
                    catch (Exception)
                    {

                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string newTEXT = System.IO.File.ReadAllText(_URL);

            if (code_box.Text != newTEXT)
            {
                switch (MessageBox.Show("Ninponix Office has detected some changes, Do you want to save changes to this presentation?","Ninponix Office 2017", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
                {
                    case DialogResult.Yes:
                        try
                        {
                            using (System.IO.StreamWriter sw = new StreamWriter(_URL))
                            {
                                sw.Write(code_box.Text);
                                sw.Flush();
                                sw.Close();
                            }
                            Open = false;
                        }
                        catch (Exception)
                        { }
                        break;
                    case DialogResult.No:
                        Open = false;
                        break;
                }
            }
            else
            {
                Open = false;
            }
        }

        private void DeleteRecoveryFiles()
        {
            //Set the recovery information and save the backup files to recover by the program
            try
            {
                System.IO.File.Delete((Application.ExecutablePath.Replace("Ninponix Office.exe", "") + @"Recovery\VisualDocument.nvldoc"));
            }
            catch (Exception)
            {

            }
        }
        private void Presentation_Editor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Force == false)
            {
                if (code_box.Text != System.IO.File.ReadAllText(_URL))
                {
                    switch (MessageBox.Show("Ninponix Office has detected some changes, Do you want to save changes to this presentation?", "Ninponix Office 2017", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
                    {
                        case DialogResult.Yes:
                            try
                            {
                                using (System.IO.StreamWriter sw = new StreamWriter(_URL))
                                {
                                    sw.Write(code_box.Text);
                                    sw.Flush();
                                    sw.Close();
                                }
                                Open = false;
                                e.Cancel = true;
                                DeleteRecoveryFiles();
                            }
                            catch (Exception)
                            { }
                            break;
                        case DialogResult.No:
                            DeleteRecoveryFiles();
                            Open = false;
                            e.Cancel = true;
                            break;
                        case DialogResult.Cancel:
                            Open = true;
                            e.Cancel = true;
                            break;
                    }
                }
                else
                {
                    Open = false;
                    e.Cancel = true;
                }
            }
            else
            {
                if (GoHome)
                {
                    Form1 frm = new Form1();
                    frm.Show();
                }
            }
        }

        private void Presentation_Editor_Resize(object sender, EventArgs e)
        {
            int slideheight = slide_container.Height - 40;
            int unitvalue = int.Parse((slideheight / height_prop).ToString());
            int slidewidth = unitvalue * width_prop;

            slide.Size = new Size(slidewidth, slideheight);
            slide.Location = new Point((slide_container.Width /2)- (slide.Width /2), (slide_container.Height / 2) - (slide.Height / 2));

            
        }

        private void Presentation_Editor_Load(object sender, EventArgs e)
        {
            if (selected_slide == 1)
            {
                previous_slide.Enabled = false;
            }
            else
            {
                previous_slide.Enabled = true;
            }

            if (detail_collection[selected_slide].Length == 0)
            {
                next_slide.Enabled = false;
            }
            else
            {
                next_slide.Enabled = true;
            }

            //ENABLE RECOVERY OPTIONS
            RecoveryTimer.Enabled = Ninponix_Office.Properties.Settings.Default.RECOVERY_ENABLED;
            RecoveryTimer.Interval = (Ninponix_Office.Properties.Settings.Default.RECOVERY_TIME * 1000);
        }

        private void Presentation_Editor_TextChanged(object sender, EventArgs e)
        {
            title_doc.Text = Text;
        }

        int normalwidth = 1000;
        int normalheight = 600;

        int normalx = 100;
        int normaly = 100;

        private void maximize_btn_Click(object sender, EventArgs e)
        {
            if (Size == new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height))
            {
                maximize_btn.BackgroundImage = Image.FromFile((Application.ExecutablePath.Replace("Ninponix Office.exe", "") + "\\" + "OfficeData\\ImageRaw\\NOPES\\shader_max.png"));

                normal_timer.Start(); //starts the animation

                Location = new Point(0, 0);
                int slideheight = slide_container.Height - 40;
                int unitvalue = int.Parse((slideheight / height_prop).ToString());
                int slidewidth = unitvalue * width_prop;

                slide.Size = new Size(slidewidth, slideheight);
                slide.Location = new Point((slide_container.Width / 2) - (slide.Width / 2), (slide_container.Height / 2) - (slide.Height / 2));

                Execute();
            }
            else
            {
                maximize_btn.BackgroundImage = Image.FromFile((Application.ExecutablePath.Replace("Ninponix Office.exe", "") + "\\" + "OfficeData\\ImageRaw\\NOPES\\shader_normal.png"));

                maximize_timer.Start();

                int slideheight = slide_container.Height - 40;
                int unitvalue = int.Parse((slideheight / height_prop).ToString());
                int slidewidth = unitvalue * width_prop;

                slide.Size = new Size(slidewidth, slideheight);
                slide.Location = new Point((slide_container.Width / 2) - (slide.Width / 2), (slide_container.Height / 2) - (slide.Height / 2));

                Execute();
            }
        }

        int counter1 = 0;
        private void normal_timer_Tick(object sender, EventArgs e)
        {
            counter1++;

            switch (counter1)
            {
                case 0:
                    Size = new Size(normalwidth + 50, normalheight + 50);
                    Location = new Point(normalx - 50, normaly - 50);
                    Execute();
                    break;
                case 1:
                    Size = new Size(normalwidth + 25, normalheight + 25);
                    Location = new Point(normalx - 25, normaly - 25);
                    break;
                case 2:
                    Size = new Size(normalwidth + 15, normalheight + 15);
                    Location = new Point(normalx - 15 , normaly - 15);
                    Execute();
                    break;
                case 3:
                    Size = new Size(normalwidth + 5, normalheight + 5);
                    Location = new Point(normalx - 5, normaly - 5);
                    Execute();
                    break;
                case 4:
                    Size = new Size(normalwidth + 3, normalheight + 3);
                    Location = new Point(normalx - 3, normaly - 3);
                    Execute();
                    break;
                case 5:
                    Size = new Size(normalwidth + 2, normalheight + 2);
                    Location = new Point(normalx - 2, normaly - 2);
                    Execute();
                    break;
                case 6:
                    Size = new Size(normalwidth + 1, normalheight + 1);
                    Location = new Point(normalx - 1, normaly - 1);
                    Execute();
                    break;
                case 7:
                    Size = new Size(normalwidth, normalheight);
                    Location = new Point(normalx, normaly);
                    normal_timer.Stop();
                    Execute();
                    counter1 = 0;
                    break;
            }
        }

        int counter2 = 0;

        private void maximize_timer_Tick(object sender, EventArgs e)
        {
            counter2++;

            switch (counter2)
            {
                case 1:
                    Size = new Size(Screen.PrimaryScreen.WorkingArea.Width - 100, Screen.PrimaryScreen.WorkingArea.Height - 100);
                    Location = new Point((Screen.PrimaryScreen.WorkingArea.Width / 2) - (Width / 2), (Screen.PrimaryScreen.WorkingArea.Height / 2) - (Height / 2));
                    Execute();
                    break;
                case 2:
                    Size = new Size(Screen.PrimaryScreen.WorkingArea.Width - 50, Screen.PrimaryScreen.WorkingArea.Height - 50);
                    Location = new Point((Screen.PrimaryScreen.WorkingArea.Width / 2) - (Width / 2), (Screen.PrimaryScreen.WorkingArea.Height / 2) - (Height / 2));
                    Execute();
                    break;
                case 3:
                    Size = new Size(Screen.PrimaryScreen.WorkingArea.Width - 25, Screen.PrimaryScreen.WorkingArea.Height - 25);
                    Location = new Point((Screen.PrimaryScreen.WorkingArea.Width / 2) - (Width / 2), (Screen.PrimaryScreen.WorkingArea.Height / 2) - (Height / 2));
                    Execute();
                    break;
                case 4:
                    Size = new Size(Screen.PrimaryScreen.WorkingArea.Width - 15, Screen.PrimaryScreen.WorkingArea.Height - 15);
                    Location = new Point((Screen.PrimaryScreen.WorkingArea.Width / 2) - (Width / 2), (Screen.PrimaryScreen.WorkingArea.Height / 2) - (Height / 2));
                    Execute();
                    break;
                case 5:
                    Size = new Size(Screen.PrimaryScreen.WorkingArea.Width - 10, Screen.PrimaryScreen.WorkingArea.Height - 10);
                    Location = new Point((Screen.PrimaryScreen.WorkingArea.Width / 2) - (Width / 2), (Screen.PrimaryScreen.WorkingArea.Height / 2) - (Height / 2));
                    Execute();
                    break;
                case 6:
                    Size = new Size(Screen.PrimaryScreen.WorkingArea.Width - 5, Screen.PrimaryScreen.WorkingArea.Height - 5);
                    Location = new Point((Screen.PrimaryScreen.WorkingArea.Width / 2) - (Width / 2), (Screen.PrimaryScreen.WorkingArea.Height / 2) - (Height / 2));
                    Execute();
                    break;
                case 7:
                    Size = new Size(Screen.PrimaryScreen.WorkingArea.Width - 3, Screen.PrimaryScreen.WorkingArea.Height - 3);
                    Location = new Point((Screen.PrimaryScreen.WorkingArea.Width / 2) - (Width / 2), (Screen.PrimaryScreen.WorkingArea.Height / 2) - (Height / 2));
                    Execute();
                    break;
                case 8:
                    Size = new Size(Screen.PrimaryScreen.WorkingArea.Width - 2, Screen.PrimaryScreen.WorkingArea.Height - 2);
                    Location = new Point((Screen.PrimaryScreen.WorkingArea.Width / 2) - (Width / 2), (Screen.PrimaryScreen.WorkingArea.Height / 2) - (Height / 2));
                    Execute();
                    break;
                case 9:
                    Size = new Size(Screen.PrimaryScreen.WorkingArea.Width - 1, Screen.PrimaryScreen.WorkingArea.Height - 1);
                    Location = new Point((Screen.PrimaryScreen.WorkingArea.Width / 2) - (Width / 2), (Screen.PrimaryScreen.WorkingArea.Height / 2) - (Height / 2));
                    Execute();
                    break;
                case 10:
                    Size = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
                    Location = new Point((Screen.PrimaryScreen.WorkingArea.Width / 2) - (Width / 2), (Screen.PrimaryScreen.WorkingArea.Height / 2) - (Height / 2));
                    maximize_timer.Stop();
                    counter2 = 0;
                    Execute();
                    break;
            }
        }

        int beforex, beforey, afterx, aftery;

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            //set the before location of the form
            beforex = e.X;
            beforey = e.Y;
        }


        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (Size != new Size (Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height))
            {
                if (e.Button == MouseButtons.Left)
                {
                    afterx = e.X;
                    aftery = e.Y;

                    Width = Width + (afterx - beforey);
                    Height = Height + (aftery - beforey);

                    normalwidth = Width;
                    normalheight = Height;

                    Execute();
                }
                panel3.Cursor = Cursors.SizeNWSE;
            }
            else
            {
                panel3.Cursor = Cursors.Default;
            }
        }

        private void previous_slide_Click_1(object sender, EventArgs e)
        {
            selected_slide--;
            Execute();

            if (selected_slide == 1)
            {
                previous_slide.Enabled = false;
            }
            else
            {
                previous_slide.Enabled = true;
            }

            if (selected_slide == detail_collection.Length)
            {
                next_slide.Enabled = false;
            }
            else
            {
                next_slide.Enabled = true;
            }
        }

        //CODE FOR THE MOVING OF THE WINDOW
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            Size maxsize = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);

            if (Size != maxsize)
            {
                if (e.Button == MouseButtons.Left)
                {
                    aftermousex = e.X;
                    aftermousey = e.Y;

                    Location = new Point(Location.X + (aftermousex - beforemousex), Location.Y + (aftermousey - beforemousey));

                    normalx = Location.X;
                    normaly = Location.Y;
                }
            }
        }

        int beforemousex;
        int beforemousey;
        int aftermousex;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            menu_open_state = false;

            if (panel1.Height == 30)
            {
                label2.BackColor = Color.LightGreen;
                panel1.Height = Height - 25;
                code_box.Height = Height - 77 - 30;
                Execute();
            }
            else
            {
                panel1.Height = 30;
                label2.BackColor = Color.LimeGreen;
                Execute();
            }

            if (code_box.Text == "")
            {
                code_box.Text = System.IO.File.ReadAllText(_URL);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            panel1.Height = 30;
            label2.BackColor = Color.LimeGreen;
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            code_box.SaveFile(_URL, RichTextBoxStreamType.PlainText);
            PresentationToolBox.InsertText it = new PresentationToolBox.InsertText(_URL,selected_slide);
            it.ShowDialog();
            code_box.Text = it.NEWcode.ToString();
                
            Execute();   
        }

        private void button15_Click(object sender, EventArgs e)
        {
            menu_open_state = false;

            switch(MessageBox.Show("Do you want to save the file before closing?","Ninponix Office 2017", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    try
                    {
                        using (System.IO.StreamWriter sw = new StreamWriter(_URL))
                        {
                            sw.Write(code_box.Text);
                            sw.Flush();
                            sw.Close();
                        }
                    }
                    catch (Exception)
                    {
                        Message msg = new Message("Ninponix Office 2017", "Ninponix Office 2017 cannot save the presentation you requested.", MessageIcon.MessageIconType.Error, MessageIcon.MessageMode.Presentation);
                        msg.ShowDialog();
                    }
                    break;
                case DialogResult.No:
                    Open = false;
                    break;
            }
        }

        public bool menu_open_state = false;
        int speed = 10;

        private void menu_animation_Tick(object sender, EventArgs e)
        {
            if (menu_open_state == true)
            {
                if (menu_panel.Height < 260)
                {
                    menu_panel.Height += speed;
                    if (speed > 2)
                    {
                        speed--;
                    }
                }
                else
                {
                    speed = 30;
                }
            }
            else
            {
                if (menu_panel.Height != 0)
                {
                    menu_panel.Height -= speed;
                    if (speed > 2)
                    {
                        speed--;
                    }
                }
                else
                {
                    speed = 30;
                }
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            menu_open_state = !(menu_open_state);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            menu_open_state = false;

            OpenFileDialog open = new OpenFileDialog();
            open.FileName = "";
            open.Filter = "Ninponix Office Presentation|*.nopres|All Files|*.*";
            open.Title = "Open Presentation";

            if (open.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    int start = Environment.TickCount;

                    System.Diagnostics.Process.Start(Application.ExecutablePath, open.FileName);
                    Open = false;
                    menu_open_state = false;

                    int difference = Environment.TickCount - start;

                    UpdateStatus("Opened \'" + open.FileName + "\'" + " in " + difference + " ms");
                }
                catch (Exception)
                {
                    Message msg = new Message("Ninponix Office 2017", "Ninponix Office 2017 cannot open the presentation you requested.", MessageIcon.MessageIconType.Error, MessageIcon.MessageMode.Presentation);
                    msg.ShowDialog();
                }
            }
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            menu_open_state = false;

            switch (MessageBox.Show("Do you want to save the file before closing?", "Ninponix Office 2017", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    try
                    {
                        using (System.IO.StreamWriter sw = new StreamWriter(_URL))
                        {
                            sw.Write(code_box.Text);
                            sw.Flush();
                            sw.Close();
                        }
                    }
                    catch (Exception)
                    {
                        Message msg = new Message("Ninponix Office 2017", "Ninponix Office 2017 cannot save the presentation you requested.", MessageIcon.MessageIconType.Error, MessageIcon.MessageMode.Presentation);
                        msg.ShowDialog();
                    }

                    SaveFileDialog save = new SaveFileDialog();
                    save.Title = "Save the New Presentation";
                    save.Filter = "Ninponix Office Presentation|*.nopres";
                    save.FileName = "Untitled.nopres";

                    if (save.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            using (System.IO.StreamWriter sw = new StreamWriter(save.FileName))
                            {
                                sw.WriteLine("[NVL:PRESENTATION;(16,9)]");
                                sw.WriteLine("[NAME:UNTITLED]");
                                sw.WriteLine("");
                                sw.WriteLine("[SLIDE]");
                                sw.WriteLine("[/SLIDE]");
                                sw.Flush();
                                sw.Close();
                            }

                            System.Diagnostics.Process.Start(Application.ExecutablePath, save.FileName);
                            Open = false;
                        }
                        catch (Exception)
                        {
                            Message msg = new Message("Ninponix Office 2017", "Ninponix Office 2017 cannot create a new presentation you requested.", MessageIcon.MessageIconType.Error, MessageIcon.MessageMode.Presentation);
                            msg.ShowDialog();
                        }
                    }
                    break;
                    
                case DialogResult.No:
                    SaveFileDialog save2 = new SaveFileDialog();
                    save2.Title = "Save the New Presentation";
                    save2.Filter = "Ninponix Office Presentation|*.nopres";
                    save2.FileName = "Untitled.nopres";

                    if (save2.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            using (System.IO.StreamWriter sw = new StreamWriter(save2.FileName))
                            {
                                sw.WriteLine("[NVL:PRESENTATION;(16,9)]");
                                sw.WriteLine("[NAME:UNTITLED]");
                                sw.WriteLine("");
                                sw.WriteLine("[SLIDE]");
                                sw.WriteLine("[/SLIDE]");
                                sw.Flush();
                                sw.Close();
                            }

                            System.Diagnostics.Process.Start(Application.ExecutablePath, save2.FileName);
                            Open = false;
                        }
                        catch (Exception)
                        {
                            Message msg = new Message("Ninponix Office 2017", "Ninponix Office 2017 cannot create a new presentation you requested.", MessageIcon.MessageIconType.Error, MessageIcon.MessageMode.Presentation);
                            msg.ShowDialog();
                        }
                    }
                    break;
            }
        }

        /// <summary>
        /// Updates the status label of the current window
        /// </summary>
        /// <param name="Text">Input the text that you need to be updated</param>
        public void UpdateStatus(string Text)
        {
            //UPDATES THE STATUS LABELS FOR THE PRESENTATION FOUNDATION WINDOW
            status.Text = Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //SAVE CODE FOR NINPONIX OFFICE PRESENTATION PLATFORM
            try
            {
                int StartingTime = Environment.TickCount;

                using (System.IO.StreamWriter sw = new StreamWriter(_URL))
                {
                    sw.Write(code_box.Text);
                    sw.Flush();
                    sw.Close();
                }

                int difference = Environment.TickCount - StartingTime;

                menu_open_state = false;

                UpdateStatus("Saved as \'" + _URL + "\'" + " in " + difference + " ms");
            }
            catch (Exception)
            {
                Message msg = new Message("Ninponix Office 2017", "Ninponix Office 2017 cannot save the presentation you requested.", MessageIcon.MessageIconType.Error, MessageIcon.MessageMode.Presentation);
                msg.ShowDialog();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Save Presentation As...";
            save.Filter = "Ninponix Office Presentation|*.nopres";
            save.FileName = "Untitled.nopres";

            if (save.ShowDialog() == DialogResult.OK)
            {
                _URL = save.FileName;

                try
                {
                    int start = Environment.TickCount;

                    using (System.IO.StreamWriter sw = new StreamWriter(_URL))
                    {
                        sw.Write(code_box.Text);
                        sw.Flush();
                        sw.Close();
                    }

                    menu_open_state = false;

                    int difference = Environment.TickCount - start;

                    UpdateStatus("Saved as \'" + _URL + "\'" + " in " + difference + " ms");
                }
                catch (Exception)
                {
                    Message msg = new Message("Ninponix Office 2017", "Ninponix Office 2017 cannot save the presentation you requested.", MessageIcon.MessageIconType.Error, MessageIcon.MessageMode.Presentation);
                    msg.ShowDialog();
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            PresentationToolBox.PresentationViewer pv = new PresentationToolBox.PresentationViewer();
            button11_Click("", new EventArgs());
            pv._URL = _URL;
            pv.Show();
        }

        private void Presentation_Editor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true)
            {
                switch (e.KeyCode)
                {
                    //SAVE SHORTCUT
                    case Keys.S:
                        button11_Click("SHORTCUT", new EventArgs());
                        break;
                    //NEW SHORTCUT
                    case Keys.N:
                        button9_Click("SHORTCUT", new EventArgs());
                        break;
                    case Keys.O:
                        button10_Click("SHORTCUT", new EventArgs());
                        break;
                }
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            menu_open_state = false;
            //Export Identifier
            PresentationToolBox.Export export = new PresentationToolBox.Export(code_box.Text, _NAME);
            export.ShowDialog();
        }

        private void add_image_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(selected_slide.ToString());
            PresentationToolBox.AddImage add = new PresentationToolBox.AddImage(code_box.Text, selected_slide,_URL);
            add.ShowDialog();
            
            if (add.GET_CODE != "")
            {
                //It's not empty
                code_box.Text = add.GET_CODE;
                Execute();
            }
        }

        private void add_style_btn_Click(object sender, EventArgs e)
        {
            PresentationToolBox.AddStyle_NAME add = new PresentationToolBox.AddStyle_NAME(code_box.Text.ToString());
            add.ShowDialog();
            code_box.Text = add.RETURN_CODE;
        }

        private void style_management_btn_Click(object sender, EventArgs e)
        {
            PresentationToolBox.StyleManagement sty = new PresentationToolBox.StyleManagement();
            sty.CurrentCode = code_box.Text;
            sty.RETURN_CODE = code_box.Text;
            sty.ShowDialog();

            code_box.Text = sty.RETURN_CODE;
        }

        private void slide_management_Click(object sender, EventArgs e)
        {
            PresentationToolBox.SlideManagement slides = new PresentationToolBox.SlideManagement();
            slides.currentCode = code_box.Text;
            slides.currentSlide = selected_slide;

            slides.ShowDialog();

            code_box.Text = slides.RETURNCODE;

            selected_slide = 1;

            Execute();
        }

        private void presentation_information_Click(object sender, EventArgs e)
        {
            PresentationToolBox.InformationEditor ie = new PresentationToolBox.InformationEditor();
            ie.currentCode = code_box.Text;
            ie.ShowDialog();

            try
            {
                if (ie.RETURNCODE.Trim() != "")
                {
                    code_box.Text = ie.RETURNCODE.ToString();
                    UpdateStatus("Updated the Presentation Title");
                }
            }
            catch (Exception)
            {

            }
           
            Execute();
        }

        private void change_aspect_ratio_Click(object sender, EventArgs e)
        {
            PresentationToolBox.changeAspectRatio ca = new PresentationToolBox.changeAspectRatio();
            ca.CurrentCode = code_box.Text;
            ca.ShowDialog();
            code_box.Text = ca.RETURNCODE;

            Execute();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PresentationToolBox.PresentationViewer pv = new PresentationToolBox.PresentationViewer();
            button11_Click("", new EventArgs());
            pv._URL = _URL;
            pv.Show();
        }

        private void RecoveryTimer_Tick(object sender, EventArgs e)
        {
            //Set the recovery information and save the backup files to recover by the program
            try
            {
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(Application.ExecutablePath.Replace("Ninponix Office.exe", "") + @"Recovery\Presentation.nopres"))
                {
                    sw.Write(code_box.Text);
                    sw.Flush();
                    sw.Close();
                }
                UpdateStatus("Quickly Saved for Recover...");
            }
            catch (Exception)
            {
                Message msg = new Message("Ninponix Office 2017", "Sorry, Could not save the recovery Visual Document.", MessageIcon.MessageIconType.Error, MessageIcon.MessageMode.NVL); msg.ShowDialog();
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            menu_open_state = false;
            throw new NotImplementedException("LOAD HTML");
        }

        int aftermousey;

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            beforemousex = e.X;
            beforemousey = e.Y;
        }

        private void next_slide_Click_1(object sender, EventArgs e)
        {
            selected_slide++;
            Execute();

            if (selected_slide == 1)
            {
                previous_slide.Enabled = false;
            }
            else
            {
                previous_slide.Enabled = true;
            }

            if (detail_collection[selected_slide].Length == 0)
            {
                next_slide.Enabled = false;
            }
            else
            {
                next_slide.Enabled = true;
            }
        }
    }
}