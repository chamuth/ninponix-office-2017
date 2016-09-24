using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ninponix_Office
{
    public partial class Message : Form
    {
        bool open = true;

        public Image WarningICO = Image.FromFile(Application.ExecutablePath.Replace("Ninponix Office.exe","") + "OfficeData\\ImageRaw\\1026\\Warn.nofficeimageraw");
        public Image ErrorICO = Image.FromFile(Application.ExecutablePath.Replace("Ninponix Office.exe", "")  + "OfficeData\\ImageRaw\\1026\\Error.nofficeimageraw");
        public Image InformationICO = Image.FromFile(Application.ExecutablePath.Replace("Ninponix Office.exe", "") + "OfficeData\\ImageRaw\\1026\\Information.nofficeimageraw");
        int widthx;
        int heighty;

        public Message(string Title, string content, MessageIcon.MessageIconType icn, MessageIcon.MessageMode mode)
        {
            InitializeComponent();
            Text = Title;
            title.Text = Title;
            body.Text = content;

            switch (icn)
            {
                case MessageIcon.MessageIconType.Warning:
                    messageicon.Image = WarningICO;
                    break;
                case MessageIcon.MessageIconType.Error:
                    messageicon.Image = ErrorICO;
                    break;
                case MessageIcon.MessageIconType.Information:
                    messageicon.Image = InformationICO;
                    break;
            }
            if (mode == MessageIcon.MessageMode.Normal)
            {
                panel1.BackColor = Color.DeepSkyBlue;
                title.ForeColor = Color.DeepSkyBlue;
            }
            else if (mode == MessageIcon.MessageMode.Presentation)
            {
                panel1.BackColor = Color.LimeGreen;
                title.ForeColor = Color.LimeGreen;
            }
            else if (mode == MessageIcon.MessageMode.NVL)
            {
                panel1.BackColor = Color.Orange;
                title.ForeColor = Color.Orange;
            }
        }

        private void Message_Load(object sender, EventArgs e)
        {
            SystemSounds.Exclamation.Play();
            widthx = Width;
            heighty = Height; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            animation_timer.Start();
            open = false;

        }

        private void animation_timer_Tick(object sender, EventArgs e)
        {
            if (open == true)
            {
                if (Opacity != 1)
                {
                    Opacity += 0.1;
                }
                else
                {
                    animation_timer.Stop();
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
                    animation_timer.Stop();
                }
            }
        }
        int count;

        private void size_animations_Tick(object sender, EventArgs e)
        {
            count++;

            switch (count)
            {
                case 1:
                    Width = widthx + 50;
                    Height = heighty + 20;
                    Location = new Point((Screen.PrimaryScreen.WorkingArea.Width / 2) - (Width / 2), (Screen.PrimaryScreen.WorkingArea.Height / 2) - ((Height) / 2));
                    break;
                case 2:
                    Width = widthx + 25;
                    Height = heighty + 20;
                    Location = new Point((Screen.PrimaryScreen.WorkingArea.Width / 2) - (Width / 2), (Screen.PrimaryScreen.WorkingArea.Height / 2) - ((Height) / 2));
                    break;
                case 3:
                    Width = widthx + 15;
                    Height = heighty + 15;
                    Location = new Point((Screen.PrimaryScreen.WorkingArea.Width / 2) - (Width / 2), (Screen.PrimaryScreen.WorkingArea.Height / 2) - ((Height) / 2));
                    break;
                case 4:
                    Width = widthx + 10;
                    Height = heighty + 10;
                    Location = new Point((Screen.PrimaryScreen.WorkingArea.Width / 2) - (Width / 2), (Screen.PrimaryScreen.WorkingArea.Height / 2) - ((Height) / 2));
                    break;
                case 5:
                    Width = widthx + 5;
                    Height = heighty + 5;
                    Location = new Point((Screen.PrimaryScreen.WorkingArea.Width / 2) - (Width / 2), (Screen.PrimaryScreen.WorkingArea.Height / 2) - ((Height) / 2));
                    break;
                case 6:
                    Width = widthx + 4;
                    Height = heighty + 4;
                    Location = new Point((Screen.PrimaryScreen.WorkingArea.Width / 2) - (Width / 2), (Screen.PrimaryScreen.WorkingArea.Height / 2) - ((Height) / 2));
                    break;
                case 7:
                    Width = widthx + 3;
                    Height = heighty + 3;
                    Location = new Point((Screen.PrimaryScreen.WorkingArea.Width / 2) - (Width / 2), (Screen.PrimaryScreen.WorkingArea.Height / 2) - ((Height) / 2));
                    break;
                case 8:
                    Width = widthx + 2;
                    Height = heighty + 2;
                    Location = new Point((Screen.PrimaryScreen.WorkingArea.Width / 2) - (Width / 2), (Screen.PrimaryScreen.WorkingArea.Height / 2) - ((Height) / 2));
                    break;
                case 9:
                    Width = widthx + 1;
                    Height = heighty + 1;
                    Location = new Point((Screen.PrimaryScreen.WorkingArea.Width / 2) - (Width / 2), (Screen.PrimaryScreen.WorkingArea.Height / 2) - ((Height) / 2));
                    break;
                case 10:
                    Width = widthx;
                    Height = heighty;
                    Location = new Point((Screen.PrimaryScreen.WorkingArea.Width / 2) - (Width / 2), (Screen.PrimaryScreen.WorkingArea.Height / 2) - ((Height) / 2));
                    break;
            }
        }

        private void body_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
