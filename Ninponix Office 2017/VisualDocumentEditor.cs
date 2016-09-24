using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ninponix_Office
{
    public partial class VisualDocumentEditor : Form
    {
        string file;
        bool preview;

        public VisualDocumentEditor(string filepath, bool prev)
        {
            InitializeComponent();
            title_doc.Text = "Untitled Document - Ninponix Visual Document";
            file = filepath;

            preview = prev;   
        }

        int count = 0;
        int count2 = 0;
        int screenx = Screen.PrimaryScreen.WorkingArea.Width;
        int screeny = Screen.PrimaryScreen.WorkingArea.Height;

        bool open = true;
        Collection<string> UndoCollection = new Collection<string>();

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (open == true)
            {
                if (Opacity != 1)
                {
                    Opacity += 0.1;
                }

                count++;

                switch (count)
                {
                    case 1:
                        Width = screenx - 25;
                        Height = screeny - 25;
                        Location = new Point((Screen.PrimaryScreen.WorkingArea.Width / 2) - (Width / 2), (Screen.PrimaryScreen.WorkingArea.Height / 2) - ((Height) / 2));
                        break;
                    case 2:
                        Width = screenx - 20;
                        Height = screeny - 20;
                        Location = new Point((Screen.PrimaryScreen.WorkingArea.Width / 2) - (Width / 2), (Screen.PrimaryScreen.WorkingArea.Height / 2) - ((Height) / 2));
                        break;
                    case 3:
                        Width = screenx - 15;
                        Height = screeny - 15;
                        Location = new Point((Screen.PrimaryScreen.WorkingArea.Width / 2) - (Width / 2), (Screen.PrimaryScreen.WorkingArea.Height / 2) - ((Height) / 2));
                        break;
                    case 4:
                        Width = screenx - 10;
                        Height = screeny - 10;
                        Location = new Point((Screen.PrimaryScreen.WorkingArea.Width / 2) - (Width / 2), (Screen.PrimaryScreen.WorkingArea.Height / 2) - ((Height) / 2));
                        break;
                    case 5:
                        Width = screenx - 5;
                        Height = screeny - 5;
                        Location = new Point((Screen.PrimaryScreen.WorkingArea.Width / 2) - (Width / 2), (Screen.PrimaryScreen.WorkingArea.Height / 2) - ((Height) / 2));
                        break;
                    case 6:
                        Width = screenx - 4;
                        Height = screeny - 4;
                        Location = new Point((Screen.PrimaryScreen.WorkingArea.Width / 2) - (Width / 2), (Screen.PrimaryScreen.WorkingArea.Height / 2) - ((Height) / 2));
                        break;
                    case 7:
                        Width = screenx - 3;
                        Height = screeny - 3;
                        Location = new Point((Screen.PrimaryScreen.WorkingArea.Width / 2) - (Width / 2), (Screen.PrimaryScreen.WorkingArea.Height / 2) - ((Height) / 2));
                        break;
                    case 8:
                        Width = screenx - 2;
                        Height = screeny - 2;
                        Location = new Point((Screen.PrimaryScreen.WorkingArea.Width / 2) - (Width / 2), (Screen.PrimaryScreen.WorkingArea.Height / 2) - ((Height) / 2));
                        break;
                    case 9:
                        Width = screenx - 1;
                        Height = screeny - 1;
                        Location = new Point((Screen.PrimaryScreen.WorkingArea.Width / 2) - (Width / 2), ((Screen.PrimaryScreen.Bounds.Height - 34) / 2) - ((Height) / 2));
                        break;
                    case 10:
                        Width = screenx;
                        Height = screeny;
                        Location = new Point((Screen.PrimaryScreen.WorkingArea.Width / 2) - (Width / 2), (Screen.PrimaryScreen.WorkingArea.Height / 2) - ((Height) / 2));
                        break;
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
                    force = true;
                    Close();

                    if (preview == false)
                    {
                        Form1 frm = new Form1();
                        frm.Show();
                    }
                }

                count2++;

                switch (count2)
                {
                    case 1:
                        Width = screenx;
                        Height = screeny;
                        Location = new Point((Screen.PrimaryScreen.WorkingArea.Width / 2) - (Width / 2), (Screen.PrimaryScreen.WorkingArea.Height / 2) - ((Height) / 2));
                        break;
                    case 2:
                        Width = screenx - 1;
                        Height = screeny - 1;
                        Location = new Point((Screen.PrimaryScreen.WorkingArea.Width / 2) - (Width / 2), (Screen.PrimaryScreen.WorkingArea.Height / 2) - ((Height) / 2));
                        break;
                    case 3:
                        Width = screenx - 2;
                        Height = screeny - 2;
                        Location = new Point((Screen.PrimaryScreen.WorkingArea.Width / 2) - (Width / 2), (Screen.PrimaryScreen.WorkingArea.Height / 2) - ((Height) / 2));
                        break;
                    case 4:
                        Width = screenx - 3;
                        Height = screeny - 3;
                        Location = new Point((Screen.PrimaryScreen.WorkingArea.Width / 2) - (Width / 2), (Screen.PrimaryScreen.WorkingArea.Height / 2) - ((Height) / 2));
                        break;
                    case 5:
                        Width = screenx - 4;
                        Height = screeny - 4;
                        Location = new Point((Screen.PrimaryScreen.WorkingArea.Width / 2) - (Width / 2), (Screen.PrimaryScreen.WorkingArea.Height / 2) - ((Height) / 2));
                        break;
                    case 6:
                        Width = screenx - 5;
                        Height = screeny - 5;
                        Location = new Point((Screen.PrimaryScreen.WorkingArea.Width / 2) - (Width / 2), (Screen.PrimaryScreen.WorkingArea.Height / 2) - ((Height) / 2));
                        break;
                    case 7:
                        Width = screenx - 10;
                        Height = screeny - 10;
                        Location = new Point((Screen.PrimaryScreen.WorkingArea.Width / 2) - (Width / 2), (Screen.PrimaryScreen.WorkingArea.Height / 2) - ((Height) / 2));
                        break;
                    case 8:
                        Width = screenx - 15;
                        Height = screeny - 15;
                        Location = new Point((Screen.PrimaryScreen.WorkingArea.Width / 2) - (Width / 2), (Screen.PrimaryScreen.WorkingArea.Height / 2) - ((Height) / 2));
                        break;
                    case 9:
                        Width = screenx - 20;
                        Height = screeny - 20;
                        Location = new Point((Screen.PrimaryScreen.WorkingArea.Width / 2) - (Width / 2), ((Screen.PrimaryScreen.Bounds.Height - 34) / 2) - ((Height) / 2));
                        break;
                    case 10:
                        Width = screenx - 25;
                        Height = screeny - 25;
                        Location = new Point((Screen.PrimaryScreen.WorkingArea.Width / 2) - (Width / 2), (Screen.PrimaryScreen.WorkingArea.Height / 2) - ((Height) / 2));
                        break;
                }
            }

        }

        string VDE_settings = Application.ExecutablePath.Replace("Ninponix Office.exe", "") + "\\" + "OfficeData\\Values\\1099.nofficesetting";

        private void VisualDocumentEditor_Load(object sender, EventArgs e)
        {
            try
            {
                using (System.IO.StreamReader sr = new System.IO.StreamReader(file))
                {
                    richTextBox1.Text = sr.ReadToEnd();
                    sr.Close();
                }

                richTextBox1.Focus();
                CheckGrammar();
                Run();
                checkBox2.Checked = Properties.Settings.Default.VisualDocumentAutoRender;
                doc_panel.Location = new Point((splitContainer1.Panel2.Width / 2) - (doc_panel.Width / 2), (splitContainer1.Panel2.Height / 2) - (doc_panel.Height / 2));

            }
            catch (Exception)
            {
                Message msg = new Message("Ninponix Office 2017", "Could not open the Visual Document you've tried to open", MessageIcon.MessageIconType.Error, MessageIcon.MessageMode.NVL);
                msg.ShowDialog();
                Close();
            }

            //ENABLE RECOVERY OPTIONS
            recovery_timer.Enabled = Ninponix_Office.Properties.Settings.Default.RECOVERY_ENABLED;
            recovery_timer.Interval = (Ninponix_Office.Properties.Settings.Default.RECOVERY_TIME * 1000);
        }

        bool show_menu = false;
        int countt1 = 0;
        int countt2 = 0;
        bool nowanimating = false;

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (show_menu == false)
            {
                countt1++;
                switch (countt1)
                {
                    case 1:
                        menu_panel.Width = 200;
                        nowanimating = true;
                        break;
                    case 2:
                        menu_panel.Width = 100;
                        break;
                    case 3:
                        menu_panel.Width = 50;
                        break;
                    case 4:
                        menu_panel.Width = 25;
                        break;
                    case 5:
                        menu_panel.Width = 10;
                        break;
                    case 6:
                        menu_panel.Width = 5;
                        break;
                    case 7:
                        menu_panel.Width = 4;
                        break;
                    case 8:
                        menu_panel.Width = 3;
                        break;
                    case 9:
                        menu_panel.Width = 2;
                        break;
                    case 10:
                        menu_panel.Width = 0;
                        countt1 = 0;
                        timer2.Stop();
                        nowanimating = false;
                        break;
                }
            }
            else
            { //else on the menu close code
                countt2++;
                switch (countt2)
                {
                    case 1:
                        menu_panel.Width = 0;
                        nowanimating = true;
                        break;
                    case 2:
                        menu_panel.Width = 100;
                        break;
                    case 3:
                        menu_panel.Width = 150;
                        break;
                    case 4:
                        menu_panel.Width = 175;
                        break;
                    case 5:
                        menu_panel.Width = 180;
                        break;
                    case 6:
                        menu_panel.Width = 190;
                        break;
                    case 7:
                        menu_panel.Width = 195;
                        break;
                    case 8:
                        menu_panel.Width = 197;
                        break;
                    case 9:
                        menu_panel.Width = 199;
                        break;
                    case 10:
                        menu_panel.Width = 200;
                        countt2 = 0;
                        timer2.Stop();
                        nowanimating = false;
                        break;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Cleans the VHeap which is filled with Styles and variables.
        /// </summary>
        public void CleanVHeap()
        {
            foreach (var files in System.IO.Directory.GetFiles(Application.ExecutablePath.Replace("Ninponix Office.exe", "") + "\\" + @"Runtime\NVL\VHeap"))
            {
                try
                {
                    System.IO.File.Delete(files); //Apply the delete method to all the styles
                }
                catch (Exception)
                {
                    Log.WriteEntry("Failed cleaning VHeap", "VDE");
                }
            }

            //Clean to go
        }

        public void delete_recovery_files()
        {
            try
            {
                System.IO.FileInfo f = new System.IO.FileInfo(Application.ExecutablePath.Replace("Ninponix Office.exe", "") + @"Recovery\VisualDocument.nvldoc");
                f.Delete();
            }
            catch (Exception)
            { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //put savage code before the close code
            string unsave = "";
            using (System.IO.StreamReader sr = new System.IO.StreamReader(file))
            {
                unsave = sr.ReadToEnd();
                sr.Close();
            }
            if (unsave != richTextBox1.Text)
            {
                if (MessageBox.Show("Do you want to Save the Document?", "Ninponix Office 2017", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (System.IO.StreamWriter sw = new System.IO.StreamWriter(file))
                    {
                        sw.Write(richTextBox1.Text);
                        sw.Flush();
                        sw.Close();
                    }
                    open = false;
                    CleanVHeap();

                    //Delete the recovery files
                    delete_recovery_files();
                }
                else
                {
                    open = false;
                    delete_recovery_files();
                }
            }
            else
            {
                open = false;
            }
        }

        bool menu_pinned = false;

        private void VisualDocumentEditor_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.X == 0 && e.Y > 32 && menu_pinned == false)
            {
                show_menu = true;
                timer2.Start();
            }
        }

        private void menu_panel_MouseLeave(object sender, EventArgs e)
        {
            if (MousePosition.X - Location.X != 200 || MousePosition.X - Location.X != 201)
            {
                if (menu_pinned == false && (MousePosition.X - Location.X) > 200)
                {
                    if (nowanimating == false)
                    {
                        show_menu = false;
                        timer2.Start();
                    }
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (menu_pinned == true)
            {
                menu_pinned = false;

            }
            else
            {
                menu_pinned = true;
            }
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (menu_pinned == true)
            {
                menu_pinned = false;

            }
            else
            {
                menu_pinned = true;
            }
        }

        string[] keywords = { "NAME:", "DOCUMENT:", "STYLE", "txt", "color" };

        public void CheckGrammar()
        {
            int start_point = richTextBox1.SelectionStart;
            string now_word = "";
            int charcount = 0;

            foreach (var chars in richTextBox1.Text)
            {
                charcount++;
                if (chars == ' ' || chars == '\n' || chars == '[' || chars == ']')
                {
                    now_word = "";
                }
                else
                {
                    now_word += chars;
                }
                foreach (var word in keywords)
                {
                    try
                    {
                        if (richTextBox1.Text[charcount - now_word.Length - 1] == '[')
                        {
                            if (now_word.ToLower() == word.ToLower())
                            {
                                richTextBox1.Select(charcount - now_word.Length, now_word.Length);
                                richTextBox1.SelectionColor = Color.Orange;
                                richTextBox1.Select(start_point, 0);

                            }
                            else
                            {
                                richTextBox1.SelectionColor = Color.FromArgb(150, 150, 150);
                            }
                        }
                    }
                    catch (Exception)
                    {

                    }
                }
            }
        }

        string[] variable_chars = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "_" };

        string Document_Title;
        string DocSize;
        Color DocBackCol;

        /*
        DOCSIZES for international standards
        A4: 2480x3508
        A3: 3508x4961
        */

        Size a5 = new Size(419, 595);
        Size a4 = new Size(595, 841);
        Size a3 = new Size(841, 1190);
        Size letter = new Size(612, 792);
        Size legal = new Size(612, 1008);
        Size tabloid = new Size(792, 1224);

        public int bug = 0;

        public void UpdateInformation()
        {
            width_doc_lbl.Text = doc_panel.Width.ToString() + " px";
            height_doc_lbl.Text = doc_panel.Height.ToString() + " px";
            bg_col_lbl.Text = doc_panel.BackColor.ToKnownColor().ToString();
            
            if (richTextBox1.Text.Count() > 1024) //Add size information
                size_label.Text = (richTextBox1.Text.Count() / 1024).ToString() + " KB";
            else
                size_label.Text = richTextBox1.Text.Count().ToString() + " bytes";
            
        }

        public bool Run()
        {
            try
            {
                //Clear Elemental Information
                elements_panel.Controls.Clear();

                bool doc_attributes_present = false;
                doc_panel.Visible = true;
                //Runtime Variable Clearance (Styles, Vars)
                foreach (var files in System.IO.Directory.GetFiles(Application.ExecutablePath.Replace("Ninponix Office.exe", "") + "\\" + "Runtime\\NVL\\VHeap\\"))
                {
                    try
                    {
                        System.IO.File.Delete(files);
                    }
                    catch (Exception)
                    {
                        output.Visible = true;
                        output_text.Text = "Warning: Failed deleting the Runtime variables. The document may not work properly";
                    }
                }


                // Check for NVL Grammar
                foreach (string Lines in richTextBox1.Lines)
                {
                    if (Lines.Replace(" ", "").Count() != 0)
                    {
                        var LineContent = Lines.TrimStart(' ');
                        if (LineContent.StartsWith("//") == false)
                        {
                            if (LineContent.StartsWith("[") & LineContent.EndsWith("]"))
                            {//DOC-INFO
                                if (LineContent.StartsWith("[NAME:"))
                                {
                                    var getLiner = LineContent.Remove(0, 6);
                                    getLiner = getLiner.Remove(getLiner.Count() - 1, 1);
                                    Document_Title = getLiner;
                                    if (Document_Title.Replace(" ", "").Count() == 0)
                                    {
                                        Text = "Untitled Document - Ninponix Visual Document";
                                    }
                                    else
                                    {
                                        Text = Document_Title.ToString() + " - Ninponix Visual Document";
                                    }
                                }
                                else if (LineContent.ToUpper().StartsWith("[DOCUMENT:"))
                                {
                                    if (doc_attributes_present == false)
                                    {
                                        var getArgs = LineContent.Remove(0, 10);
                                        getArgs = getArgs.Remove(getArgs.Count() - 1, 1);
                                        string[] args = getArgs.Split(';');
                                        DocSize = args[0];
                                        //Set the Document Size
                                        if (DocSize.StartsWith("(") == false)
                                        {
                                            switch (DocSize.ToUpper())
                                            {
                                                case "A5":
                                                    doc_panel.Size = a5;
                                                    break;
                                                case "A4":
                                                    doc_panel.Size = a4;
                                                    break;
                                                case "A3":
                                                    doc_panel.Size = a3;
                                                    break;
                                                case "LETTER":
                                                    doc_panel.Size = letter;
                                                    break;
                                                case "LEGAL":
                                                    doc_panel.Size = legal;
                                                    break;
                                                case "TABLOID":
                                                    doc_panel.Size = tabloid;
                                                    break;
                                            }

                                        }
                                        else
                                        {
                                            try
                                            {
                                                string parameters = DocSize.Replace("(", "").Replace(")", "");
                                                int w = int.Parse(parameters.Split(',')[0]);
                                                int h = int.Parse(parameters.Split(',')[1]);
                                                doc_panel.Size = new Size(w, h);
                                            }
                                            catch (Exception)
                                            {
                                                output.Visible = true;
                                                System.Media.SystemSounds.Asterisk.Play();
                                                output_text.Text = "Error: The document Size parameter is invalid. \nPlease enter a valid integral value that represents the pixels";
                                                bug++;
                                            }
                                        }

                                        DocBackCol = Color.FromName(args[1]);
                                        doc_panel.BackColor = DocBackCol;
                                        doc_attributes_present = true;
                                    }
                                    else
                                    {
                                        output.Visible = true;
                                        System.Media.SystemSounds.Asterisk.Play();
                                        output_text.Text = "Warning: Two Document Attributes found in the NVL Code. \nKeep in mind that only the first Document attribute is rendered by the NLPP";
                                        bug++;
                                    }
                                }
                                else if (LineContent.ToUpper().StartsWith("[STYLE"))
                                {
                                    string stylename = LineContent.Split(':')[0].ToString();
                                    stylename = stylename.Remove(0, 7);
                                    System.IO.StreamWriter sw = new System.IO.StreamWriter(Application.ExecutablePath.Replace("Ninponix Office.exe", "") + "\\" + "Runtime\\NVL\\VHeap\\" + stylename + ".nvlsty");

                                    using (sw)
                                    {
                                        try
                                        {
                                            string arguments = LineContent.Split(':')[1].ToString();
                                            arguments = arguments.Remove(arguments.Count() - 1, 1);
                                            sw.Write(arguments);
                                            sw.Flush();
                                            sw.Close();
                                        }
                                        catch (Exception)
                                        {
                                            output.Visible = true;
                                            output_text.Text = "Warning: The style attribute parameters are invalid";
                                        }
                                    }
                                }
                                else if (LineContent.StartsWith("[IMAGE"))
                                {
                                    Text = "";
                                    string clean1 = LineContent.Remove(0, 7);

                                    string[] names = clean1.Split(']');
                                    string url = names[1];
                                    string vname = names[0];
                                    Text = vname;
                                    try
                                    {
                                        System.IO.File.Copy(url, Application.ExecutablePath.Replace("Ninponix Office.exe", "") + "\\" + "Runtime\\NVL\\VHeap\\res\\" + vname + ".nvlres", true);
                                    }
                                    catch (Exception)
                                    {
                                        output.Visible = true;
                                        output_text.Text = "Warning: Cannot find the path specified";
                                    }
                                }
                            }
                            else if (LineContent.StartsWith("{"))
                            {
                                if (LineContent.StartsWith("{IMAGE>"))
                                {//  It's an image
                                    try
                                    {
                                        string url = LineContent.Split('}')[1];
                                        string attributes = LineContent.Split('}')[0];
                                        string args = attributes.Replace("{IMAGE>", "");

                                        if (url.StartsWith(".."))
                                        {
                                            System.IO.FileInfo fi = new System.IO.FileInfo(file);
                                            string realurl = url.Replace("..", fi.DirectoryName);
                                            if (System.IO.File.Exists(realurl))
                                            {

                                                string location = args.Split(';')[0];
                                                string size = args.Split(';')[1];
                                                int x = int.Parse(location.Split(',')[0]);
                                                int y = int.Parse(location.Split(',')[1]);
                                                int w = int.Parse(size.Split(',')[0]);
                                                int h = int.Parse(size.Split(',')[1]);

                                                PictureBox p = new PictureBox();
                                                p.SizeMode = PictureBoxSizeMode.StretchImage;

                                                p.Image = Image.FromFile(realurl);

                                                p.Size = new Size(w, h);
                                                doc_panel.Controls.Add(p);
                                                p.Location = new Point(x, y);

                                            }
                                        }
                                        else
                                        {
                                            if (System.IO.File.Exists(url))
                                            {
                                                string location = args.Split(';')[0];
                                                string size = args.Split(';')[1];
                                                int x = int.Parse(location.Split(',')[0]);
                                                int y = int.Parse(location.Split(',')[1]);
                                                int w = int.Parse(size.Split(',')[0]);
                                                int h = int.Parse(size.Split(',')[1]);

                                                PictureBox p = new PictureBox();
                                                p.SizeMode = PictureBoxSizeMode.StretchImage;

                                                p.Image = Image.FromFile(url);

                                                p.Size = new Size(w, h);
                                                doc_panel.Controls.Add(p);
                                                p.Location = new Point(x, y);
                                            }
                                        }

                                    }
                                    catch (Exception)
                                    {
                                        output.Visible = true;
                                        output_text.Text = "Warning: Image attributes are invalid.";
                                    }

                                }
                                else if (LineContent.StartsWith("{CRTC:"))
                                {
                                    //It's A CIRCLE 
                                    // {CRTC:0,0;200,200}(255,255,255)

                                    try
                                    {
                                        string _BasicArgumentation = LineContent.Split(':')[1];
                                        string _ColorArgumentation = _BasicArgumentation.Split('}')[1];
                                        string _LocationArgumentation = _BasicArgumentation.Split('}')[0].Split(';')[0];
                                        string _SizeArgumentation = _BasicArgumentation.Split('}')[0].Split(';')[1];

                                        byte r = byte.Parse(_ColorArgumentation.Split(',')[0]);
                                        byte g = byte.Parse(_ColorArgumentation.Split(',')[1]);
                                        byte b = byte.Parse(_ColorArgumentation.Split(',')[2]);

                                        int x = int.Parse(_LocationArgumentation.Split(',')[0]);
                                        int y = int.Parse(_LocationArgumentation.Split(',')[1]);

                                        int w = int.Parse(_SizeArgumentation.Split(',')[0]);
                                        int h = int.Parse(_SizeArgumentation.Split(',')[1]);

                                        SolidBrush br = new SolidBrush(Color.FromArgb(r, g, b));
                                        Rectangle area = new Rectangle(x, y, w, h);

                                        doc_panel.CreateGraphics().FillEllipse(br, area); //FILL THE AREA WITH THE BRUSH
                                    }
                                    catch (Exception)
                                    {
                                        output.Visible = true;
                                        output_text.Text = "Warning: The CRTC argumentation is invalid.";
                                    }
                                }
                                else if (LineContent.StartsWith("{CRT4:"))
                                {//It's a rectangle / square man Create a 4 Sided object
                                 // {CRT4:0,0;0,0}(0,0,0);2(255,0,0)
                                 // {CRT4:x,y;w,h}(r,g,b);wi(r,g,b)

                                    try
                                    {
                                        string argumentation1 = LineContent.Split('}')[0].ToString();
                                        string argumentation2 = LineContent.Split('}')[1].ToString();

                                        argumentation1 = argumentation1.Replace("{CRT4:", "").ToString();

                                        Point location = new Point(int.Parse(argumentation1.Split(';')[0].Split(',')[0].ToString()), int.Parse(argumentation1.Split(';')[0].Split(',')[1].ToString()));
                                        Size size = new Size(0, 0);

                                        if (argumentation1.Split(';')[1].Contains(",") == false)
                                        {
                                            if (argumentation1.Split(';')[1] == "FULL")
                                            {
                                                size = new Size(doc_panel.Width, doc_panel.Height);
                                            }
                                        }
                                        else
                                        {
                                            size = new Size(int.Parse(argumentation1.Split(';')[1].Split(',')[0].ToString()), int.Parse(argumentation1.Split(';')[1].Split(',')[1].ToString()));
                                        }
                                        string colcodes = argumentation2.Split(';')[0];
                                        colcodes = colcodes.Replace("(", "").Replace(")", "");

                                        int r1 = int.Parse(colcodes.Split(',')[0]);
                                        int g1 = int.Parse(colcodes.Split(',')[1]);
                                        int b1 = int.Parse(colcodes.Split(',')[2]);

                                        Color backCol = Color.FromArgb(r1, g1, b1);

                                        string borderoptions = argumentation2.Split(';')[1].ToString();
                                        int borderwidth = int.Parse(borderoptions.Split('(')[0].ToString());

                                        string colcodes2 = borderoptions.Split('(')[1].ToString().Replace(")", "");

                                        int r2 = int.Parse(colcodes2.Split(',')[0]);
                                        int g2 = int.Parse(colcodes2.Split(',')[1]);
                                        int b2 = int.Parse(colcodes2.Split(',')[2]);

                                        Color borderColor = Color.FromArgb(r2, g2, b2);

                                        //GOT ALL SETTINGS ONLY HAVE TO ASSOCIATE THEM WITH THE EXECUTION FLOW.

                                        Panel p = new Panel();
                                        p.Size = size;
                                        p.Location = location;
                                        p.BackColor = backCol;

                                        Panel TopPanel = new Panel();
                                        Panel BottomPanel = new Panel();
                                        Panel LeftPanel = new Panel();
                                        Panel RightPanel = new Panel();

                                        p.Controls.Add(TopPanel);
                                        p.Controls.Add(BottomPanel);
                                        p.Controls.Add(LeftPanel);
                                        p.Controls.Add(RightPanel);

                                        TopPanel.Dock = DockStyle.Top;
                                        BottomPanel.Dock = DockStyle.Bottom;
                                        RightPanel.Dock = DockStyle.Right;
                                        LeftPanel.Dock = DockStyle.Left;

                                        TopPanel.Height = borderwidth;
                                        BottomPanel.Height = borderwidth;
                                        LeftPanel.Width = borderwidth;
                                        RightPanel.Width = borderwidth;

                                        TopPanel.BackColor = borderColor;
                                        BottomPanel.BackColor = borderColor;
                                        LeftPanel.BackColor = borderColor;
                                        RightPanel.BackColor = borderColor;

                                        doc_panel.Controls.Add(p);
                                    }
                                    catch (Exception)
                                    {
                                        output.Visible = true;
                                        output_text.Text = "Warning: Cannot display the CRT Method output in an invalid parameter environment. Make sure the parameters are correct...";
                                    }
                                }
                                else if (LineContent.StartsWith("{AREA>"))
                                {//It's a TextArea
                                    try
                                    {
                                        string arguments_content = LineContent.Remove(0, 6);
                                        string content = arguments_content.Split('}')[1];
                                        string argument = arguments_content.Split('}')[0];
                                        string[] arguments = argument.Split(';');

                                        string style_name = arguments[0];
                                        string size = arguments[1];
                                        string location = arguments[2];

                                        Label lbl = new Label();
                                        lbl.Text = content;
                                        size = size.Replace("(", "").Replace(")", "");
                                        lbl.AutoSize = false;
                                        int width = int.Parse(size.Split(',')[0]);
                                        int height = int.Parse(size.Split(',')[1]);
                                        lbl.Size = new Size(width, height);
                                        int x = int.Parse(location.Split(',')[0]);
                                        int y = int.Parse(location.Split(',')[1]);

                                        lbl.Location = new Point(x, y);



                                        //Get Style Content
                                        if (System.IO.File.Exists(Application.ExecutablePath.Replace("Ninponix Office.exe", "") + "\\" + "Runtime\\NVL\\VHeap\\" + style_name + ".nvlsty"))
                                        {//Check for argumentations in the code
                                         //SAMPLE: Font=Arial;Size=12;Color=0,0,0;Style=Italic;Background=255,255,255
                                            string Style_Content = System.IO.File.ReadAllText(Application.ExecutablePath.Replace("Ninponix Office.exe", "") + "\\" + "Runtime\\NVL\\VHeap\\" + style_name + ".nvlsty");
                                            string[] argumentation = Style_Content.Split(';');
                                            string FontName = "Arial";
                                            string FontSize = "12";
                                            Color FontColor = Color.Black;
                                            string FontStyle = "Regular";
                                            Color BackgroundColor = Color.Transparent;

                                            //Set Values right Now;

                                            FontName = argumentation[0].Remove(0, 5);
                                            FontSize = argumentation[1].Remove(0, 5);
                                            string _ColorAttr = argumentation[2].Remove(0, 6).ToString();
                                            string[] color_attr = _ColorAttr.Split(',');
                                            int r1 = int.Parse(color_attr[0]); int g1 = int.Parse(color_attr[1]); int b1 = int.Parse(color_attr[2]);

                                            FontColor = Color.FromArgb(r1, g1, b1);

                                            FontStyle = argumentation[3].ToString().Remove(0, 6);

                                            string _ColorAttr2 = argumentation[4].ToString().Remove(0, 11);


                                            if (_ColorAttr2.Contains(",") == true)
                                            {
                                                string[] color_attr2 = _ColorAttr2.Split(',');

                                                int r2 = int.Parse(color_attr2[0]); int g2 = int.Parse(color_attr2[1]); int b2 = int.Parse(color_attr2[2]);
                                                BackgroundColor = Color.FromArgb(r2, g2, b2);
                                            }
                                            else
                                            {
                                                if (_ColorAttr2 == "transparent")
                                                {
                                                    BackgroundColor = Color.Transparent;
                                                }
                                            }

                                            lbl.ForeColor = FontColor;
                                            lbl.BackColor = BackgroundColor;

                                            Font f = new Font(FontName, int.Parse(FontSize));


                                            switch (FontStyle)
                                            {
                                                case "Regular":
                                                    f = new Font(FontName, int.Parse(FontSize), System.Drawing.FontStyle.Regular);
                                                    break;
                                                case "Bold":
                                                    f = new Font(FontName, int.Parse(FontSize), System.Drawing.FontStyle.Bold);
                                                    break;
                                                case "Italic":
                                                    f = new Font(FontName, int.Parse(FontSize), System.Drawing.FontStyle.Italic);
                                                    break;
                                                case "Strikeout":
                                                    f = new Font(FontName, int.Parse(FontSize), System.Drawing.FontStyle.Strikeout);
                                                    break;
                                                case "Underline":
                                                    f = new Font(FontName, int.Parse(FontSize), System.Drawing.FontStyle.Underline);
                                                    break;
                                                case "BoldItalic":
                                                    f = new Font(FontName, int.Parse(FontSize), System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
                                                    break;
                                                case "BoldStrikeout":
                                                    f = new Font(FontName, int.Parse(FontSize), System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout);
                                                    break;
                                                case "BoldUnderline":
                                                    f = new Font(FontName, int.Parse(FontSize), System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline);
                                                    break;
                                                case "ItalicUnderline":
                                                    f = new Font(FontName, int.Parse(FontSize), System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline);
                                                    break;
                                                case "BoldItalicUnderline":
                                                    f = new Font(FontName, int.Parse(FontSize), System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline);
                                                    break;
                                            }

                                            lbl.Font = f;
                                            doc_panel.Controls.Add(lbl);
                                        }
                                        else
                                        {
                                            output.Visible = true;
                                            output_text.Text = "Warning: Style is invalid. Please make sure you declared the style before declaring TextArea";
                                        }
                                    }
                                    catch (Exception)
                                    {
                                        output.Visible = true;
                                        output_text.Text = "Warning: The TextArea parameters are invalid.";
                                    }
                                }
                                else
                                {
                                    string onerem = LineContent.Remove(0, 1);
                                    string[] args = onerem.Split(':');
                                    string style_name = args[0];

                                    if (System.IO.File.Exists(Application.ExecutablePath.Replace("Ninponix Office.exe", "") + "\\" + "Runtime\\NVL\\VHeap\\" + style_name + ".nvlsty"))
                                    {//Check for argumentations in the code


                                        try
                                        {
                                            string args_content = args[1];
                                            string arg = args_content.Split('}')[0];
                                            string text = args_content.Split('}')[1];
                                            string location = arg;
                                            string style_content = "";

                                            using (System.IO.StreamReader sr = new System.IO.StreamReader(Application.ExecutablePath.Replace("Ninponix Office.exe", "") + "\\" + "Runtime\\NVL\\VHeap\\" + style_name + ".nvlsty"))
                                            {
                                                style_content = sr.ReadToEnd();
                                                sr.Close();
                                            }

                                            //Get the information before assigning the values
                                            string fontname = "Arial";
                                            string fontstyle = "Regular";
                                            string fontsize = "12";
                                            string fontcolor = "0,0,0";
                                            string fontbackground = "transparent";

                                            //assigning the got values

                                            string[] style_arguments = style_content.Split(';');

                                            foreach (var a in style_arguments)
                                            {
                                                string propname = a.Split('=')[0];
                                                string value = a.Split('=')[1];
                                                switch (propname)
                                                {
                                                    case "Font":
                                                        fontname = value;
                                                        break;
                                                    case "Size":
                                                        fontsize = value;
                                                        break;
                                                    case "Color":
                                                        fontcolor = value;
                                                        break;
                                                    case "Style":
                                                        fontstyle = value;
                                                        break;
                                                    case "Background":
                                                        fontbackground = value;
                                                        break;
                                                }
                                            }

                                            Label lbl = new Label();
                                            lbl.Text = text;
                                            lbl.AutoSize = true;
                                            Font f = new Font(fontname, 12, FontStyle.Regular);

                                            switch (fontstyle)
                                            {
                                                case "Regular":
                                                    f = new Font(fontname, int.Parse(fontsize), FontStyle.Regular);
                                                    break;
                                                case "Bold":
                                                    f = new Font(fontname, int.Parse(fontsize), FontStyle.Bold);
                                                    break;
                                                case "Italic":
                                                    f = new Font(fontname, int.Parse(fontsize), FontStyle.Italic);
                                                    break;
                                                case "Strikeout":
                                                    f = new Font(fontname, int.Parse(fontsize), FontStyle.Strikeout);
                                                    break;
                                                case "Underline":
                                                    f = new Font(fontname, int.Parse(fontsize), FontStyle.Underline);
                                                    break;
                                                case "BoldItalic":
                                                    f = new Font(fontname, int.Parse(fontsize), FontStyle.Bold | FontStyle.Italic);
                                                    break;
                                                case "BoldStrikeout":
                                                    f = new Font(fontname, int.Parse(fontsize), FontStyle.Bold | FontStyle.Strikeout);
                                                    break;
                                                case "BoldUnderline":
                                                    f = new Font(fontname, int.Parse(fontsize), FontStyle.Bold | FontStyle.Underline);
                                                    break;
                                                case "ItalicUnderline":
                                                    f = new Font(fontname, int.Parse(fontsize), FontStyle.Italic | FontStyle.Underline);
                                                    break;
                                                case "BoldItalicUnderline":
                                                    f = new Font(fontname, int.Parse(fontsize), FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                                                    break;
                                            }
                                            lbl.Font = f;

                                            int x = int.Parse(location.Split(',')[0]);
                                            int y = int.Parse(location.Split(',')[1]);

                                            lbl.Location = new Point(x, y);

                                            //Get forecolor
                                            byte r = byte.Parse(fontcolor.Split(',')[0]);
                                            byte g = byte.Parse(fontcolor.Split(',')[1]);
                                            byte b = byte.Parse(fontcolor.Split(',')[2]);

                                            lbl.ForeColor = Color.FromArgb(r, g, b);

                                            //Get backcolor
                                            if (fontbackground.Contains(",") != true)
                                            {
                                                if (fontbackground == "transparent")
                                                {
                                                    lbl.BackColor = Color.Transparent;
                                                }
                                            }
                                            else
                                            {
                                                byte r2 = byte.Parse(fontbackground.Split(',')[0]);
                                                byte g2 = byte.Parse(fontbackground.Split(',')[1]);
                                                byte b2 = byte.Parse(fontbackground.Split(',')[2]);
                                                lbl.BackColor = Color.FromArgb(r2, g2, b2);

                                            }

                                            doc_panel.Controls.Add(lbl);
                                        }
                                        catch (Exception)
                                        {
                                            output.Visible = true;
                                            output_text.ForeColor = Color.Red;
                                            output_text.Text = "Critical Error: Please check,\n1. Please code the correct parameters\n2. Please make sure VHeap Fragmentation is working properly";
                                        }
                                    }
                                    else
                                    {
                                        output.Visible = true;
                                        output_text.Text = "Warning: There is no style declared as \"" + style_name.ToString() + "\".";
                                        bug++;
                                    }
                                }
                            }
                        }
                    }
                }

                UpdateInformation();
                UpdateElements();
                UpdateStyleElementation();
                UpdateOrientationInformation();
            }
            catch (Exception)
            {

            }

            return true;
        }

        public void UpdateOrientationInformation()
        {
            if (doc_panel.Width == doc_panel.Height)
            {
                potraitToolStripMenuItem.Checked = false;
                landscapeToolStripMenuItem.Checked = false;
            }
            else if (doc_panel.Width > doc_panel.Height)
            {
                landscapeToolStripMenuItem.Checked = true;
                potraitToolStripMenuItem.Checked = false;
            }
            else
            {
                potraitToolStripMenuItem.Checked = true;
                landscapeToolStripMenuItem.Checked = false;
            }
        }

        public void UpdateStyleElementation()
        {
            styles_list.Controls.Clear();

            foreach (var style_files in System.IO.Directory.GetFiles(Application.ExecutablePath.Replace("Ninponix Office.exe","") + "\\" + @"Runtime\NVL\VHeap\"))
            {
                //Get Style contents and apply it to the label
                Label lbl = new Label();

                try
                {
                    string stylecontent;
                    using (System.IO.StreamReader sr = new System.IO.StreamReader(style_files))
                    {
                        stylecontent = sr.ReadToEnd();
                        sr.Close();
                    }

                    string[] parameters = stylecontent.Split(';');

                    string FontName = "Arial";
                    string FontSize = "12";
                    string FontStyle = "Regular";
                    string FontColor = "0,0,0";
                    string BackgroundColor = "255,255,255";

                    foreach (var para in parameters)
                    {
                        string property = para.Split('=')[0].ToString();
                        string value = para.Split('=')[1].ToString();

                        switch (property.ToLower())
                        {
                            case "font":
                                FontName = value;
                                break;
                            case "size":
                                FontSize = value;
                                break;
                            case "color":
                                FontColor = value;
                                break;
                            case "style":
                                FontStyle = value;
                                break;
                            case "background":
                                BackgroundColor = value;
                                break;
                        }
                    }

                    Font f = new Font(FontName, int.Parse(FontSize));

                    switch (FontStyle)
                    {
                        case "Regular":
                            f = new Font(FontName, int.Parse(FontSize), System.Drawing.FontStyle.Regular);
                            break;
                        case "Bold":
                            f = new Font(FontName, int.Parse(FontSize), System.Drawing.FontStyle.Bold);
                            break;
                        case "Italic":
                            f = new Font(FontName, int.Parse(FontSize), System.Drawing.FontStyle.Italic);
                            break;
                        case "Strikeout":
                            f = new Font(FontName, int.Parse(FontSize), System.Drawing.FontStyle.Strikeout);
                            break;
                        case "Underline":
                            f = new Font(FontName, int.Parse(FontSize), System.Drawing.FontStyle.Underline);
                            break;
                        case "BoldItalic":
                            f = new Font(FontName, int.Parse(FontSize), System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
                            break;
                        case "BoldStrikeout":
                            f = new Font(FontName, int.Parse(FontSize), System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout);
                            break;
                        case "BoldUnderline":
                            f = new Font(FontName, int.Parse(FontSize), System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline);
                            break;
                        case "ItalicUnderline":
                            f = new Font(FontName, int.Parse(FontSize), System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline);
                            break;
                        case "BoldItalicUnderline":
                            f = new Font(FontName, int.Parse(FontSize), System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline);
                            break;
                    }

                    lbl.Font = f;

                    //Get Color information
                    byte r1 = byte.Parse(FontColor.Split(',')[0]);
                    byte g1 = byte.Parse(FontColor.Split(',')[1]);
                    byte b1 = byte.Parse(FontColor.Split(',')[2]);

                    byte r2 = byte.Parse(BackgroundColor.Split(',')[0]);
                    byte g2 = byte.Parse(BackgroundColor.Split(',')[1]);
                    byte b2 = byte.Parse(BackgroundColor.Split(',')[2]);

                    lbl.ForeColor = Color.FromArgb(r1, g1, b1);
                    lbl.BackColor = Color.FromArgb(r2, g2, b2);

                    lbl.AutoSize = false;
                    lbl.Size = new Size(styles_list.Width - 5, int.Parse(FontSize) + 20) ;
                    lbl.TextAlign = ContentAlignment.MiddleLeft;

                    styles_list.Controls.Add(lbl);
                }
                catch (Exception)
                {
                    output.Visible = true;
                    output_text.Text = "Warning: One or more Style(s) has invalid parameters or cannot be read";
                }

                string name = style_files.Split('\\')[style_files.Split('\\').Length - 1];
                lbl.Text = name.Replace(".nvlsty","");                
            }
        }

        public void UpdateElements()
        {
            elements_panel.Items.Clear(); //Clear the items before adding them into the list of items.

            foreach (var control in doc_panel.Controls)
            { //Get all of the controls which are created in the document

                if (control.GetType().ToString() == "System.Windows.Forms.Label")
                {
                    dynamic x = control.GetType().GetProperty("AutoSize").GetValue(control);
                    dynamic textvalue = control.GetType().GetProperty("Text").GetValue(control);
                    dynamic controlsize = control.GetType().GetProperty("Location").GetValue(control);

                    if (x == false)
                        elements_panel.Items.Add("TextArea: " + textvalue + " " + controlsize);
                    else
                        elements_panel.Items.Add("Text: " + textvalue + " " + controlsize);
                }
                else if (control.GetType().ToString() == "System.Windows.Forms.PictureBox")
                {
                    dynamic x = control.GetType().GetProperty("ImageLocation").GetValue(control);
                    dynamic controlsize = control.GetType().GetProperty("Location").GetValue(control);

                    elements_panel.Items.Add("Image: " + x + " " + controlsize);
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int start = Environment.TickCount;
            doc_panel.Controls.Clear();
            output_text.ForeColor = Color.White;
            output.Visible = false;
            output_text.Text = "";
            bug = 0;
            CheckGrammar();
            Run();
            int stop = Environment.TickCount;
            int difference = stop - start;
            doc_panel.Location = new Point((splitContainer1.Panel2.Width / 2) - (doc_panel.Width / 2), (splitContainer1.Panel2.Height / 2) - (doc_panel.Height / 2));
            status.Text = "Completed Rendering in " + difference.ToString() + " ms";
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            //Set Change Color
            if (show_menu == true)
            {
                if (checkBox1.Checked != true)
                {
                    show_menu = false;
                    timer2.Start();
                }
            }

            if (checkBox2.Checked == true)
            {
                doc_panel.Controls.Clear();
                output_text.ForeColor = Color.White;
                output.Visible = false;
                output_text.Text = "";
                bug = 0;
                int start = richTextBox1.SelectionStart;
                nlpp_timer.Start();
                doc_panel.Location = new Point((splitContainer1.Panel2.Width / 2) - (doc_panel.Width / 2), (splitContainer1.Panel2.Height / 2) - (doc_panel.Height / 2));
            }

            int letters = richTextBox1.Text.Count();

            int count = 0;

            foreach (var l in richTextBox1.Lines)
            {
                //Theory 433: Finding the no. of words of an string
                if (l.Replace(" ", "").Count() != 0)
                {
                    if (l.EndsWith(" "))
                    {
                        count += (l.Split(' ').Count() - 1);
                    }
                    else if (l.EndsWith("\r"))
                    {
                        count += (l.Split(' ').Count() - 1);
                    }
                    else
                    {
                        count += l.Split(' ').Count();
                    }
                }
            }

            //Set the count of words into the label.


            int lines = richTextBox1.Lines.Count();

            text_information.Text = letters.ToString() + " Letters, " + count.ToString() + " Words, " + lines.ToString() + " Lines";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            output.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2Collapsed = !(splitContainer1.Panel2Collapsed);
            if (button7.Text == "<")
            {
                button7.Text = ">";
                richTextBox1.Focus();
            }
            else
            {
                button7.Text = "<";
                richTextBox1.Focus();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel1Collapsed = !(splitContainer1.Panel1Collapsed);
            if (button8.Text == "<")
            {
                button8.Text = ">";
            }
            else
            {
                richTextBox1.Focus();
                button8.Text = "<";
            }
        }

        private void button8_MouseEnter(object sender, EventArgs e)
        {
            status.Text = "Collapse the code window to see the preview.";
        }

        private void button7_MouseEnter(object sender, EventArgs e)
        {
            status.Text = "Collapse the preview to see the code.";
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            status.Text = "Ready";
        }

        private void button8_MouseLeave(object sender, EventArgs e)
        {
            status.Text = "Ready";
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            status.Text = "Run the code to render using NLPP";
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            status.Text = "Ready";
        }

        private void nlpp_timer_Tick(object sender, EventArgs e)
        {
            //Read and render the NVL Code.
            doc_panel.Controls.Clear();
            Run();
            output_text.ForeColor = Color.White;
            output.Visible = false;
            output_text.Text = "";
            bug = 0;
            doc_panel.Location = new Point((splitContainer1.Panel2.Width / 2) - (doc_panel.Width / 2), (splitContainer1.Panel2.Height / 2) - (doc_panel.Height / 2));
            nlpp_timer.Stop();

        }

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    if (e.Control == true)
                    {   //CTRL + W = OPEN WITH
                        VisualDocumentToolBox.ExternalOpen open = new VisualDocumentToolBox.ExternalOpen(file.ToString());
                        open.ShowDialog();
                    }

                    break;
                case Keys.E:
                    if (e.Control == true)
                    {   //CTRL + E = EXPORT OPTIONS
                        button13_Click("Sender1", new EventArgs());
                        status.Text = "Export (CTRL + E)";
                    }

                    break;
                case Keys.M:
                    if (e.Alt == true)
                    {
                        if (e.Control == true)
                        {   //CTRL + ALT + M = TOGGLE MENU VIEW
                            button6_Click("Sender1", new EventArgs());
                            status.Text = "Toggle Menu (CTRL + ALT + M)";
                        }
                        else
                        {   //ALT + M = TOGGLE DOCUMENT INFORMATION LIST
                            show_menu = !show_menu;
                            timer2.Start();
                            status.Text = "Toggle Document Information (ALT + M)";
                        }
                    }

                    break;
                case Keys.Q:
                    if (e.Control == true)
                    {   //CTRL + Q = CLOSE WINDOW
                        button15_Click("Sender1", new EventArgs());
                        status.Text = "Close Window (CTRL + Q)";
                    }

                    break;
                case Keys.A:
                    if (e.Control == true)
                    {
                        if (e.Alt == true)
                        {   //CTRL + ALT + A = SAVE FILE AS
                            button12_Click("Sender1", new EventArgs());
                            status.Text = "Save File As (CTRL + ALT + A)";
                        }
                    }

                    break;
                case Keys.O:
                    if (e.Control == true)
                    {   //CTRL + O = OPEN FILE
                        button10_Click("Sender1", new EventArgs());
                        status.Text = "Open File (CTRL + O)";
                    }

                    break;
                case Keys.N:
                    if (e.Control == true)
                    {
                        if (e.Alt == true)
                        {   //CTRL + ALT + N = NEW STYLE
                            toolStripButton3_Click("Sender1", new EventArgs());
                            status.Text = "New Style (CTRL + ALT + N)";
                        }
                        else
                        {   //CTRL + N = NEW FILE
                            button9_Click("Sender1", new EventArgs());
                            status.Text = "New File Shortcut (CTRL + N)";
                        }
                    }

                    break;
                case Keys.I:
                    if (e.Control == true)
                    {   //CTRL + I = ADD IMAGE WINDOW
                        toolStripButton2_Click("Sender1", new EventArgs());
                        status.Text = "Add Image (CTRL + I)";
                    }
                    break;
                case Keys.T:
                    if (e.Control == true)
                    {   //CTRL + T = ADD TEXT WINDOW
                        toolStripButton1_Click("Sender1", new EventArgs());
                        status.Text = "Add Text (CTRL + T)";
                    }

                    break;
                case Keys.D:
                    if (e.Control == true)
                    {   //CTRL + D = DOCUMENT AND NAME TAG EDITING VIEW
                        toolStripButton4_Click("Sender1", new EventArgs());
                        status.Text = "Document Information (CTRL + D)";
                    }

                    break;

                case Keys.F6:
                        //F6 = PREVIEW
                    button13_Click_1("Sender", new EventArgs());
                    status.Text = "Preview Project (F6)";
                    break;

                case Keys.F5:
                    if (e.Control == true)
                    {   //CTRL + F5 = TOGGLE NLPP AUTO RENDERING
                        checkBox2.Checked = !(checkBox2.Checked);
                        if (checkBox2.Checked)
                            status.Text = "NVL Auto Rendering enabled (CTRL + F5)";
                        else
                            status.Text = "NVL Auto Rendering disabled (CTRL + F5)";
                    }
                    else
                    {  
                        if (e.Alt == true)
                        {   //ALT + F5 = TOGGLE PREVIEW MODE
                            splitContainer1.Panel1Collapsed = !(splitContainer1.Panel1Collapsed);
                            status.Text = "Toggle Preview Mode (ALT + F5)";
                        }
                        else
                        {   //F5 = RENDER
                            int start = Environment.TickCount;
                            doc_panel.Controls.Clear();
                            Run();
                            CheckGrammar();
                            output_text.ForeColor = Color.White;
                            output.Visible = false;
                            output_text.Text = "";
                            bug = 0;
                            doc_panel.Location = new Point((splitContainer1.Panel2.Width / 2) - (doc_panel.Width / 2), (splitContainer1.Panel2.Height / 2) - (doc_panel.Height / 2));
                            int end = Environment.TickCount;
                            int difference = end - start;
                            status.Text = "Completed Rendering in " + difference.ToString() + " ms";
                        }
                    }
                    break;
                case Keys.Enter:
                    CheckGrammar();
                    UndoCollection.Add(richTextBox1.Text);
                    break;

                case Keys.S:

                    if (e.Control == true)
                    { 
                        if (e.Alt == false)
                        {   //CTRL + S = SAVE FILE
                            int start = Environment.TickCount;
                            status.Text = "Saving " + file.ToString() + "...";

                            try
                            {
                                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(file))
                                {
                                    sw.Write(richTextBox1.Text);
                                    sw.Flush();
                                    sw.Close();
                                }
                                int ened = Environment.TickCount;
                                int difference = ened - start;
                                status.Text = "Saved in " + difference.ToString() + " ms";

                            }
                            catch (Exception)
                            {
                                Message msg = new Message("Ninponix Office 2017", "Unable to save the document. Please try again later", MessageIcon.MessageIconType.Warning, MessageIcon.MessageMode.NVL);
                                msg.ShowDialog();
                                status.Text = "Failed Saving the document";
                            }
                        }
                        else
                        {   //CTRL + ALT + S = STYLE MANAGEMENT
                            toolStripButton5_Click("Sender1", new EventArgs());
                            status.Text = "Style Management (CTRL + ALT + S)";
                        }
                    }
                    else
                    {
                        if (e.Alt == true)
                        {   //ALT + S = SETTINGS AND OPTIONS
                            button14_Click("Sender1", new EventArgs());
                            status.Text = "Settings Shortcut (ALT + S)";
                        }
                    }
                    
                    break;
                case Keys.Space:
                    UndoCollection.Add(richTextBox1.Text);
                    break;
                case Keys.Z:

                    if (e.Control == true)
                    {   //CTRL + Z = UNDO 
                        try
                        {
                            int start = richTextBox1.SelectionStart;
                            UndoCollection.RemoveAt(UndoCollection.Count() - 1);
                            int difference = UndoCollection[UndoCollection.Count() - 1].Count() - richTextBox1.Text.Count();
                            richTextBox1.Text = UndoCollection[UndoCollection.Count() - 1];
                            status.Text = "Undo the Code";
                            richTextBox1.Select(start - difference, 0);
                            CheckGrammar();
                        }
                        catch (Exception) { }
                    }

                    break;
                case Keys.C:
                    if (e.Alt == true)
                    {   //ALT + C = TOGGLE CODE MODE
                        splitContainer1.Panel2Collapsed = !splitContainer1.Panel2Collapsed;
                        status.Text = "Toggle Code Mode (ALT + C)";
                    }

                    break;
            }

        }



        private void VisualDocumentEditor_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.VisualDocumentAutoRender = checkBox2.Checked;
        }

        public bool menu_open_state = false;
        int speed = 10;

        private void menu_animation_Tick(object sender, EventArgs e)
        {
            if (menu_open_state == true)
            {
                if (menu_panle.Height < 260)
                {
                    menu_panle.Height += speed;
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
                if (menu_panle.Height != 0)
                {
                    menu_panle.Height -= speed;
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

        private void button6_Click(object sender, EventArgs e)
        {
            menu_open_state = !(menu_open_state);

            //Check for OLD Text
            string old_text = "";
            try
            {
                using (System.IO.StreamReader sr = new System.IO.StreamReader(file))
                {
                    old_text = sr.ReadToEnd();
                    sr.Close();
                }

                if (old_text == richTextBox1.Text)
                    button11.Enabled = false;
                else
                    button11.Enabled = true;
            }
            catch (Exception) { button11.Enabled = true; }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            menu_open_state = false;
            button1_Click("", new EventArgs()); // call the closing procedure
        }

        public void SaveAs()
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Save Document As...";
            save.FileName = file;
            save.Filter = "NVL Visual Document|*.nvldoc";

            if (save.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (System.IO.StreamWriter sw = new System.IO.StreamWriter(save.FileName))
                    {
                        sw.Write(richTextBox1.Text);
                        sw.Flush(); sw.Close();
                    }

                    file = save.FileName;
                    status.Text = "Document Successfully Saved";
                }
                catch (Exception)
                {
                    Message msg = new Message("Ninponix Office 2017", "Could n't save the document to the selected Path. Please make sure the given path is valid", MessageIcon.MessageIconType.Error, MessageIcon.MessageMode.NVL);
                    msg.ShowDialog();
                }
            }
        }

        public void SaveFile()
        {
            string filename = file;
            try
            {
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(filename))
                {
                    sw.Write(richTextBox1.Text);
                    sw.Flush(); sw.Close();
                }
                status.Text = "Document Successfully Saved";
            }
            catch (Exception)
            {
                Message msg = new Message("Ninponix Office 2017", "Could n't save the document. Please make sure that the file is not in use.", MessageIcon.MessageIconType.Warning, MessageIcon.MessageMode.NVL);
                msg.ShowDialog();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            menu_open_state = false;
            SaveFile(); //Calls the saving code
        }

        public void NewDocument()
        {
            SaveFileDialog save = new SaveFileDialog();
            save.FileName = file;
            save.Filter = "NVL Visual Document|*.nvldoc";
            save.Title = "Save the new Document";

            if (save.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (System.IO.StreamWriter sw = new System.IO.StreamWriter(save.FileName))
                    {
                        sw.Write("");
                        sw.Close();
                    }
                    richTextBox1.Text = "";
                    file = save.FileName;
                }
                catch (Exception)
                {
                    Message msg = new Message("Ninponix Office 2017", "Could n't open the new document. Please retry again", MessageIcon.MessageIconType.Error, MessageIcon.MessageMode.NVL);
                    msg.ShowDialog();
                }
            }
            else
            {
                status.Text = "Cancelled creating new document";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            menu_open_state = false;
            if (MessageBox.Show("Do you want to save the current document before creating another?", "Ninponix Office 2017", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SaveFile();
                NewDocument(); //Calls New Document method;
            }
            else
            {
                NewDocument();
            }

        }

        private void button12_Click(object sender, EventArgs e)
        {
            menu_open_state = false;
            SaveAs(); //Calls the Save As Code
        }

        public void Open()
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Open the NVL Document";
            open.Filter = "NVL Visual Document|*.nvldoc";
            open.FileName = file;

            if (open.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (System.IO.StreamReader sr = new System.IO.StreamReader(open.FileName))
                    {
                        richTextBox1.Text = sr.ReadToEnd();
                        sr.Close();
                    }

                    file = open.FileName;

                    status.Text = "Document Opened Successfully";
                }
                catch (Exception)
                {
                    Message msg = new Message("Ninponix Office 2017", "Could n't Open the document. Please make sure the file is not in use.", MessageIcon.MessageIconType.Error, MessageIcon.MessageMode.NVL);
                    msg.ShowDialog();
                }
            }
            else
            {
                status.Text = "Cancelled Saving the File";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            menu_open_state = false;
            if (MessageBox.Show("Do you want to save the current document before opening another?", "Ninponix Office 2017", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SaveFile(); // Calls save method
                Open(); //Call Opening Method
            }
            else
            {
                Open(); // Call opening method
            }
        }

        private void VisualDocumentEditor_TextChanged(object sender, EventArgs e)
        {
            title_doc.Text = Text;
            menu_open_state = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try {
                menu_open_state = false;
                System.IO.FileInfo f = new System.IO.FileInfo(file);
                VisualDocumentToolBox.ExportWizard ex = new VisualDocumentToolBox.ExportWizard(richTextBox1.Text, f.DirectoryName);
                ex.ShowDialog();
            }catch (Exception)
            {

            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            menu_open_state = false;
            throw new NotImplementedException("LOAD HTML");
        }

        private void doc_panel_MouseMove(object sender, MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;

            doc_panel_mouse_location.Text = "X: " + x.ToString() + " Y: " + y.ToString();
        }

        private void doc_panel_MouseLeave(object sender, EventArgs e)
        {
            doc_panel_mouse_location.Text = "";
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            VisualDocumentToolBox.DocumentInfo docinfo = new VisualDocumentToolBox.DocumentInfo(richTextBox1.Text);
            docinfo.ShowDialog();
            richTextBox1.Text = docinfo.returnString;
            doc_panel.Controls.Clear();
            doc_panel.Location = new Point((splitContainer1.Panel2.Width / 2) - (doc_panel.Width / 2), (splitContainer1.Panel2.Height / 2) - (doc_panel.Height / 2));
            output.Visible = false;
            output_text.ForeColor = Color.White;
            Run();
            CheckGrammar();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            VisualDocumentToolBox.AddText add = new VisualDocumentToolBox.AddText(richTextBox1.Text);
            add.ShowDialog();
            richTextBox1.Text = add.ReturnText;
            doc_panel.Controls.Clear();
            doc_panel.Location = new Point((splitContainer1.Panel2.Width / 2) - (doc_panel.Width / 2), (splitContainer1.Panel2.Height / 2) - (doc_panel.Height / 2));
            output.Visible = false;
            output_text.ForeColor = Color.White;
            Run();
            CheckGrammar();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            System.IO.FileInfo f = new System.IO.FileInfo(file);
            
            VisualDocumentToolBox.AddImage image = new VisualDocumentToolBox.AddImage(richTextBox1.Text,f.Directory.ToString());
            image.ShowDialog();

            richTextBox1.Text = image.ReturnText;
            doc_panel.Controls.Clear();
            doc_panel.Location = new Point((splitContainer1.Panel2.Width / 2) - (doc_panel.Width / 2), (splitContainer1.Panel2.Height / 2) - (doc_panel.Height / 2));
            output.Visible = false;
            output_text.ForeColor = Color.White;
            Run();
            CheckGrammar();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            VisualDocumentToolBox.StyleManager man = new VisualDocumentToolBox.StyleManager(richTextBox1.Text);
            man.ShowDialog();
            richTextBox1.Text = man.TextRich;

            doc_panel.Controls.Clear();
            doc_panel.Location = new Point((splitContainer1.Panel2.Width / 2) - (doc_panel.Width / 2), (splitContainer1.Panel2.Height / 2) - (doc_panel.Height / 2));
            output.Visible = false;
            output_text.ForeColor = Color.White;
            Run();
            CheckGrammar();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            VisualDocumentToolBox.AddStyle sty = new VisualDocumentToolBox.AddStyle(richTextBox1.Text);
            sty.ShowDialog();
            richTextBox1.Text = sty.TextRich;

            doc_panel.Controls.Clear();
            doc_panel.Location = new Point((splitContainer1.Panel2.Width / 2) - (doc_panel.Width / 2), (splitContainer1.Panel2.Height / 2) - (doc_panel.Height / 2));
            output.Visible = false;
            output_text.ForeColor = Color.White;
            Run();
            CheckGrammar();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            toolStripButton5_Click("Sender1", new EventArgs());
        }

        private void button17_Click(object sender, EventArgs e)
        {
            toolStripButton3_Click("Sender2", new EventArgs());
        }

        bool force = false;

        private void VisualDocumentEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (force == false)
            {
                e.Cancel = true;
                open = false;
            }    
        }

        private void richTextBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (show_menu == true)
            {
                if (checkBox1.Checked != true)
                {
                    show_menu = false;
                    timer2.Start();
                }
            }
        }
        

        private void doc_panel_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            VisualDocumentToolBox.DocumentInfo docinfo = new VisualDocumentToolBox.DocumentInfo(richTextBox1.Text);
            docinfo.ShowDialog();
            richTextBox1.Text = docinfo.returnString;
            doc_panel.Controls.Clear();
            doc_panel.Location = new Point((splitContainer1.Panel2.Width / 2) - (doc_panel.Width / 2), (splitContainer1.Panel2.Height / 2) - (doc_panel.Height / 2));
            output.Visible = false;
            output_text.ForeColor = Color.White;
            Run();
            CheckGrammar();
        }

        public void ChangeSizeMethod (string args)
        {
            int linecount = 0;
            int lining = 0;

            foreach (var lines in richTextBox1.Text.Split('\n'))
            {
                linecount++;
                if (lines.StartsWith("[DOCUMENT:"))
                {//lines code found
                    lining = linecount; 
                }
            }

            if (lining == 0)
            {
                richTextBox1.Text = "[DOCUMENT:" + args.ToString() + ";White]" + "\n" + richTextBox1.Text;
            }
            else
            {
                string[] lines = richTextBox1.Text.Split('\n');
                string doccode = lines[lining - 1].ToString();
                string colcod = doccode.Split(';')[1];
                string newdoccode = "[DOCUMENT:" + args.ToString() + ";" + colcod.ToString();
                lines[lining - 1] = "\n" + newdoccode + "\n";
                string NEWCODE = "";
                foreach (var items in lines)
                {
                    NEWCODE += items.ToString() + "\n";
                }

                richTextBox1.Text = NEWCODE;
            }

            doc_panel.Controls.Clear();
            doc_panel.Location = new Point((splitContainer1.Panel2.Width / 2) - (doc_panel.Width / 2), (splitContainer1.Panel2.Height / 2) - (doc_panel.Height / 2));
            output.Visible = false;
            output_text.ForeColor = Color.White;
            Run();
            CheckGrammar();
        }

        private void a5PhysicalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeSizeMethod("A5");
        }

        private void a4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeSizeMethod("A4");
        }

        private void a3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeSizeMethod("A3");
        }

        private void letterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeSizeMethod("Letter");
        }

        private void tabloidPhysicalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeSizeMethod("Tabloid");
        }

        private void legalPhysicalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeSizeMethod("Legal");
        }

        private void potraitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (doc_panel.Width > doc_panel.Height)
            {
                int curw = doc_panel.Width;
                int curh = doc_panel.Height;
                doc_panel.Height = curw;
                doc_panel.Width = curh;

                doc_panel.Controls.Clear();
                doc_panel.Location = new Point((splitContainer1.Panel2.Width / 2) - (doc_panel.Width / 2), (splitContainer1.Panel2.Height / 2) - (doc_panel.Height / 2));
                output.Visible = false;
                output_text.ForeColor = Color.White;
                Run();
                CheckGrammar();
            }
        }

        private void landscapeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (doc_panel.Height > doc_panel.Width)
            {
                int curw = doc_panel.Width;
                int curh = doc_panel.Height;
                doc_panel.Height = curw;
                doc_panel.Width = curh;

                doc_panel.Controls.Clear();
                doc_panel.Location = new Point((splitContainer1.Panel2.Width / 2) - (doc_panel.Width / 2), (splitContainer1.Panel2.Height / 2) - (doc_panel.Height / 2));
                output.Visible = false;
                output_text.ForeColor = Color.White;
                Run();
                CheckGrammar();
            }
        }

        public void ChangeDocColor (string args)
        {
            int lining = 0;
            int linecounter = 0;

            foreach (var lines in richTextBox1.Text.Split('\n'))
            {
                linecounter++;
                if (lines.StartsWith("[DOCUMENT:"))
                {
                    lining = linecounter;
                }
            }

            if (lining == 0)
            {
                richTextBox1.Text = "[DOCUMENT:(512,512);" + args.ToString() + "]\n" + richTextBox1.Text;
            }else
            {
                string[] lines = richTextBox1.Text.Split('\n');
                string codeline = lines[lining - 1];
                string sizing_tag = codeline.Split(';')[0];
                string newline = sizing_tag + ";" + args.ToString() + "]";

                lines[lining - 1] = newline;

                string NEWCODE = "";

                foreach (var item in lines)
                {
                    NEWCODE += item.ToString() + "\n";
                }

                richTextBox1.Text = NEWCODE;
            }

            doc_panel.Controls.Clear();
            doc_panel.Location = new Point((splitContainer1.Panel2.Width / 2) - (doc_panel.Width / 2), (splitContainer1.Panel2.Height / 2) - (doc_panel.Height / 2));
            output.Visible = false;
            output_text.ForeColor = Color.White;
            Run();
            CheckGrammar();
        }

        private void whiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeDocColor("White");
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeDocColor("Black");
        }

        private void orangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeDocColor("Red");
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeDocColor("Green");
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeDocColor("Blue");
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            //PREVIEW BTN CODING            
            if (Properties.Settings.Default.vdinstance == 0)
            {
                SaveFile();
                VisualDocumentToolBox.VDReader vd = new VisualDocumentToolBox.VDReader(file.ToString(),true);
                vd.Show();
            }
            else
            {
                Message msg = new Message("Ninponix Office 2017", "Ninponix Office already has a previewing instance of this project. Please terminate it to start a new preview instance of your project.", MessageIcon.MessageIconType.Warning, MessageIcon.MessageMode.NVL);
                msg.ShowDialog();
            }
        }

        int counter2 = 0;
        
        private void minimize_animator_Tick(object sender, EventArgs e)
        {
            counter2++;
            
            switch (counter2)
            {
                case 1:
                    Location = new Point(Location.X, 0);
                    Opacity = 1;
                    break;
                case 2:
                    Location = new Point(Location.X, 10);
                    Opacity = 0.5;
                    break;
                case 3:
                    Location = new Point(Location.X, 25);
                    Opacity = 0.25;
                    break;
                case 4:
                    Location = new Point(Location.X, 40);
                    Opacity = 0.1;
                    break;
                case 5:
                    Location = new Point(Location.X, 50);
                    Opacity = 0;
                    break;
                case 6:
                    Location = new Point(0, 0);
                    WindowState = FormWindowState.Minimized;
                    break;
                case 7:
                    Opacity = 1;
                    minimize_animator.Stop();
                    counter2 = 0;
                    break;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //START THE MINIMIZING CODE FUNCTIONTHE CODE FUNCTION
            minimize_animator.Start();
        }

        private void recovery_timer_Tick(object sender, EventArgs e)
        {
            //Set the recovery information and save the backup files to recover by the program
            try
            {
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(Application.ExecutablePath.Replace("Ninponix Office.exe", "") + @"Recovery\VisualDocument.nvldoc"))
                {
                    sw.Write(richTextBox1.Text);
                    sw.Flush();
                    sw.Close();
                }
            }
            catch (Exception)
            {
                Message msg = new Message("Ninponix Office 2017", "Sorry, Could not save the recovery Visual Document.", MessageIcon.MessageIconType.Error, MessageIcon.MessageMode.NVL);msg.ShowDialog();
            }
        }
    }
}