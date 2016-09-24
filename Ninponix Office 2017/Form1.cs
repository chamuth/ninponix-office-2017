using Microsoft.Win32;
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
    public partial class Form1 : Form
    {
        string shader1 = Application.ExecutablePath.Replace("Ninponix Office.exe", "") + "OfficeData\\ImageRaw\\shader_1.nofficeraw";
        string nofficeicon = Application.ExecutablePath.Replace("Ninponix Office.exe", "")  + "OfficeData\\ImageRaw\\shader_window_icon.nofficeimageraw";
        string normaltextfileshader = Application.ExecutablePath.Replace("Ninponix Office.exe", "")  + "OfficeData\\ImageRaw\\shader_normal_textfile.nofficeimageraw";
        string richtextfileshader = Application.ExecutablePath.Replace("Ninponix Office.exe", "")  + "OfficeData\\ImageRaw\\shader_rich_textfile.nofficeimageraw";
        string presentationshader = Application.ExecutablePath.Replace("Ninponix Office.exe", "")  + "OfficeData\\ImageRaw\\shader_presentation.nofficeimageraw";
        string spreadsheetshader = Application.ExecutablePath.Replace("Ninponix Office.exe", "") + "\\" + "OfficeData\\ImageRaw\\shader_spreadsheet.nofficeimageraw";
        string codeshader = Application.ExecutablePath.Replace("Ninponix Office.exe", "") + "\\" + "OfficeData\\ImageRaw\\shader_code.nofficeimageraw";
        string nvlshader = Application.ExecutablePath.Replace("Ninponix Office.exe", "") + "\\" + "OfficeData\\ImageRaw\\shader_nvl_file.nofficeimageraw";
        string maximizeiconshader = Application.ExecutablePath.Replace("Ninponix Office.exe", "") + "\\" + "OfficeData\\ImageRaw\\NSWC\\shader_max.nofficeimageraw";
        string minimizeiconshader = Application.ExecutablePath.Replace("Ninponix Office.exe", "") + "\\" + "OfficeData\\ImageRaw\\NSWC\\shader_min.nofficeimageraw";
        string normaliconshader = Application.ExecutablePath.Replace("Ninponix Office.exe", "") + "\\" + "OfficeData\\ImageRaw\\NSWC\\shader_normal.nofficeimageraw";

        bool Maximized = false;

        bool open = true;

        int screenx;
        int screeny;
        int thisx;
        int thisy;

        int Locationx;
        int Locationy;

        public void CheckFrameworks()
        {
            //Check Ninponix Live Preview Protocol Existence
            string path1;
            path1 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);


            if (System.IO.Directory.Exists(path1) == false)
            {
                Message message1 = new Message("Ninponix Live Preview Protocol Error", "Ninponix Live Preview Protocol (NLPP) has been missing from your computer please install NLPP on your computer and continue", MessageIcon.MessageIconType.Error, MessageIcon.MessageMode.Normal);
                message1.ShowDialog();
                Application.Exit();
            }
            else
            {
                try
                {
                    using (System.IO.StreamReader sr = new System.IO.StreamReader(path1 + "\\Version.proto"))
                    {
                        string ver = sr.ReadToEnd();
                        if (ver != "2.3.2")
                        {
                            Message message1 = new Message("Ninponix Live Preview Protocol Error", "The needed version of Ninponix Live Preview Protocol (NLPP) has been missing from your computer please install NLPP on your computer and continue", MessageIcon.MessageIconType.Error, MessageIcon.MessageMode.Normal);
                            message1.ShowDialog();
                            Application.Exit();
                        }
                    }
                }
                catch (Exception)
                {
                    Message message1 = new Message("Ninponix Live Preview Protocol Error", "Ninponix Live Preview Protocol (NLPP) has been missing from your computer please install NLPP on your computer and continue", MessageIcon.MessageIconType.Error, MessageIcon.MessageMode.Normal);
                    message1.ShowDialog();
                    Application.Exit();
                }
            }
        }
        public int LaunchCount = 0;
        public void IncreaseLaunchCount()
        {
            try
            {
                //Get Settings
                int count2;
                using (System.IO.StreamReader sr = new System.IO.StreamReader(Application.StartupPath.Replace("Ninponix Office.exe", "") + "\\" + @"OfficeData\Values\2102.nofficesetting"))
                {
                    string SettingsContent = sr.ReadToEnd();
                    count2 = int.Parse(SettingsContent);
                    sr.Close();
                }

                count2++;
                //Save settings
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(Application.StartupPath.Replace("Ninponix Office.exe", "") + "\\" + @"OfficeData\Values\2102.nofficesetting"))
                {
                    sw.Write(count2.ToString());
                    sw.Flush();sw.Close();
                }

                LaunchCount = count2;
            }
            catch (Exception)
            {
                Message msg = new Message("Ninponix Office 2017", "Cannot launch Ninponix Office 2017 a very special settings file has been missing from your computer", MessageIcon.MessageIconType.Error, MessageIcon.MessageMode.NVL);
                msg.ShowDialog();
                Application.Exit();
            }
        }

        public void ShowDonations()
        {
            Donations.DonateUs donate = new Donations.DonateUs();
            donate.Show();
        }

        public Form1()
        {
            InitializeComponent();
            IncreaseLaunchCount();
            if (LaunchCount % 10 == 1)
            {
                ShowDonations();
            }
        }
        
        private void Form1_Load(object sender, EventArgs e)
        { 
            //Checks for Administrators Previliges
            try
            {
                using (System.IO.StreamReader sr = new System.IO.StreamReader(Application.StartupPath.Replace("Ninponix Office.exe", "") + "\\" + "Runtime\\AdminQuote.nofficeraw"))
                {
                    if (sr.ReadToEnd().ToUpper().Contains("TRUE") == true)
                    {
                        pictureBox9.Visible = true;
                        Text = "Ninponix Office (Admin)";
                        sr.Close();
                        try
                        {
                            using (System.IO.StreamWriter sw = new System.IO.StreamWriter(Application.StartupPath.Replace("Ninponix Office.exe", "") + "\\" + "Runtime\\AdminQuote.nofficeraw"))
                            {
                                sw.Write("FALSE");
                                sw.Close();
                            }
                        }
                        catch (Exception)
                        {
                            Message msg1 = new Message("Ninponix Office", "Could not access the UAC control runtime file(s).", MessageIcon.MessageIconType.Error, MessageIcon.MessageMode.Normal);
                            msg1.ShowDialog();
                        }
                    }
                    else
                    {
                        pictureBox9.Visible = false;
                        Text = "Ninponix Office";
                    }
                }
            }
            catch (Exception)
            {
                Message msg = new Message("Ninponix Office", "Could not access the UAC control runtime file(s).", MessageIcon.MessageIconType.Error, MessageIcon.MessageMode.Normal);
                msg.ShowDialog();
            }
            

            Log.WriteEntry("Started Ninponix Office 2017", "OFFICE");
            //Loading the initialized images
            pictureBox1.Image = Image.FromFile(shader1);
            template_1.Image = Image.FromFile(normaltextfileshader);
            template_2.Image = Image.FromFile(richtextfileshader);
            template_3.Image = Image.FromFile(presentationshader);
            
            //setting Screen Sizes Before
            screenx = Screen.PrimaryScreen.WorkingArea.Width;
            screeny = Screen.PrimaryScreen.WorkingArea.Height;

            //Setting the Size of the form now
            thisx = 897;
            thisy = 600;

            //Setting the location of the form now
            Locationx = Location.X;
            Locationy = Location.Y;

            //Check for available frameworks
            CheckFrameworks();

            //Check for Recovery Information
            if (System.IO.Directory.GetFiles(Application.StartupPath.Replace("Ninponix Office.exe", "") + "\\" + "Recovery\\").Count() > 0)
            {             
                if (System.IO.File.Exists(Application.StartupPath.Replace("Ninponix Office.exe", "") + "\\" + "Recovery\\TextDocument.txt") == true)
                {
                    if (System.IO.File.ReadAllText(Application.StartupPath.Replace("Ninponix Office.exe", "") + "\\" + "Recovery\\TextDocument.txt").ToString() != "")
                    {
                        recovery_pane_show = true;
                        recovery_panel_animation.Start();

                        text_document_recovery.Visible = true;
                        text_document_time.Text = "Time: " + System.IO.File.GetLastWriteTime(Application.StartupPath.Replace("Ninponix Office.exe", "") + "\\" + "Recovery\\TextDocument.txt").Month.ToString() + "/" + System.IO.File.GetLastWriteTime(Application.StartupPath.Replace("Ninponix Office.exe", "") + "\\" + "Recovery\\TextDocument.txt").Day.ToString() + ": " + System.IO.File.GetLastWriteTime(Application.StartupPath.Replace("Ninponix Office.exe", "") + "\\" + "Recovery\\TextDocument.txt").ToShortTimeString();
                    }
                }
                else
                {
                    text_document_recovery.Visible = false;
                }
            }
            else
            {
                recovery_pane_show = false;
                recovery_panel_animation.Start();
            }

            //CHECK FOR RECOVERY OF VISUAL DOCUMENTS
            if (System.IO.Directory.GetFiles(Application.StartupPath.Replace("Ninponix Office.exe", "") + "\\" + "Recovery\\").Count() > 0)
            {
                if (System.IO.File.Exists(Application.StartupPath.Replace("Ninponix Office.exe", "") + "\\" + "Recovery\\VisualDocument.nvldoc") == true)
                {
                    if (System.IO.File.ReadAllText(Application.StartupPath.Replace("Ninponix Office.exe", "") + "\\" + "Recovery\\VisualDocument.nvldoc").ToString() != "")
                    {
                        recovery_pane_show = true;
                        recovery_panel_animation.Start();

                        vd_recovery.Visible = true;
                        vd_recovery_text.Text = "Time: " + System.IO.File.GetLastWriteTime(Application.StartupPath.Replace("Ninponix Office.exe", "") + "\\" + "Recovery\\VisualDocument.nvldoc").Month.ToString() + "/" + System.IO.File.GetLastWriteTime(Application.StartupPath.Replace("Ninponix Office.exe", "") + "\\" + "Recovery\\VisualDocument.nvldoc").Day.ToString() + ": " + System.IO.File.GetLastWriteTime(Application.StartupPath.Replace("Ninponix Office.exe", "") + "\\" + "Recovery\\VisualDocument.nvldoc").ToShortTimeString();
                    }
                }
                else
                {
                    vd_recovery.Visible = false;
                }
            }
            else
            {
                recovery_pane_show = false;
                recovery_panel_animation.Start();
            }


            //CHECK FOR RECOVERY OF PRESENTATIONS
            if (System.IO.Directory.GetFiles(Application.StartupPath.Replace("Ninponix Office.exe", "") + "\\" + "Recovery\\").Count() > 0)
            {
                if (System.IO.File.Exists(Application.StartupPath.Replace("Ninponix Office.exe", "") + "\\" + "Recovery\\Presentation.nopres") == true)
                {
                    if (System.IO.File.ReadAllText(Application.StartupPath.Replace("Ninponix Office.exe", "") + "\\" + "Recovery\\Presentation.nopres").ToString() != "")
                    {
                        recovery_pane_show = true;
                        recovery_panel_animation.Start();

                        presentation_recovery.Visible = true;
                        presentation_recovery_text.Text = "Time: " + System.IO.File.GetLastWriteTime(Application.StartupPath.Replace("Ninponix Office.exe", "") + "\\" + "Recovery\\Presentation.nopres").Month.ToString() + "/" + System.IO.File.GetLastWriteTime(Application.StartupPath.Replace("Ninponix Office.exe", "") + "\\" + "Recovery\\Presentation.nopres").Day.ToString() + ": " + System.IO.File.GetLastWriteTime(Application.StartupPath.Replace("Ninponix Office.exe", "") + "\\" + "Recovery\\Presentation.nopres").ToShortTimeString();
                    }
                }
                else
                {
                    presentation_recovery.Visible = false;
                }
            }
            else
            {
                recovery_pane_show = false;
                recovery_panel_animation.Start();
            }

            //Checking for Images used in Ninponix Office

            string[] imagearray = { shader1, normaltextfileshader, richtextfileshader, presentationshader, spreadsheetshader, codeshader, nvlshader, maximizeiconshader, minimizeiconshader, normaliconshader, nofficeicon };

            foreach (var item in imagearray)
            {
                if (System.IO.File.Exists(item) == false)
                {
                    Message msg1 = new Message("Ninponix Office 2017", "An important file has been missing from your computer. Please reinstall Ninponix Office 2017.", MessageIcon.MessageIconType.Error, MessageIcon.MessageMode.Normal);
                    msg1.ShowDialog();
                    Application.Exit();
                }
            }

            //Checks for Templates
            //NVL Visual Document Templates

            string TemplatesPath = Application.StartupPath.Replace("Ninponix Office.exe", "") + "\\" + "OfficeData\\Templates\\NVL\\Documents\\";
            string[] template_list = { TemplatesPath + "Letter.nvldoc", TemplatesPath + "Report.nvldoc", TemplatesPath + "Resume.nvldoc" };

            foreach (var templates in template_list)
            {
                if (System.IO.File.Exists(templates) == false)
                {
                    Message msg1 = new Message("Ninponix Office 2017", "The Visual Document Template Store has been missing from your comptuer. Try reinstalling Ninponix Office to continue.", MessageIcon.MessageIconType.Error, MessageIcon.MessageMode.NVL);
                    msg1.ShowDialog();
                    Application.ExitThread();
                }
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Environment.GetCommandLineArgs().Count() == 1) {
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
                        timer1.Stop();
                        Application.ExitThread();
                    }
                }
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            endAnimation.Start();
            open = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
               
        public void hideBorders(bool hide) 
        {
            if (hide == true)
            {
                left_panel.Visible = false;
                panel10.Visible = false;
                panel11.Visible = false;
            }
            else
            {
                left_panel.Visible = true;
                panel10.Visible = true;
                panel11.Visible = true;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Maximized == false)
            {
                Maximized = true;
                max_animation.Start();
                hideBorders(true);
                maxbutton.Image = Image.FromFile(normaliconshader);
            }
            else
            {
                Maximized = false;
                min_animation.Start();
                hideBorders(false);
                maxbutton.Image = Image.FromFile(maximizeiconshader);
            }

        }

        int count;

        private void max_animation_Tick(object sender, EventArgs e)
        {
            count++;

            switch (count)
            {
                case 1:
                    Width = screenx - 25;
                    Height = screeny - 25;
                    Location = new Point((Screen.PrimaryScreen.WorkingArea.Width / 2) - (Width / 2), (Screen.PrimaryScreen.WorkingArea.Height / 2) - ((Height) / 2));
                    break;
                case 2:
                    Width = screenx - 20;
                    Height = screeny - 20;
                    Location = new Point((Screen.PrimaryScreen.WorkingArea.Width / 2) - (Width / 2), (Screen.PrimaryScreen.WorkingArea.Height / 2) - ((Height) / 2));
                    break;
                case 3:
                    Width = screenx - 15;
                    Height = screeny - 15;
                    Location = new Point((Screen.PrimaryScreen.WorkingArea.Width / 2) - (Width / 2), (Screen.PrimaryScreen.WorkingArea.Height / 2) - ((Height) / 2));
                    break;
                case 4:
                    Width = screenx - 10;
                    Height = screeny - 10;
                    Location = new Point((Screen.PrimaryScreen.WorkingArea.Width / 2) - (Width / 2), (Screen.PrimaryScreen.WorkingArea.Height / 2) - ((Height) / 2));
                    break;
                case 5:
                    Width = screenx - 5;
                    Height = screeny - 5;
                    Location = new Point((Screen.PrimaryScreen.WorkingArea.Width / 2) - (Width / 2), (Screen.PrimaryScreen.WorkingArea.Height / 2) - ((Height) / 2));
                    break;
                case 6:
                    Width = screenx - 4;
                    Height = screeny - 4;
                    Location = new Point((Screen.PrimaryScreen.WorkingArea.Width / 2) - (Width / 2), (Screen.PrimaryScreen.WorkingArea.Height / 2) - ((Height) / 2));
                    break;
                case 7:
                    Width = screenx - 3;
                    Height = screeny - 3;
                    Location = new Point((Screen.PrimaryScreen.WorkingArea.Width / 2) - (Width / 2), (Screen.PrimaryScreen.WorkingArea.Height / 2) - ((Height) / 2));
                    break;
                case 8:
                    Width = screenx - 2;
                    Height = screeny - 2;
                    Location = new Point((Screen.PrimaryScreen.WorkingArea.Width / 2) - (Width / 2), (Screen.PrimaryScreen.WorkingArea.Height / 2) - ((Height) / 2));
                    break;
                case 9:
                    Width = screenx - 1;
                    Height = screeny - 1;
                    Location = new Point((Screen.PrimaryScreen.WorkingArea.Width / 2) - (Width / 2), ((Screen.PrimaryScreen.Bounds.Height - 34) / 2) - ((Height) / 2));
                    break;
                case 10:
                    Width = screenx;
                    Height = screeny;
                    Location = new Point((Screen.PrimaryScreen.WorkingArea.Width / 2) - (Width / 2), (Screen.PrimaryScreen.WorkingArea.Height / 2) - ((Height) / 2));
                    max_animation.Stop();
                    count = 0;
                    break;
            }    
        }
        
        private void min_animation_Tick(object sender, EventArgs e)
        {
            count++;

            switch (count)
            {
                case 1:
                    Width = thisx + 15;
                    Height = thisy + 15;
                    Location = new Point((Screen.PrimaryScreen.WorkingArea.Width / 2) - (Width / 2), (Screen.PrimaryScreen.WorkingArea.Height / 2) - ((Height) / 2));
                    break;
                case 2:
                    Width = thisx + 15;
                    Height = thisy + 15;
                    Location = new Point((Screen.PrimaryScreen.WorkingArea.Width / 2) - (Width / 2), (Screen.PrimaryScreen.WorkingArea.Height / 2) - ((Height) / 2));
                    break;
                case 3:
                    Width = thisx + 15;
                    Height = thisy + 15;
                    Location = new Point((Screen.PrimaryScreen.WorkingArea.Width / 2) - (Width / 2), (Screen.PrimaryScreen.WorkingArea.Height / 2) - ((Height) / 2));
                    break;
                case 4:
                    Width = thisx + 10;
                    Height = thisy + 10;
                    Location = new Point((Screen.PrimaryScreen.WorkingArea.Width / 2) - (Width / 2), (Screen.PrimaryScreen.WorkingArea.Height / 2) - ((Height) / 2));
                    break;
                case 5:
                    Width = thisx + 5;
                    Height = thisy + 5;
                    Location = new Point((Screen.PrimaryScreen.WorkingArea.Width / 2) - (Width / 2), (Screen.PrimaryScreen.WorkingArea.Height / 2) - ((Height) / 2));
                    break;
                case 6:
                    Width = thisx + 4;
                    Height = thisy + 4;
                    Location = new Point((Screen.PrimaryScreen.WorkingArea.Width / 2) - (Width / 2), (Screen.PrimaryScreen.WorkingArea.Height / 2) - ((Height) / 2));
                    break;
                case 7:
                    Width = thisx + 3;
                    Height = thisy + 3;
                    Location = new Point((Screen.PrimaryScreen.WorkingArea.Width / 2) - (Width / 2), (Screen.PrimaryScreen.WorkingArea.Height / 2) - ((Height) / 2));
                    break;
                case 8:
                    Width = thisx + 2;
                    Height = thisy + 2;
                    Location = new Point((Screen.PrimaryScreen.WorkingArea.Width / 2) - (Width / 2), (Screen.PrimaryScreen.WorkingArea.Height / 2) - ((Height) / 2));
                    break;
                case 9:
                    Width = thisx + 1;
                    Height = thisy + 1;
                    Location = new Point((Screen.PrimaryScreen.WorkingArea.Width / 2) - (Width / 2), (Screen.PrimaryScreen.WorkingArea.Height / 2) - ((Height) / 2));
                    break;
                case 10:
                    Width = thisx;
                    Height = thisy;
                    Location = new Point((Screen.PrimaryScreen.WorkingArea.Width / 2) - (Width / 2), (Screen.PrimaryScreen.WorkingArea.Height / 2) - ((Height) / 2));
                    min_animation.Stop();
                    count = 0;
                    break;


            }
        }

        int counttt;

        private void endAnimation_Tick(object sender, EventArgs e)
        {
            counttt++;

            switch (counttt)
            {
                case 3:
                    Width = Width - 5;
                    Height = Height - 5;
                    Location = new Point((Screen.PrimaryScreen.WorkingArea.Width / 2) - (Width / 2), (Screen.PrimaryScreen.WorkingArea.Height / 2) - ((Height) / 2));
                    break;
                case 4:
                    Width = Width - 4;
                    Height = Height - 4;
                    Location = new Point((Screen.PrimaryScreen.WorkingArea.Width / 2) - (Width / 2), (Screen.PrimaryScreen.WorkingArea.Height / 2) - ((Height) / 2));
                    break;
                case 5:
                    Width = Width - 3;
                    Height = Height - 3;
                    Location = new Point((Screen.PrimaryScreen.WorkingArea.Width / 2) - (Width / 2), (Screen.PrimaryScreen.WorkingArea.Height / 2) - ((Height) / 2));
                    break;
                case 6:
                    Width = Width - 2;
                    Height = Height - 2;
                    Location = new Point((Screen.PrimaryScreen.WorkingArea.Width / 2) - (Width / 2), (Screen.PrimaryScreen.WorkingArea.Height / 2) - ((Height) / 2));
                    break;
                case 7:
                    Width = Width - 1;
                    Height = Height - 1;
                    Location = new Point((Screen.PrimaryScreen.WorkingArea.Width / 2) - (Width / 2), (Screen.PrimaryScreen.WorkingArea.Height / 2) - ((Height) / 2));
                    break;
                case 8:
                    Width = Width;
                    Height = Height;
                    Location = new Point((Screen.PrimaryScreen.WorkingArea.Width / 2) - (Width / 2), (Screen.PrimaryScreen.WorkingArea.Height / 2) - ((Height) / 2));
                    counttt = 0;
                    endAnimation.Stop();
                    break;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            open = false;
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            description_txt.Text = "Creates a new Flat/Plain Text Document.";
        }

        private void panel4_MouseMove(object sender, MouseEventArgs e)
        {
            description_txt.Text = "Creates a new Visual Document powered with the Ninponix Presentation Foundation and NVL.";
        }

        private void panel5_MouseMove(object sender, MouseEventArgs e)
        {
            description_txt.Text = "Creates a new Presentation powered by NPF (Ninponix Presentation Foundation).";
        }

        private void panel6_MouseMove(object sender, MouseEventArgs e)
        {
            description_txt.Text = "Creates a new Spreadsheet powered by NPF (Ninponix Presentation Foundation).";
        }

        private void panel7_MouseMove(object sender, MouseEventArgs e)
        {
            description_txt.Text = "Creates a new Hyper Text Markup Language File with the NLPP (Ninponix Live Preview Protocol).";
        }

        private void panel8_MouseMove(object sender, MouseEventArgs e)
        {
            description_txt.Text = "Creates a new NVL (Ninponix Visual Language) Code file powered by NLPP (Ninponix Live Preview Protocol).";
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            description_txt.Text = "Hover on a Template to See Descriptions of them.";
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            description_txt.Text = "Hover on a Template to See Descriptions of them.";
            menu_timer2.Start();
           
        }

        int countttt = 0;
        int cury;

        private void mize_animation_Tick(object sender, EventArgs e)
        {
            countttt++;
            
            switch (countttt)
            {
                case 1:
                    Location = new Point(Location.X, cury + 1);
                    break;
                case 2:
                    Location = new Point(Location.X, cury + 2);
                    Opacity = 0.8;
                    break;
                case 3:
                    Location = new Point(Location.X, cury + 5);
                    Opacity = 0.6;
                    break;
                case 4:
                    Location = new Point(Location.X, cury + 10);
                    Opacity = 0.4;
                    break;
                case 5:
                    Location = new Point(Location.X, cury + 20);
                    Opacity = 0.2;
                    break;
                case 6:
                    Location = new Point(Location.X, cury);
                    Opacity = 0;
                    WindowState = FormWindowState.Minimized;
                    countttt = 0;
                    mize_animation.Stop();
                    break;

            }

            
        }

        private void min_button_Click(object sender, EventArgs e)
        {
            mize_animation.Start();
            cury = Location.Y;
        }

        int count12 = 0;

        private void menu_timer_Tick(object sender, EventArgs e)
        {
            count12++;
            switch (count12)
            {
                case 0:
                    dragpanel.Height = 0;
                    dragpanel.Visible = true;
                    break;
                case 1:
                    dragpanel.Height = 50;
                    break;
                case 2:
                    dragpanel.Height = 100;
                    break;
                case 3:
                    dragpanel.Height = 150;
                    break;
                case 4:
                    dragpanel.Height = 175;
                    break;
                case 5:
                    dragpanel.Height = 185;
                    break;
                case 6:
                    dragpanel.Height = 190;
                    break;
                case 7:
                    dragpanel.Height = 195;
                    break;
                case 8:
                    dragpanel.Height = 197;
                    break;
                case 9:
                    dragpanel.Height = 199;
                    break;
                case 10:
                    dragpanel.Height = 200;
                    menu_timer.Stop();
                    count12 = 0;
                    break;
            }
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragpanel.Height != 200)
            {
                menu_timer.Enabled = true;
                recovery_pane_show = false;
                recovery_panel_animation.Start();
            }
           
            dragpanel.Visible = true;
        }

        int count13;
        private void menu_timer2_Tick(object sender, EventArgs e)
        {
            count13++;
            switch (count13)
            {
                case 10:
                    dragpanel.Height = 0;
                    dragpanel.Visible = false;
                    menu_timer2.Stop();
                    count13 = 0;
                    break;
                case 9:
                    dragpanel.Height = 50;
                    break;
                case 8:
                    dragpanel.Height = 100;
                    break;
                case 7:
                    dragpanel.Height = 150;
                    break;
                case 6:
                    dragpanel.Height = 175;
                    break;
                case 5:
                    dragpanel.Height = 185;
                    break;
                case 4:
                    dragpanel.Height = 190;
                    break;
                case 3:
                    dragpanel.Height = 195;
                    break;
                case 2:
                    dragpanel.Height = 197;
                    break;
                case 1:
                    dragpanel.Height = 199;
                    break;
                case 0:
                    dragpanel.Height = 200;
                    break;
            }
        }

        txtDocument newtxt = new txtDocument();

        private void panel3_MouseClick(object sender, MouseEventArgs e)
        {
            Properties.Settings.Default.TextDocumentsThreadCount = 0;
            newtxt.Opacity = 0;
            newtxt.Show();
            Hide();
            Log.WriteEntry("Created a new Plain Text Document", "TEXT EDITOR");
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.TextDocumentsThreadCount = 0;
            newtxt.Opacity = 0;
            newtxt.Show();
            Hide();
            Log.WriteEntry("Created a new Plain Text Document", "TEXT EDITOR");
        }

        private void template_1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.TextDocumentsThreadCount = 0;
            newtxt.Opacity = 0;
            newtxt.Show();
            Hide();
            Log.WriteEntry("Created a new Plain Text Document", "TEXT EDITOR");
        }

        int beforex, beforey, afterx, aftery;

        public bool recovery_pane_show = false;
        int recovery_count = 0;

        private void pane_close_btn_Click(object sender, EventArgs e)
        {
            recovery_pane_show = false;
            recovery_panel_animation.Start();
        }

        private void recovery_btn_Click(object sender, EventArgs e)
        {
            if (recovery_pane_show == false)
            {
                recovery_pane_show = true;
                recovery_panel_animation.Start();
                menu_timer2.Enabled = true;
            }
            else
            {
                recovery_pane_show = false;
                recovery_panel_animation.Start();
                menu_timer2.Start();
            }
        }

        public void text_document_recovery_load()
        {
            if (System.IO.File.Exists(Application.StartupPath.Replace("Ninponix Office.exe", "") + "\\" + "Recovery\\TextDocument.txt") == true ) {
                txtDocument myform = new txtDocument();

                using (System.IO.StreamReader sr = new System.IO.StreamReader(Application.StartupPath.Replace("Ninponix Office.exe", "") + "\\" + "Recovery\\TextDocument.txt"))
                {
                    string temptext;
                    temptext = sr.ReadToEnd();
                    myform.textBox1.Text = temptext;
                    myform.doctitle = "New Text Document";
                    myform.docloc = "";
                    myform.tempString = "";
                }

                Properties.Settings.Default.TextDocumentsThreadCount = 0;
                myform.Opacity = 0;
                myform.Show();
                Hide();
            }
        }

        private void text_document_recovery_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                text_document_recovery_load();
                recovery_pane_show = false;
                recovery_panel_animation.Start();
                Log.WriteEntry("Loaded Recovery Text Document", "OFFICE");
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            foreach (var files in System.IO.Directory.GetFiles(Application.StartupPath.Replace("Ninponix Office.exe", "") + "\\" + "Recovery\\"))
            {
                try
                {
                    System.IO.File.Delete(files);
                    Log.WriteEntry("Deleted Recovery Files: " + files.ToString(), "OFFICE");
                    recovery_pane_show = false;
                    recovery_panel_animation.Start();
                }
                catch (Exception)
                {
                    Log.WriteEntry("Unabled to delete Recovery Files: " + files.ToString(), "OFFICE");
                }
            }
        }

        private void panel4_MouseClick(object sender, MouseEventArgs e)
        {
            VisualDocument docfrm = new VisualDocument();
            Hide();
            docfrm.Show();
            Log.WriteEntry("Started a new Visual Document Project", "OFFICE");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog opener = new OpenFileDialog();
            opener.Title = "Open File...";
            opener.Filter = "All Supported Files|*.txt;*.nvldoc;*.nvlexp;*.nopres;*.nvl|Text Files|*.txt|NVL Visual Document|*.nvldoc;*.nvlexp|NVL Presentation|*.nopres|All Files|*.*";
            opener.FileName = "";
            opener.Multiselect = false;
            
            if (opener.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    System.Diagnostics.Process.Start(Application.ExecutablePath, opener.FileName);
                    endAnimation.Start();
                    open = false;
                }
                catch (Exception)
                {
                    MessageBox.Show("Could not open the Document you requested. Ninponix Office is working on it. Please retry.", "Ninponix Office 2017", MessageBoxButtons.OK, MessageBoxIcon.Warning);                   
                }
            }
        }

        private void panel5_MouseClick(object sender, MouseEventArgs e)
        {
            Presentation pre = new Presentation();
            Hide();
            pre.Show();

            Log.WriteEntry("Started a new Presentation Project", "OFFICE");
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Presentation pre = new Presentation();
            Hide();
            pre.Show();

            Log.WriteEntry("Started a new Presentation Project", "OFFICE");
        }

        private void template_3_Click(object sender, EventArgs e)
        {
            Presentation pre = new Presentation();
            Hide();
            pre.Show();

            Log.WriteEntry("Started a new Presentation Project", "OFFICE");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Options.Options op = new Options.Options();
            op.ShowDialog();
        }

        public void GetDocumentation(string KEY)
        {
            switch (KEY)
            {
                case "Presentation Platform":
                    MessageBox.Show("Warning: Ninponix Office is still not documented. This is a beta testing. Watch Ninponix Videos on Youtube for tutorials on the topics of Visual Documents (NVL) and Presentations (NVL)", "Ninponix Office 2016", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    break;
                case "Visual Document Platform":
                    MessageBox.Show("Warning: Ninponix Office is still not documented. This is a beta testing. Watch Ninponix Videos on Youtube for tutorials on the topics of Visual Documents (NVL) and Presentations (NVL)", "Ninponix Office 2016", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    break;
                case "HELP":
                    MessageBox.Show("Warning: Ninponix Office is still not documented. This is a beta testing. Watch Ninponix Videos on Youtube for tutorials on the topics of Visual Documents (NVL) and Presentations (NVL)", "Ninponix Office 2016", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    break;
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
            GetDocumentation("Presentation Platform");    
        }

        private void label13_Click(object sender, EventArgs e)
        {
            GetDocumentation("Visual Document Platform");
        }

        private void label19_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Links.GetLinkByKey("CODEX"));
        }

        private void label20_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Links.GetLinkByKey("NUMERA"));
        }

        private void button13_Click(object sender, EventArgs e)
        {
            GetDocumentation("HELP");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("mailto:c.chamandana@gmail.com");
            }
            catch (Exception)
            {
                Message msg = new Message("Ninponix Office 2017", "Ninponix Office requires a valid email application / client in order to send a feedback to Chamuth Chamandana", MessageIcon.MessageIconType.Warning, MessageIcon.MessageMode.Normal);
                msg.ShowDialog();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            endAnimation.Start();
            open = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            About a = new About();
            a.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Options.Options op = new Options.Options();
            op.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Options.Options op = new Options.Options();
            op.tabControl1.SelectedIndex = 1;
            op.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Options.Options op = new Options.Options();
            op.tabControl1.SelectedIndex = 2;
            op.ShowDialog();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            MessageBox.Show("External Tools are Disabled in Ninponix Office 2017 for some security reasons.", "Ninponix Office 2017", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void recovery_panel_animation_Tick(object sender, EventArgs e)
        {
            
            if (System.IO.File.Exists(Application.StartupPath.Replace("Ninponix Office.exe", "") + "\\" + "Recovery\\TextDocument.txt") == true)
            {
                text_document_recovery.Visible = true;
            }
            else
            {
                text_document_recovery.Visible = false;
            }

            if (System.IO.File.Exists(Application.StartupPath.Replace("Ninponix Office.exe", "") + "\\" + "Recovery\\VisualDocument.nvldoc") == true)
            {
                vd_recovery.Visible = true;
            }
            else
            {
                vd_recovery.Visible = false;
            }

            if (System.IO.File.Exists(Application.StartupPath.Replace("Ninponix Office.exe", "") + "\\" + "Recovery\\Presentation.nopres") == true)
            {
                presentation_recovery.Visible = true;
            }
            else
            {
               presentation_recovery.Visible = false;
            }

            if (recovery_pane_show == true)
            {
                recovery_count++;

                switch (recovery_count)
                {
                    case 1:
                        recovery_pane.Visible = true;
                        recovery_pane.Width = 0;
                        break;
                    case 2:
                        recovery_pane.Width = 100;
                        break;
                    case 3:
                        recovery_pane.Width = 200;
                        break;
                    case 4:
                        recovery_pane.Width = 230;
                        break;
                    case 5:
                        recovery_pane.Width = 245;
                        break;
                    case 6:
                        recovery_pane.Width = 246;
                        break;
                    case 7:
                        recovery_pane.Width = 247;
                        break;
                    case 8:
                        recovery_pane.Width = 248;
                        break;
                    case 9:
                        recovery_pane.Width = 249;
                        break;
                    case 10:
                        recovery_pane.Width = 250;
                        recovery_panel_animation.Stop();
                        recovery_count = 0;
                        break;
                }
            }
            else
            {
                recovery_count++;

                switch (recovery_count)
                {
                    case 1:
                        recovery_pane.Width = 249;
                        break;
                    case 2:
                        recovery_pane.Width = 248;
                        break;
                    case 3:
                        recovery_pane.Width = 247;
                        break;
                    case 4:
                        recovery_pane.Width = 246;
                        break;
                    case 5:
                        recovery_pane.Width = 245;
                        break;
                    case 6:
                        recovery_pane.Width = 240;
                        break;
                    case 7:
                        recovery_pane.Width = 230;
                        break;
                    case 8:
                        recovery_pane.Width = 200;
                        break;
                    case 9:
                        recovery_pane.Width = 100;
                        break;
                    case 10:
                        recovery_pane.Width = 0;
                        recovery_pane.Visible = false;
                        recovery_panel_animation.Stop();
                        recovery_count = 0;
                        break;
                }
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (Size.Equals(new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height)) == false)
                {
                    hideBorders(false);

                    afterx = e.X;
                    aftery = e.Y;

                    Location = new Point(Location.X + (afterx - beforex), Location.Y + (aftery - beforey));
                }
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            beforex = e.X;
            beforey = e.Y;
        }
    }
}