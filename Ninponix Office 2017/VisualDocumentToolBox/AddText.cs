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
    public partial class AddText : Form
    {
        public string ReturnText;
        string TextRich;

        public AddText(string Text)
        {
            InitializeComponent();
            TextRich = Text;
        }

        private void AddText_Load(object sender, EventArgs e)
        {
            ReturnText = TextRich;
            if (System.IO.Directory.GetFiles(Application.ExecutablePath.Replace("Ninponix Office.exe", "") + @"Runtime\NVL\VHeap").Count() == 0)
            {
                MessageBox.Show("No Style Declaration found in the NVL Code. Please make sure you have declared / created a style before creating a Text Object", "Ninponix Office 2017", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
            else
            {
                foreach (var style in System.IO.Directory.GetFiles(Application.ExecutablePath.Replace("Ninponix Office.exe", "") + @"Runtime\NVL\VHeap"))
                {
                    string name = style.Split('\\')[style.Split('\\').Count() - 1];
                    name = name.Remove(name.Count() - 7, 7);
                    style_list.Items.Add(name.ToString());
                }
            }
        }

        private void style_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Initializing Style Preview. Please Wait...", "Ninponix Live Preview Protocol 15.2", MessageBoxButtons.OK, MessageBoxIcon.Information);

            try
            {
                if (System.IO.File.Exists(Application.ExecutablePath.Replace("Ninponix Office.exe", "") + @"Runtime\NVL\VHeap\" + style_list.SelectedText + ".nvlsty"))
                {// It's the style Horaaay.

                    string StyleContent = System.IO.File.ReadAllText(Application.ExecutablePath.Replace("Ninponix Office.exe", "") + @"Runtime\NVL\VHeap\" + style_list.SelectedText + ".nvlsty");
                    string[] args = StyleContent.Split(';');

                    string FontName = "Arial";
                    string FontSize = "12";
                    string FontStyle = "";
                    string FontColor = "0,0,0";
                    string BackgroundColor = "255,255,255";

                    foreach (var arguments in args)
                    {
                        string property = arguments.Split('=')[0];
                        string value = arguments.Split('=')[1];


                        switch (property.ToUpper())
                        {
                            case "FONT":
                                FontName = value;
                                break;
                            case "SIZE":
                                FontSize = value;
                                break;
                            case "COLOR":
                                FontColor = value;
                                break;
                            case "STYLE":
                                FontStyle = value;
                                break;
                            case "BACKGROUND":
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

                    preview_txt.Font = f;

                    byte r1 = byte.Parse(FontColor.Split(',')[0]); byte g1 = byte.Parse(FontColor.Split(',')[1]); byte b1 = byte.Parse(FontColor.Split(',')[2]);
                    byte r2 = byte.Parse(BackgroundColor.Split(',')[0]); byte g2 = byte.Parse(BackgroundColor.Split(',')[1]); byte b2 = byte.Parse(BackgroundColor.Split(',')[2]);

                    preview_txt.ForeColor = Color.FromArgb(r1, g1, b1);
                    preview_txt.BackColor = Color.FromArgb(r2, g2, b2);
                    preview_panel.BackColor = preview_txt.BackColor;

                    preview_txt.Text = name_txt.Text;

                    style_list.BackColor = Color.White;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Style content faliure. Make sure the style arguments are valid", "Ninponix Office 2017", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                preview_txt.AutoSize = false;
                preview_txt.Size = new Size(int.Parse(size_width.Text), int.Parse(size_height.Text));
            }
            else
            {
                preview_txt.AutoSize = true;
            }
        }

        private void size_width_TextChanged(object sender, EventArgs e)
        {
            try
            {
                preview_txt.Size = new Size(int.Parse(size_width.Text), int.Parse(size_height.Text));
                size_width.BackColor = Color.White;
            }
            catch (Exception)
            {
                size_width.BackColor = Color.Red;
            }
        }

        private void size_height_TextChanged(object sender, EventArgs e)
        {
            try
            {
                preview_txt.Size = new Size(int.Parse(size_width.Text), int.Parse(size_height.Text));
                size_height.BackColor = Color.White;
            }
            catch (Exception)
            {
                size_height.BackColor = Color.Red;
            }
        }

        private void name_txt_TextChanged(object sender, EventArgs e)
        {
            if (name_txt.Text.Replace(" ", "").Count() == 0)
            {
                name_txt.BackColor = Color.Red;
            }
            else
            {
                name_txt.BackColor = Color.White;
            }

            preview_txt.Text = name_txt.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool good = false;

            try
            {
                int lx = int.Parse(location_x.Text);
                int ly = int.Parse(location_y.Text);
                int sw = int.Parse(size_width.Text);
                int sh = int.Parse(size_height.Text);

                good = true;
            }
            catch (Exception)
            {
                good = false;
            }

            if (good)
            {
                if ((name_txt.Text.Replace(" ", "").Count() != 0))
                {
                    string line = "";

                    if (checkBox1.Checked)
                    {
                        line = "{AREA>" + style_list.SelectedItem.ToString() + ";(" + size_width.Text.ToString() + "," + size_height.Text.ToString() + ");" + location_x.Text.ToString() + "," + location_y.Text.ToString() + "}" + name_txt.Text.ToString();
                    }
                    else
                    {
                        line = "{" + style_list.SelectedItem.ToString() + ":" + location_x.Text.ToString() + "," + location_y.Text.ToString() + "}" + name_txt.Text.ToString();
                    }

                    if (TextRich.EndsWith("\n"))
                    {
                        ReturnText = TextRich + line;
                    }
                    else
                    {
                        ReturnText = TextRich + "\n" + line;
                    }
                    Close();
                }
                else
                {
                    MessageBox.Show("Invalid Text Tag Parameters. Make sure Style, Content, Size, Location is valid");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReturnText = TextRich;
            Close();
        }

        private void location_x_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int.Parse(location_x.Text);
                location_x.BackColor = Color.White;
            }
            catch (Exception)
            {
                location_x.BackColor = Color.Red;
            }
        }

        private void location_y_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int.Parse(location_y.Text);
                location_y.BackColor = Color.White;
            }
            catch (Exception)
            {
                location_y.BackColor = Color.Red;
            }
        }
    }
}
