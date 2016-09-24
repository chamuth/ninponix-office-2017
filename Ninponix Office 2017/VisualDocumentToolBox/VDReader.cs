using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ninponix_Office.VisualDocumentToolBox
{
    public partial class VDReader : Form
    {
        public string _Path = "";
        public RichTextBox richTextBox1 = new RichTextBox();

        public VDReader(string filename, bool test)
        {
            InitializeComponent();
            _Path = filename;

            using (System.IO.StreamReader sr = new System.IO.StreamReader(_Path))
            {
                richTextBox1.Text = sr.ReadToEnd();
                sr.Close();
            }

            if (test)
            {
                edit_btn.Visible = false;
            }
            else
            {
                edit_btn.Visible = true;
            }
        }

        public void UpdateTitles()
        {
            string init = " - Ninponix Office 2017 (NLPP)";
            System.IO.FileInfo fi = new System.IO.FileInfo(_Path);
            string title = fi.FullName.ToString() + init.ToString();
            Text = title;
            title_doc.Text = Text;
        }

        private void VDReader_Load(object sender, EventArgs e)
        {
            MaximumSize = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
            WindowState = FormWindowState.Maximized;

            //CHECK PATH NAME AVAILABILITY USING THE STREAMS
            if (System.IO.File.Exists(_Path) != true)
            {
                Message msg = new Message("Ninponix Office 2017", "Cannot find the file to preview. Please make sure your file is working correctly.", MessageIcon.MessageIconType.Warning, MessageIcon.MessageMode.NVL);
                msg.ShowDialog();
                Close();
            }

            if (Run() == false)
            {
                MessageBox.Show("Ninponix Live Preview Protocol cannot render the Ninponix Visual Language file you have selected.", "NLPP Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
            }
            else
            {
                if (doc_panel.Height < document_background.Height)
                {
                    doc_panel.Location = new Point((document_background.Width / 2) - (doc_panel.Width / 2), (document_background.Height / 2) - (doc_panel.Height / 2));
                }
                else
                {
                    doc_panel.Location = new Point((document_background.Width / 2) - (doc_panel.Width / 2), 10);
                }
            }

            UpdateTitles();
        }

        //DOCUMENT SIZES
        Size a5 = new Size(419, 595);
        Size a4 = new Size(595, 841);
        Size a3 = new Size(841, 1190);
        Size letter = new Size(612, 792);
        Size legal = new Size(612, 1008);
        Size tabloid = new Size(792, 1224);

        public string Document_Title = "";
        public string DocSize = "";
        Color DocBackCol = Color.White;

        public bool Run()
        {
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
                    return false;
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
                                            return false;

                                        }
                                    }

                                    DocBackCol = Color.FromName(args[1]);
                                    doc_panel.BackColor = DocBackCol;
                                    doc_attributes_present = true;
                                }
                                else
                                {
                                    return false;

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
                                        return false;
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
                                    return false;
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
                                        System.IO.FileInfo fi = new System.IO.FileInfo(_Path);
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
                                    return false;
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
                                    return false;
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
                                    return false;
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
                                    if (System.IO.File.Exists(Application.StartupPath.Replace("Ninponix Office.exe", "") + "\\" + "Runtime\\NVL\\VHeap\\" + style_name + ".nvlsty"))
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
                                        return false;
                                    }
                                }
                                catch (Exception)
                                {
                                    return false;
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
                                        return false;
                                    }
                                }
                                else
                                {
                                    return false;
                                }
                            }
                        }
                    }
                }
            }
            
            return true;
        }


        bool open = true;
        bool force = false;

        private void sizing_timer_Tick(object sender, EventArgs e)
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
                    force = true;
                    Close();
                }
            }
        }

        private void VDReader_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (force == false)
            {
                e.Cancel = true;
            }
            else
            {
                open = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            open = false;
        }

        private void VDReader_KeyDown(object sender, KeyEventArgs e)
        {
            if (doc_panel.Height > document_background.Height)
            {   //DH
                switch (e.KeyCode)
                {
                    case Keys.Up:
                        if (doc_panel.Location.Y < 0)
                        {
                            int nowy = doc_panel.Location.Y;
                            doc_panel.Location = new Point(doc_panel.Location.X, nowy + 25);
                        }

                        break;
                    case Keys.Down:
                        if (doc_panel.Location.Y + doc_panel.Height > document_background.Height)
                        {
                            int nowy = doc_panel.Location.Y;
                            doc_panel.Location = new Point(doc_panel.Location.X, nowy - 25); 
                        }

                        break;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                VisualDocumentEditor vde = new VisualDocumentEditor(_Path,true);
                vde.ShowDialog();

                doc_panel.Controls.Clear();
                
                using (System.IO.StreamReader sr = new System.IO.StreamReader(_Path))
                {
                    richTextBox1.Text = sr.ReadToEnd();
                    sr.Close();
                }

                Run();
            }
            catch (Exception)
            {
                Message msg = new Message("Ninponix Office 2017", "Could not start the thread. Please try again", MessageIcon.MessageIconType.Error, MessageIcon.MessageMode.NVL);
                msg.ShowDialog();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        public bool max = true;
        int counter1 = 0;

        private void maximization_Tick(object sender, EventArgs e)
        {
            if (max)
            {
                counter1++;

                switch (counter1)
                {
                    case 1:
                        Size = new Size(Screen.PrimaryScreen.WorkingArea.Width - 10, Screen.PrimaryScreen.WorkingArea.Height - 10);
                        Location = new Point((Screen.PrimaryScreen.WorkingArea.Width / 2) - (Width / 2), (Screen.PrimaryScreen.WorkingArea.Height / 2) - (Height / 2));
                        break;
                    case 2:
                        Size = new Size(Screen.PrimaryScreen.WorkingArea.Width - 5, Screen.PrimaryScreen.WorkingArea.Height - 5);
                        Location = new Point((Screen.PrimaryScreen.WorkingArea.Width / 2) - (Width / 2), (Screen.PrimaryScreen.WorkingArea.Height / 2) - (Height / 2));
                        break;
                    case 3:
                        Size = new Size(Screen.PrimaryScreen.WorkingArea.Width - 2, Screen.PrimaryScreen.WorkingArea.Height - 2);
                        Location = new Point((Screen.PrimaryScreen.WorkingArea.Width / 2) - (Width / 2), (Screen.PrimaryScreen.WorkingArea.Height / 2) - (Height / 2));
                        break;
                    case 4:
                        Size = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
                        Location = new Point((Screen.PrimaryScreen.WorkingArea.Width / 2) - (Width / 2), (Screen.PrimaryScreen.WorkingArea.Height / 2) - (Height / 2));
                        counter1 = 0;
                        maximization.Stop();
                        WindowState = FormWindowState.Maximized;
                        break;
                }
            }
           
        }

        public int zoom_int = 1;
        public double zoom_power = 1.1;

        private void zoomin_Click(object sender, EventArgs e)
        {
            if (zoom_int < 10)
            {
                zoom_int++;
                
                doc_panel.Width = (int)(doc_panel.Width * zoom_power);
                doc_panel.Height = (int)(doc_panel.Height * zoom_power);

                int nowy = doc_panel.Location.Y;

                foreach (var controls in doc_panel.Controls)
                {
                    if (controls.GetType().ToString() == "System.Windows.Forms.Label")
                    {
                        Point location = (Point)controls.GetType().GetProperty("Location").GetValue(controls);
                        location = new Point((int)(location.X * zoom_power), (int)(location.Y * zoom_power));
                        Font font = (Font)controls.GetType().GetProperty("Font").GetValue(controls);
                        font = new Font(font.FontFamily.Name, float.Parse((font.Size * zoom_power).ToString()), font.Style);

                        if ((bool)(controls.GetType().GetProperty("AutoSize").GetValue(controls)) == false)
                        {
                            // It's a TextArea
                            Size size = (Size)controls.GetType().GetProperty("Size").GetValue(controls);
                            size = new Size((int)(size.Width * zoom_power), (int)(size.Height * zoom_power));
                            controls.GetType().GetProperty("Size").SetValue(controls, size);
                        }

                        controls.GetType().GetProperty("Font").SetValue(controls, font);
                        controls.GetType().GetProperty("Location").SetValue(controls, location);

                    }
                    else if (controls.GetType().ToString() == "System.Windows.Forms.Panel")
                    {
                        Point location = (Point)controls.GetType().GetProperty("Location").GetValue(controls);
                        location = new Point((int)(location.X * zoom_power), (int)(location.Y * zoom_power));

                        Size size = (Size)controls.GetType().GetProperty("Size").GetValue(controls);
                        size = new Size((int)(size.Width * zoom_power), (int)(size.Height * zoom_power));

                        controls.GetType().GetProperty("Size").SetValue(controls, size);
                        controls.GetType().GetProperty("Location").SetValue(controls, location);
                    }
                }
                if (doc_panel.Height < document_background.Height)
                {
                    doc_panel.Location = new Point((document_background.Width / 2) - (doc_panel.Width / 2), (document_background.Height / 2) - (doc_panel.Height / 2));
                }
                else
                {
                    if ((nowy * zoom_power) > 0)
                    {
                        doc_panel.Location = new Point((document_background.Width / 2) - (doc_panel.Width / 2), (int)(nowy * zoom_power));
                    }
                    else
                    {
                        doc_panel.Location = new Point((document_background.Width / 2) - (doc_panel.Width / 2), (int)(nowy * zoom_power));
                    }
                }
            }
        }

        private void zoomout_Click(object sender, EventArgs e)
        {
            if (zoom_int != 1)
            {
                zoom_int--;

                doc_panel.Width = (int)(doc_panel.Width / zoom_power);
                doc_panel.Height = (int)(doc_panel.Height / zoom_power);

                int nowy = doc_panel.Location.Y;

                foreach (var controls in doc_panel.Controls)
                {
                    if (controls.GetType().ToString() == "System.Windows.Forms.Label")
                    {
                        Point location = (Point)controls.GetType().GetProperty("Location").GetValue(controls);
                        location = new Point((int)(location.X / zoom_power) + 1, (int)(location.Y / zoom_power) + 1);
                        Font font = (Font)controls.GetType().GetProperty("Font").GetValue(controls);
                        font = new Font(font.FontFamily.Name, (float)(font.Size / zoom_power), font.Style);

                        if ((bool)(controls.GetType().GetProperty("AutoSize").GetValue(controls)) == false)
                        {
                            // It's a TextArea
                            Size size = (Size)controls.GetType().GetProperty("Size").GetValue(controls);
                            size = new Size((int)(size.Width / zoom_power), (int)(size.Height / zoom_power));
                            controls.GetType().GetProperty("Size").SetValue(controls, size);
                        }

                        controls.GetType().GetProperty("Font").SetValue(controls, font);
                        controls.GetType().GetProperty("Location").SetValue(controls, location);

                    }
                    else if (controls.GetType().ToString() == "System.Windows.Forms.Panel")
                    {
                        Point location = (Point)controls.GetType().GetProperty("Location").GetValue(controls);
                        location = new Point((int)(location.X / zoom_power), (int)(location.Y / zoom_power));

                        Size size = (Size)controls.GetType().GetProperty("Size").GetValue(controls);
                        size = new Size((int)(size.Width / zoom_power), (int)(size.Height / zoom_power));

                        controls.GetType().GetProperty("Size").SetValue(controls, size);
                        controls.GetType().GetProperty("Location").SetValue(controls, location);
                    }
                }

                if (document_background.Height > doc_panel.Height)
                {
                    doc_panel.Location = new Point((document_background.Width / 2) - (doc_panel.Width / 2), (document_background.Height / 2) - (doc_panel.Height / 2));
                }
                else
                {
                    if ((nowy * zoom_power) > 0)
                    {
                        doc_panel.Location = new Point((document_background.Width / 2) - (doc_panel.Width / 2), (int)(nowy / zoom_power));
                    }
                    else
                    {
                        doc_panel.Location = new Point((document_background.Width / 2) - (doc_panel.Width / 2), (int)(nowy / zoom_power));
                    }
                }
            }
        }

        private void document_background_Scroll(object sender, ScrollEventArgs e)
        {
            //Scroll Event for the background scaling
            if(e.ScrollOrientation == ScrollOrientation.VerticalScroll)
            {

            }
        }

        int counter3 = 0;

        private void minimize_Tick(object sender, EventArgs e)
        {
            counter3++;
            int exacty = Location.Y;

            switch (counter3)
            {
                case 1:
                    Location = new Point(Location.X, exacty + 5);
                    Opacity = 0.5;
                    break;
                case 2:
                    Location = new Point(Location.X, exacty + 10);
                    Opacity = 0.25;
                    break;
                case 3:
                    Location = new Point(Location.X, exacty + 12);
                    Opacity = 0.15;
                    break;
                case 4:
                    Location = new Point(Location.X, exacty + 15);
                    Opacity = 0.1;
                    break;
                case 5:
                    Location = new Point(Location.X, exacty + 16);
                    Opacity = 0;
                    break;
                case 6:
                    WindowState = FormWindowState.Minimized;
                    Location = new Point(Location.X, exacty);
                    Opacity = 1;
                    minimize.Stop();
                    counter3 = 0;
                    break;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            minimize.Start();
        }
    }
}