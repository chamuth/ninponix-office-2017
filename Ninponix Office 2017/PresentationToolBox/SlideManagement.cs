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
    public partial class SlideManagement : Form
    {
        public string currentCode;
        public string RETURNCODE;
        public int currentSlide;

        public SlideManagement()
        {
            InitializeComponent();
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

        private void SlideManagement_Load(object sender, EventArgs e)
        {

        }

        private void SlideManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Force == false)
            {
                Open = false;
                e.Cancel = true;
            }
        }
     
        private void button3_Click(object sender, EventArgs e)
        {
            string newcode = "[SLIDE]\n\n[/SLIDE]";
            RETURNCODE = currentCode + "\n" + newcode.ToString();
            Open = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int nowcounter = 0;
            string newcode = "";
            
            foreach (string line in currentCode.Split('\n'))
            {
                if (line.TrimStart().StartsWith("[SLIDE]"))
                {
                    nowcounter++;
                   
                    if (nowcounter != currentSlide)
                    {
                        newcode += line + "\n";
                    }
                } else if (line.TrimStart().StartsWith("[/SLIDE]"))
                {
                    if (nowcounter != currentSlide)
                    {
                        newcode += line + "\n";
                    }
                }
                else
                {
                    if (nowcounter != currentSlide)
                    {
                        newcode += line + "\n";
                    }
                }
            }

            RETURNCODE = newcode;
            Open = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Open = false;
            RETURNCODE = currentCode;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                //DELETE Every Slide
                string newcode = "";

                foreach (string line in currentCode.Split('\n'))
                {
                    if (line.TrimStart().StartsWith("[NVL") || line.TrimStart().StartsWith("{STYLE") || line.TrimStart().StartsWith("[NAME"))
                    {
                        /*  
                            {STYLE:Joka;Roboto Condensed;14;(0,64,128);(255,255,255);BOLD}
                            [NVL:PRESENTATION;(16,9)]
                            [NAME:Chamuth] 
                            {STYLE:Hello World;Mingle;5;(0,0,0);(255,255,255);REGULAR}
                        */
                    }
                    else
                    {
                        newcode += line + "\n";
                    }
                }

                RETURNCODE = newcode;
                Open = false;
            }
            catch (Exception)
            {
                Message msg = new Message("Ninponix Office 2017", "Could not delete every slide in the presentation", MessageIcon.MessageIconType.Error, MessageIcon.MessageMode.Presentation);
                msg.ShowDialog();
                Open = false;
            }
        }
    }
}
