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
    public partial class AddStyle : Form
    {
        public string TextRich;

        public AddStyle(string Text)
        {
            InitializeComponent();
            TextRich = Text;
        }

        private void AddStyle_Load(object sender, EventArgs e)
        {
            style_container.Items.Clear();
            style_container.Items.Add("Regular");
            style_container.Items.Add("Bold");
            style_container.Items.Add("Italic");
            style_container.Items.Add("Underline");
            style_container.Items.Add("Stikeout");
            style_container.Items.Add("BoldItalic");
            style_container.Items.Add("BoldUnderline");
            style_container.Items.Add("BoldStrikeout");
            style_container.Items.Add("ItalicUnderline");
            style_container.Items.Add("BoldItalicUnderline");
            style_container.SelectedIndex = 0;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();
            try
            {
                font.Font = new Font(fontfamily.Text.ToString(), int.Parse(fontsize.Text.ToString()));
            }
            catch (Exception) { }

            font.ShowColor = false;

            if (font.ShowDialog() == DialogResult.OK)
            {
                fontfamily.Text = font.Font.FontFamily.Name.ToString();
                int fontsize_integer = (int)font.Font.Size;
                fontsize.Text = fontsize_integer.ToString();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ColorDialog col = new ColorDialog();

            try {
                int r = int.Parse(font_color_txt.Text.Split(',')[0]);
                int g = int.Parse(font_color_txt.Text.Split(',')[1]);
                int b = int.Parse(font_color_txt.Text.Split(',')[2]);

                col.Color = Color.FromArgb(r, g, b);
            }catch (Exception) { }

            col.AnyColor = true;
            col.AllowFullOpen = true;

            if (col.ShowDialog() == DialogResult.OK)
            {
                font_color_txt.Text = col.Color.R.ToString() + "," + col.Color.G.ToString() + "," + col.Color.B.ToString();
            }
        }

        private void background_color_txt_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ColorDialog col = new ColorDialog();

            try {
                int r = int.Parse(background_color_txt.Text.Split(',')[0]);
                int g = int.Parse(background_color_txt.Text.Split(',')[1]);
                int b = int.Parse(background_color_txt.Text.Split(',')[2]);

                col.Color = Color.FromArgb(r, g, b);
            }catch (Exception) { }

            col.AnyColor = true;
            col.AllowFullOpen = true;

            if (col.ShowDialog() == DialogResult.OK)
            {
                background_color_txt.Text = col.Color.R.ToString() + "," + col.Color.G.ToString() + "," + col.Color.B.ToString();
            }
        }

        private void font_color_txt_TextChanged(object sender, EventArgs e)
        {
            try {
                byte r = byte.Parse(font_color_txt.Text.Split(',')[0]);
                byte g = byte.Parse(font_color_txt.Text.Split(',')[1]);
                byte b = byte.Parse(font_color_txt.Text.Split(',')[2]);

                font_color_txt.BackColor = Color.FromArgb(r, g, b);

                if (font_color_txt.BackColor == Color.White)
                {
                    font_color_txt.ForeColor = Color.Black;
                }
                else
                {
                    font_color_txt.ForeColor = Color.White;
                }
            }catch (Exception) { font_color_txt.BackColor = Color.Red; }

            try
            {
                UpdateVisualization();
            }
            catch (Exception)
            { }

        }

        private void background_color_txt_TextChanged(object sender, EventArgs e)
        {
            try {
                byte r = byte.Parse(background_color_txt.Text.Split(',')[0]);
                byte g = byte.Parse(background_color_txt.Text.Split(',')[1]);
                byte b = byte.Parse(background_color_txt.Text.Split(',')[2]);

                background_color_txt.BackColor = Color.FromArgb(r, g, b);

                if (background_color_txt.BackColor == Color.White)
                {
                    background_color_txt.ForeColor = Color.Black;
                }
                else
                {
                    background_color_txt.ForeColor = Color.White;
                }
            }
            catch (Exception)
            {
                background_color_txt.BackColor = Color.Red;
            }

            try
            {
                UpdateVisualization();
            }
            catch (Exception)
            { }

        }

        public void UpdateVisualization()
        {
            Font f = new Font(fontfamily.Text, int.Parse(fontsize.Text));

            switch (style_container.SelectedItem.ToString())
            {
                case "Regular":
                    f = new Font(fontfamily.Text, int.Parse(fontsize.Text), System.Drawing.FontStyle.Regular);
                    break;
                case "Bold":
                    f = new Font(fontfamily.Text, int.Parse(fontsize.Text), System.Drawing.FontStyle.Bold);
                    break;
                case "Italic":
                    f = new Font(fontfamily.Text, int.Parse(fontsize.Text), System.Drawing.FontStyle.Italic);
                    break;
                case "Strikeout":
                    f = new Font(fontfamily.Text, int.Parse(fontsize.Text), System.Drawing.FontStyle.Strikeout);
                    break;
                case "Underline":
                    f = new Font(fontfamily.Text, int.Parse(fontsize.Text), System.Drawing.FontStyle.Underline);
                    break;
                case "BoldItalic":
                    f = new Font(fontfamily.Text, int.Parse(fontsize.Text), System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
                    break;
                case "BoldStrikeout":
                    f = new Font(fontfamily.Text, int.Parse(fontsize.Text), System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout);
                    break;
                case "BoldUnderline":
                    f = new Font(fontfamily.Text, int.Parse(fontsize.Text), System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline);
                    break;
                case "ItalicUnderline":
                    f = new Font(fontfamily.Text, int.Parse(fontsize.Text), System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline);
                    break;
                case "BoldItalicUnderline":
                    f = new Font(fontfamily.Text, int.Parse(fontsize.Text), System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline);
                    break;
            }

            preview_label.Font = f;
            preview_label.ForeColor = font_color_txt.BackColor;
            preview_label.BackColor = background_color_txt.BackColor;

            preview_label.Text = style_name.Text;
        }

        private void style_name_TextChanged(object sender, EventArgs e)
        {
            if (style_name.Text.Replace(" " , "").Count() == 0 | style_name.Text.EndsWith(" ") == true | System.IO.File.Exists(@"Runtime\NVL\VHeap\" + style_name.Text.ToString() + ".nvlsty") == true) 
            {
                style_name.BackColor = Color.Red;
            }
            else
            {
                style_name.BackColor = Color.White;
            }

            try
            {
                UpdateVisualization();
            }catch (Exception)
            {}
        }

        private void fontfamily_TextChanged(object sender, EventArgs e)
        {
            try
            {
                UpdateVisualization();
                fontfamily.BackColor = Color.White;
            }
            catch (Exception)
            { fontfamily.BackColor = Color.Red; }
        }

        private void fontsize_TextChanged(object sender, EventArgs e)
        {
            try
            {
                UpdateVisualization();
                fontsize.BackColor = Color.White;
            }
            catch (Exception)
            { fontsize.BackColor = Color.Red; }

        }

        private void style_container_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                UpdateVisualization();
            }
            catch (Exception)
            {}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Line = "";
            if (style_name.Text.Replace(" ", "").Count() != 0 & style_name.Text.EndsWith(" ") == false)
            {
                if (System.IO.File.Exists(@"Runtime\NVL\VHeap\" + style_name.Text.ToString() + ".nvlsty") == false)
                {
                    try
                    {
                        Font f = new Font(fontfamily.Text, int.Parse(fontsize.Text));

                        int r1 = int.Parse(font_color_txt.Text.Split(',')[0]);
                        int g1 = int.Parse(font_color_txt.Text.Split(',')[1]);
                        int b1 = int.Parse(font_color_txt.Text.Split(',')[2]);

                        int r2 = int.Parse(background_color_txt.Text.Split(',')[0]);
                        int g2 = int.Parse(background_color_txt.Text.Split(',')[1]);
                        int b2 = int.Parse(background_color_txt.Text.Split(',')[2]);

                        //GOOD TO GO [STYLE Normal:Font=Segoe UI;Size=12;Color=0,0,0;Style=Italic;Background=255,255,255]

                        Line = "[STYLE " + style_name.Text.ToString() + ":Font=" + fontfamily.Text.ToString() + ";Size=" + fontsize.Text.ToString() + ";Color=" + r1.ToString() + "," + g1.ToString() + "," + b1.ToString() + ";Style=" + style_container.SelectedItem.ToString() + ";Background=" + r2.ToString() + "," + g2.ToString() + "," + b2.ToString() + "]";
                        TextRich = Line + "\n" + TextRich;
                        Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("The Parameters for the Style are invalid. Please insert valid Style Information Data to Continue.", "Ninponix Office 2017", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("There is another Style declared with the name " + style_name.Text + ". Style names should be unique each other", "Ninponix Office 2017", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid Style Name. Style names should be unique, non-empty and should work with URI Format Finders", "Ninponix Office 2017", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
