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
    public partial class choose_style : Form
    {
        string publicURL = "";
        string usage_Text = "";
        int selslide = 0;

        public string NEWCODE = "";

        public choose_style(string url,string text, int selectedslide)
        {
            InitializeComponent();
            publicURL = url;
            usage_Text = text;
            selslide = selectedslide;
        }

        bool Open = true;
        bool Force = false;
        bool save = false;

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

                    if (save == true)
                    {
                        GenerateNewScript();
                    }
                }
            }
        }

        public void GenerateNewScript()
        {
            TextBox txt = new TextBox();
            txt.Text = System.IO.File.ReadAllText(publicURL);

            //Conditionals
            bool correctslidefound = false;
            int slidecounter = 0;
            int linecounter = 0;

            string NowText = "";

            foreach (var lines in txt.Lines)
            {
                linecounter++;

                //Check for [SLIDE: Code

                if (lines.ToUpperInvariant().StartsWith("[SLIDE]"))
                {
                    slidecounter++;

                    if (slidecounter == selslide)
                    {
                        correctslidefound = true;
                    }
                }

                if (correctslidefound == false)
                {
                    NowText += lines.ToString() + "\n";
                    correctslidefound = false;
                }
                else
                {
                    string CodeText = "";

                    if (auto_size.Checked == true)
                    {
                        CodeText = "{TEXT:" + usage_Text.ToString() + ";" + styleBox.Items[styleBox.SelectedIndex].ToString() + ";(" + x.Value.ToString() + "," + y.Value.ToString() + ");AUTO}";
                    }
                    else
                    {
                        CodeText = "{TEXT:" + usage_Text.ToString() + ";" + styleBox.Items[styleBox.SelectedIndex].ToString() + ";(" + x.Value.ToString() + "," + y.Value.ToString() + ");(" + width.Value.ToString() + "," + height.Value.ToString() + ")}";
                    }

                    NowText += lines.ToString() + "\n" + CodeText.ToString() + "\n" ;

                    correctslidefound = false;
                }
            }

            NEWCODE = NowText;
        }

        private void Choose_Style_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Force == false)
            {
                Open = false;
                e.Cancel = true;
            }
        }

        private void choose_style_Load(object sender, EventArgs e)
        {
            foreach (var file in System.IO.Directory.GetFiles(Application.ExecutablePath.Replace("Ninponix Office.exe", "") + @"Runtime\NVL\V2Heap"))
            {
                System.IO.FileInfo fi = new System.IO.FileInfo(file);
                string stylename = fi.Name.Replace(".nvlsty", "");
                styleBox.Items.Add(stylename.ToString());
            }
        }

        private void styleBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                button3.Enabled = true;
                //Header; Segoe UI Light; 15; (0,0,0); (255,255,255); REGULAR
                preview_text.Text = "Preview (" + styleBox.Items[styleBox.SelectedIndex].ToString() + "): ";

                //EXECUTE THE CODE RIGHT NOW

                lbl.Text = usage_Text;

                string current_style = styleBox.Items[styleBox.SelectedIndex].ToString();
                string style_content = System.IO.File.ReadAllText(Application.ExecutablePath.Replace("Ninponix Office.exe", "") + @"Runtime\NVL\V2Heap\" + current_style + ".nvlsty");

                if (style_content.EndsWith("\n"))
                {
                    style_content = style_content.Replace("\n", "");
                }

                string[] style_argumentation = style_content.Split(';');

                string font_name = style_argumentation[1].ToString();
                string font_size = style_argumentation[2].ToString();
                font_size = ((previewWindow.Height / 50) * int.Parse(font_size.ToString())).ToString();
                string font_style = style_argumentation[5].ToString();

                string[] colarg1 = style_argumentation[3].Replace("(", "").Replace(")", "").Split(',');
                byte r1 = byte.Parse(colarg1[0]);
                byte g1 = byte.Parse(colarg1[1]);
                byte b1 = byte.Parse(colarg1[2]);

                lbl.ForeColor = Color.FromArgb(r1, g1, b1);

                string[] colarg2 = style_argumentation[4].Replace("(", "").Replace(")", "").Split(',');
                byte r2 = byte.Parse(colarg2[0]);
                byte g2 = byte.Parse(colarg2[1]);
                byte b2 = byte.Parse(colarg2[2]);

                lbl.BackColor = Color.FromArgb(r2, g2, b2);

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
            }
            catch (Exception)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Open = false;
            save = false;

            NEWCODE = System.IO.File.ReadAllText(publicURL);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Open = false;
            save = true;
        }

        private void auto_size_CheckedChanged(object sender, EventArgs e)
        {
            if (auto_size.Checked == false)
            {
                width.Enabled = true;
                height.Enabled = true;
            }
            else
            {
                width.Enabled = false;
                height.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Open = false;
            save = false;

            NEWCODE = System.IO.File.ReadAllText(publicURL);
        }
    }
}
