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
    public partial class DocumentInfo : Form
    {
        string TextRich;
        public string returnString;

        public DocumentInfo(string Text)
        {
            InitializeComponent();
            TextRich = Text;
        }

        private void DocumentInfo_Load(object sender, EventArgs e)
        {
            returnString = TextRich;
            foreach (var lines in TextRich.Split('\n'))
            {
                if (lines.StartsWith("[DOCUMENT:"))
                {//It's Document Attribute
                    try
                    {
                        doc_attr_tag.Text = "* Document Attribute Tag Found";
                        doc_attr_tag.ForeColor = Color.Orange;
                        string[] args = lines.Split(':')[1].Split(';');
                        string size = args[0];
                        size = size.Replace("(", "").Replace(")", "");
                        if (size.Contains(","))
                        {
                            width_txt.Text = size.Split(',')[0];
                            height_txt.Text = size.Split(',')[1];
                        }
                        else
                        {
                            Size a5 = new Size(419, 595);
                            Size a4 = new Size(595, 841);
                            Size a3 = new Size(841, 1190);
                            Size letter = new Size(612, 792);
                            Size legal = new Size(612, 1008);
                            Size tabloid = new Size(792, 1224);

                            switch (size.ToUpper())
                            {
                                case "LETTER":
                                    width_txt.Text = letter.Width.ToString();
                                    height_txt.Text = letter.Height.ToString();
                                    break;
                                case "A5":
                                    width_txt.Text = a5.Width.ToString();
                                    height_txt.Text = a5.Height.ToString();
                                    break;
                                case "A4":
                                    width_txt.Text = a4.Width.ToString();
                                    height_txt.Text = a4.Height.ToString();
                                    break;
                                case "A3":
                                    width_txt.Text = a3.Width.ToString();
                                    height_txt.Text = a3.Height.ToString();
                                    break;
                                case "LEGAL":
                                    width_txt.Text = legal.Width.ToString();
                                    height_txt.Text = legal.Height.ToString();
                                    break;
                                case "TABLOID":

                                    width_txt.Text = tabloid.Width.ToString();
                                    height_txt.Text = tabloid.Height.ToString();
                                    break;
                            }
                        }
                        doc_col.Text = args[1].Replace("]", "");
                    }
                    catch (Exception)
                    {
                        doc_attr_tag.Text = "* Document Attribute Tag Not Found";
                        doc_attr_tag.ForeColor = Color.Gray;
                    }
                }
                else if (lines.StartsWith("[NAME:"))
                {
                    try
                    {
                        string name = lines.Split(':')[1];
                        name = name.Remove(name.Length - 1, 1);
                        name_txt.Text = name;
                        //Name completed
                        name_tag.Text = "* Document Name Tag Found";
                        name_tag.ForeColor = Color.Orange;
                    }
                    catch (Exception)
                    {
                        name_tag.Text = "* Document Name Tag Not Found";
                        name_tag.ForeColor = Color.Gray;
                    }
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (!(name_txt.Text.Replace(" ", "").Count() == 0))
            {
                string line = "[NAME:" + name_txt.Text + "]";
                string startword = "";
                int counter = 0;
                if (name_tag.ForeColor == Color.Orange)
                {
                    foreach (var chars in TextRich)
                    {
                        counter++;
                        if (chars != '\n')
                            startword += chars;
                        else
                        {
                            if (startword.StartsWith("[NAME:"))
                            {
                                returnString = TextRich.Remove(counter - startword.Count() - 1, startword.Count());
                                returnString = line + "\n" + returnString;
                                Close();
                            }
                            startword = "";
                        }
                    }
                }
                else
                {
                    returnString = line + "\n" + TextRich;
                    Close();
                }
            }
            else
            {
                MessageBox.Show("The name you given to the Document is invalid. Please insert a valid Document name to continue", "Ninponix Office 2017", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (doc_col.BackColor == Color.White & width_txt.BackColor == Color.White & height_txt.BackColor == Color.White)
            {
                string line = "[DOCUMENT:(" + width_txt.Text + "," + height_txt.Text + ");" + doc_col.Text + "]";
                string startword = "";
                int counter = 0;
                if (doc_attr_tag.ForeColor == Color.Orange)
                {
                    foreach (var chars in TextRich)
                    {
                        counter++;
                        if (chars != '\n')
                            startword += chars;
                        else
                        {
                            if (startword.StartsWith("[DOCUMENT:"))
                            {
                                returnString = TextRich.Remove(counter - startword.Count() - 1, startword.Count());
                                returnString = line + "\n" + returnString;
                                Close();
                            }
                            startword = "";
                        }
                    }
                }
                else
                {
                    returnString = line + "\n" + TextRich;
                    Close();
                }
            }
            else
            {
                MessageBox.Show("The selected Width, Height or the Color Value is invalid. Width and Height supports integral values measuring the Pixel values of the measurements of the document. The Color Attribute is measured with KnownColors in the System.", "Ninponix Office 2017", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void doc_col_TextChanged(object sender, EventArgs e)
        {
            Color c = Color.FromName(doc_col.Text);
            if (c.IsKnownColor == true)
            {
                doc_col.BackColor = Color.White;
            }
            else
            {
                doc_col.BackColor = Color.Red;
            }
        }

        private void width_txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int w = int.Parse(width_txt.Text);
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
                width_txt.BackColor = Color.White;
            }catch (Exception)
            {
                height_txt.BackColor = Color.Red;
            }
        }
    }
}
