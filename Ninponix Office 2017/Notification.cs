using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ninponix_Office
{
    public partial class Notification : Form
    {
        public enum NotificationMode
        {
            OrangeMode,
            BlueMode,
            GreenMode
        }

        public string HelpLinking;

        public Notification(NotificationMode mode, string HelpLink,string Topic, string Information)
        {
            InitializeComponent();
            switch (mode)
            {
                case NotificationMode.BlueMode:
                    BackColor = Color.DeepSkyBlue;
                    break;
                case NotificationMode.OrangeMode:
                    BackColor = Color.Orange;
                    break;
                case NotificationMode.GreenMode:
                    BackColor = Color.LimeGreen;
                    break;
            }

            HelpLinking = HelpLink;

            label1.Text = Topic.ToString();
            label2.Text = Information.ToString();

            int possiblex = Screen.PrimaryScreen.WorkingArea.Width;
            int possibley = Screen.PrimaryScreen.WorkingArea.Height;

            possiblex = possiblex - (Width + 10);
            possibley = possibley - (Height + 10);

            Location = new Point(possiblex, possibley);
        }

        private void Notification_Load(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(HelpLinking);
            }catch (Exception)
            {

            }
        }

        bool open = true;
        bool force = false;

        private void starting_animations_Tick(object sender, EventArgs e)
        {
            if (open)
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

        private void Notification_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (force == false)
            {
                e.Cancel = true;
                open = false;
            }
        }

        private void end_timer_Tick(object sender, EventArgs e)
        {
            end_timer.Stop();
            open = false;
        }
    }
}
