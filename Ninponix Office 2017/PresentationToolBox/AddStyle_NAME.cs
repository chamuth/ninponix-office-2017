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
    public partial class AddStyle_NAME : Form
    {
        public string CODE;
        public string RETURN_CODE;

        public AddStyle_NAME(string _code)
        {
            InitializeComponent();
            CODE = _code;
        }

        //{STYLE:H;Segoe UI;15;(25,25,25);(155,190,255);REGULAR}

        private void button2_Click(object sender, EventArgs e)
        {
            if (style_name.Text.Trim() == "")
            {
                //The style name is empty
                Message msg = new Message("Ninponix Office 2017", "The Style name is empty. Please make sure that the name is complete and accurate", MessageIcon.MessageIconType.Warning, MessageIcon.MessageMode.Presentation);
                msg.ShowDialog();
            }
            else
            {
                if (font_name.Text.Trim() == "" | font_size.Value == 0)
                {
                    Message msg = new Message("Ninponix Office 2017", "The font is invalid. The given values and parameters cannot be converted into any type of font", MessageIcon.MessageIconType.Warning, MessageIcon.MessageMode.Presentation);
                    msg.ShowDialog();
                }
                else
                {
                    string[] dalist = { "REGULAR", "BOLD", "ITALIC", "UNDERLINE", "STRIKEOUT", "BOLDITALIC", "BOLDUNDERLINE", "BOLDSTRIKEOUT", "ITALICUNDERLINE", "ITALICSTRIKEOUT", "BOLDITALICUNDERLINE", "BOLDITALICUNDERLINESTRIKEOUT" };
                    if (dalist.Contains(text_style.Text) == false)
                    {
                        Message msg = new Message("Ninponix Office 2017", "The text style mentioned is invalid. Please input a vaild text style to continue", MessageIcon.MessageIconType.Warning, MessageIcon.MessageMode.Presentation);
                        msg.ShowDialog();
                    }
                    else
                    {
                        //You're good to go.
                        string style_adding_Code = "{STYLE:" + style_name.Text.ToString() + ";" + font_name.Text.ToString() + ";" + font_size.Text.ToString() + ";" + "(" + fore_Color.BackColor.R.ToString() + "," + fore_Color.BackColor.G.ToString() + "," + fore_Color.BackColor.B.ToString() + ");(" + back_Color.BackColor.R.ToString() + "," + back_Color.BackColor.G.ToString() + "," + back_Color.BackColor.B.ToString() + ");" + text_style.Text.ToString() + "}";
                        RETURN_CODE = style_adding_Code + "\n" + CODE.ToString();
                        Open = false;
                    }
                }
            }
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            Open = false;
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

        private void font_browsing_Button_Click(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();
            if (font_size.Value == 0)
            {
                font.Font = new Font(font_name.Text,1);
            }
            else
            {
                font.Font = new Font(font_name.Text, (float)font_size.Value);
            }
            if (font.ShowDialog () == DialogResult.OK)
            {
                font_name.Text = font.Font.Name;
                font_size.Value = (decimal)font.Font.Size;
            }
        }

        private void fore_Color_MouseDown(object sender, MouseEventArgs e)
        {
            ColorDialog color = new ColorDialog();
            color.Color = fore_Color.BackColor;

            if (color.ShowDialog() == DialogResult.OK)
            {
                fore_Color.BackColor = color.Color;
            }
        }

        private void back_Color_MouseDown(object sender, MouseEventArgs e)
        {
            ColorDialog color = new ColorDialog();
            color.Color = back_Color.BackColor;

            if (color.ShowDialog() == DialogResult.OK)
            {
                back_Color.BackColor = color.Color;
            }
        }
    }
}
