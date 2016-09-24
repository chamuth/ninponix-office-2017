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
    public partial class StyleManager : Form
    {
        public string TextRich;

        public StyleManager(string Text)
        {
            InitializeComponent();
            TextRich = Text.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "Show Code")
            {
                button2.Text = "Show Style";
                splitContainer1.Panel1Collapsed = true;
                splitContainer1.Panel2Collapsed = false;
            }
            else
            {
                button2.Text = "Show Code";
                splitContainer1.Panel1Collapsed = false;
                splitContainer1.Panel2Collapsed = true;
            }
        }

        private void StyleManager_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var lines in TextRich.Split('\n'))
            {//Each Line in the NVL Code
                if (lines.StartsWith("[STYLE "))
                {
                    //STYLE Found
                    var style_arg_sep = lines.Split(':')[1];
                    var style_name = lines.Split(':')[0];
                    style_name = style_name.Replace("[STYLE ", "");
                    listBox1.Items.Add(style_name.ToString());
                }
            }
            if (listBox1.Items.Count > 0)
                listBox1.SelectedIndex = 0;
        }

        public void UpdateVisualization()
        {
            splitContainer1.Panel1.Controls.Clear();

            //Get Style contents and apply it to the label
            Label lbl = new Label();

            try
            {
                string stylecontent = "";
                foreach (var lines in TextRich.Split('\n'))
                {
                    if (lines.StartsWith("[STYLE " + listBox1.SelectedItem.ToString()))
                    {
                        stylecontent = lines.Split(':')[1].Replace("]", "");
                    }
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
                lbl.Size = new Size(splitContainer1.Panel1.Width - 5, int.Parse(FontSize) + 20);
                lbl.TextAlign = ContentAlignment.MiddleLeft;

                splitContainer1.Panel1.Controls.Add(lbl);
            }
            catch (Exception)
            {

            }

            lbl.Text = "Sample Text";

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //GET CODE OF THE STYLE
            foreach (var lines in TextRich.Split('\n'))
            {
                try {
                    if (lines.StartsWith("[STYLE " + listBox1.SelectedItem.ToString()))
                    {
                        //It's the STYLE THAT WE NEED
                        code_txt.Text = lines.ToString();
                        code_txt.WordWrap = true;
                    }
                }catch (Exception)
                {

                }
            }

            UpdateVisualization();
        }

        private void code_txt_TextChanged(object sender, EventArgs e)
        {
            if (code_txt.Text.Substring(1, 5).ToUpper() == "STYLE")
            {
                code_txt.Select(1, 5);
                code_txt.SelectionColor = Color.Orange;
                code_txt.Select(code_txt.Text.Length,0);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Remove Style " + listBox1.SelectedItem.ToString() + "?", "Ninponix Office 2017", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                splitContainer1.Panel1.Controls.Clear();
                code_txt.Text = "";

                int linecount = 0;
                string Output = "";

                foreach (var lines in TextRich.Split('\n'))
                {
                    linecount++;
                    //LINES COUNTING RIGHT NOW
                    if (lines.StartsWith("[STYLE " + listBox1.SelectedItem.ToString()))
                    { //IT's THE STYLE THAT WE NEED SO DON't ADD IT TO THE RETURN LIST
                    }
                    else
                    {
                        Output += lines.ToString() + "\n";
                    }
                }

                TextRich = Output;

                //REFRESH THE ITEMS IN THE LIST

                listBox1.Items.Clear();
                foreach (var lines in TextRich.Split('\n'))
                {//Each Line in the NVL Code
                    if (lines.StartsWith("[STYLE "))
                    {
                        //STYLE Found
                        var style_arg_sep = lines.Split(':')[1];
                        var style_name = lines.Split(':')[0];
                        style_name = style_name.Replace("[STYLE ", "");
                        listBox1.Items.Add(style_name.ToString());
                    }
                }
                if (listBox1.Items.Count > 0)
                    listBox1.SelectedIndex = 0;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AddStyle sty = new AddStyle(TextRich);
            sty.ShowDialog();
            TextRich = sty.TextRich;

            //Reinitialize the Style Sheets

            listBox1.Items.Clear();
            foreach (var lines in TextRich.Split('\n'))
            {//Each Line in the NVL Code
                if (lines.StartsWith("[STYLE "))
                {
                    //STYLE Found
                    var style_arg_sep = lines.Split(':')[1];
                    var style_name = lines.Split(':')[0];
                    style_name = style_name.Replace("[STYLE ", "");
                    listBox1.Items.Add(style_name.ToString());
                }
            }
            if (listBox1.Items.Count > 0)
                listBox1.SelectedIndex = 0;
        }
    }
}
