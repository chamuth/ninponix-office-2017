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
    public partial class txtDocument : Form
    {

        string shader1 = Application.StartupPath.Replace("Ninponix Office.exe", "") + "\\" + "OfficeData\\ImageRaw\\shader_1.nofficeraw";
        string nofficeicon = Application.StartupPath.Replace("Ninponix Office.exe", "") + "\\" + "OfficeData\\ImageRaw\\shader_window_icon.nofficeimageraw";
        string normaltextfileshader = Application.StartupPath.Replace("Ninponix Office.exe", "") + "\\" + "OfficeData\\ImageRaw\\shader_normal_textfile.nofficeimageraw";
        string richtextfileshader = Application.StartupPath.Replace("Ninponix Office.exe", "") + "\\" + "OfficeData\\ImageRaw\\shader_rich_textfile.nofficeimageraw";
        string presentationshader = Application.StartupPath.Replace("Ninponix Office.exe", "") + "\\" + "OfficeData\\ImageRaw\\shader_presentation.nofficeimageraw";
        string spreadsheetshader = Application.StartupPath.Replace("Ninponix Office.exe", "") + "\\" + "OfficeData\\ImageRaw\\shader_spreadsheet.nofficeimageraw";
        string codeshader = Application.StartupPath.Replace("Ninponix Office.exe", "") + "\\" + "OfficeData\\ImageRaw\\shader_code.nofficeimageraw";
        string nvlshader = Application.StartupPath.Replace("Ninponix Office.exe", "") + "\\" + "OfficeData\\ImageRaw\\shader_nvl_file.nofficeimageraw";
        string maximizeiconshader = Application.StartupPath.Replace("Ninponix Office.exe", "") + "\\" + "OfficeData\\ImageRaw\\NSWC\\shader_max.nofficeimageraw";
        string minimizeiconshader = Application.StartupPath.Replace("Ninponix Office.exe", "") + "\\" + "OfficeData\\ImageRaw\\NSWC\\shader_min.nofficeimageraw";
        string normaliconshader = Application.StartupPath.Replace("Ninponix Office.exe", "") + "\\" + "OfficeData\\ImageRaw\\NSWC\\shader_normal.nofficeimageraw";

        int beforex;
        int beforey;
        int afterx;
        int aftery;

        int thisx = 950;
        int thisy = 650;
        int screenx = Screen.PrimaryScreen.WorkingArea.Width;
        int screeny = Screen.PrimaryScreen.WorkingArea.Height;

        bool open = true;

        public string tempString;
        public string doctitle = "New Text Document";
        public string docloc = "";

        public txtDocument()
        {
            InitializeComponent();
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            //set the before location of the form
            beforex = e.X;
            beforey = e.Y;
        }


        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            //Resizing the Form when the mousemoves with a mouse left click
            if (Maximized == false)
            {
                if (e.Button == MouseButtons.Left)
                {
                    afterx = e.X;
                    aftery = e.Y;

                    Width = Width + (afterx - beforey);
                    Height = Height + (aftery - beforey);
                }
                panel3.Cursor = Cursors.SizeNWSE;
            }
            else
            {
                panel3.Cursor = Cursors.Default;
            }
        }
        int count;

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

        bool Maximized = false;

        private void maxbutton_Click(object sender, EventArgs e)
        {
            if (Maximized == false)
            {
                Maximized = true;
                panel3.Visible = false;
                max_animation.Start();

                maxbutton.Image = Image.FromFile(normaliconshader);
            }
            else
            {
                Maximized = false;
                panel3.Visible = true;
                min_animation.Start();

                maxbutton.Image = Image.FromFile(maximizeiconshader);
            }
        }

        private void min_button_Click(object sender, EventArgs e)
        {
            mize_animation.Start();
            cury = Location.Y;
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
                    Opacity = 1;
                    break;

            }
        }
        public string wordslist = "";
        private void txtDocument_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
            textBox1.Font = Properties.Settings.Default.textdoc_Font;
            textBox1.ForeColor = Properties.Settings.Default.textdoc_fontcolor;

            Properties.Settings.Default.TextDocumentsThreadCount++;
            Properties.Settings.Default.Save();

            textBox1.WordWrap = Properties.Settings.Default.textDocuments_WordWrap;

            autosave_timer.Interval = Properties.Settings.Default.TextDocumentAutoSaveTime * 60 * 1000;

            title.Text = doctitle.ToString();
            

            try
            {
                using (System.IO.StreamReader sr = new System.IO.StreamReader(Application.StartupPath.Replace("Ninponix Office.exe", "") + "\\" + "OfficeData\\Values\\D1.nofficedict"))
                {
                    wordslist = sr.ReadToEnd();
                    sr.Close();
                }
            }
            catch (Exception)
            {
                Message msg = new Message("Ninponix Office 2017", "The Spelling dictionary is missing from your computer. Please make sure that the Dictionary is not in use or not deleted from your computer.", MessageIcon.MessageIconType.Error, MessageIcon.MessageMode.Normal);
                msg.ShowDialog();
            }

            textBox1.Focus();
            textBox1.Select();
        }

        bool asked = false;

        private void button1_Click(object sender, EventArgs e)
        {
            if (tempString != textBox1.Text)
            {
                if (MessageBox.Show("Do you want to discard the changes?", "Ninponix Office", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    asked = true;
                    Properties.Settings.Default.TextDocumentsThreadCount--;
                    open = false;
                    if (Properties.Settings.Default.TextDocumentsThreadCount == 0)
                    {
                        string Arg = "";
                        int counter = 0;
                        foreach (var line in Environment.GetCommandLineArgs())
                        {
                            counter++;
                            if (counter != 1)
                            {
                                Arg += line;
                            }
                        }

                        if (Arg.EndsWith(".txt") == false)
                        {
                            Form1 frm = new Form1();
                            frm.Opacity = 0;
                            frm.Show();
                            frm.recovery_pane_show = false;
                            frm.recovery_panel_animation.Start();
                        }
                        else
                        {
                            //Application.ExitThread();
                        }


                    }

                    try
                    {
                        System.IO.File.Delete(Application.ExecutablePath.Replace("Ninponix Office.exe", "") + "Recovery\\TextDocument.txt");
                    }
                    catch (Exception)
                    {
                        Message error = new Message("Ninponix Office: Auto Save", "Cannot clear Auto Save files and information. Make sure the Recovery files are not in use.", MessageIcon.MessageIconType.Error, MessageIcon.MessageMode.Normal);
                    }
                }
            }
            else
            {
                open = false;
                Properties.Settings.Default.TextDocumentsThreadCount--;
                if (Properties.Settings.Default.TextDocumentsThreadCount == 0)
                {
                    //Form1 frm = new Form1();
                    //frm.Opacity = 0;
                    //frm.Show();
                    //frm.recovery_pane_show = false;

                    string Arg = "";
                    int counter = 0;
                    foreach (var line in Environment.GetCommandLineArgs())
                    {
                        counter++;
                        if (counter != 1)
                        {
                            Arg += line;
                        }
                    }

                    if (Arg.EndsWith(".txt") == false)
                    {
                        Form1 frm = new Form1();
                        frm.Opacity = 0;
                        frm.Show();
                        frm.recovery_pane_show = false;
                        frm.recovery_panel_animation.Start();
                    }
                    else
                    {
                        //Application.ExitThread();
                    }

                }

                try
                {
                    System.IO.File.Delete(Application.StartupPath.Replace("Ninponix Office.exe", "") + "\\" + "Recovery\\TextDocument.txt");
                }
                catch (Exception)
                {
                    Message error = new Message("Ninponix Office: Auto Save", "Cannot clear Auto Save files and information. Make sure the Recovery files are not in use.", MessageIcon.MessageIconType.Error, MessageIcon.MessageMode.Normal);
                }
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
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
                    Close();
                }
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                aftermousex = e.X;
                aftermousey = e.Y;

                Location = new Point(Location.X + (aftermousex - beforemousex), Location.Y + (aftermousey - beforemousey));

            }
        }

        int beforemousex;
        int beforemousey;
        int aftermousex;
        int aftermousey;

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            beforemousex = e.X;
            beforemousey = e.Y;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != tempString)
            {
                title.Text = doctitle + "*";
            }
            else
            {
                title.Text = doctitle;
            }

            lines_count.Text = textBox1.Lines.Count().ToString() + " Line(s)";
            char_count.Text = textBox1.Text.Count().ToString() + " Character(s)";

            int count = 0;

            foreach (var lines in textBox1.Lines)
            {
                //Theory 433: Finding the no. of words of an string
                if (lines.Replace(" ", "").Count() != 0)
                {
                    if (lines.EndsWith(" "))
                    {
                        count += (lines.Split(' ').Count() - 1);
                    }
                    else if (lines.EndsWith("\r"))
                    {
                        count += (lines.Split(' ').Count() - 1);
                    }
                    else
                    {
                        count += lines.Split(' ').Count();
                    }
                }
            }

            //Set the count of words into the label.
            word_count.Text = count + " Word(s)";

            if (schecked == true)
            {
                int start = textBox1.SelectionStart;
                textBox1.Font = Properties.Settings.Default.textdoc_Font;

                textBox1.SelectAll();
                textBox1.SelectionColor = Properties.Settings.Default.textdoc_fontcolor;
                textBox1.SelectionFont = Properties.Settings.Default.textdoc_Font;
                schecked = false;
                textBox1.Select(start, 0);
            }
        }

        bool schecked = false;

        private void txtDocument_FormClosing(object sender, FormClosingEventArgs e)
        {
            string Arg = "";
            int counter = 0;
            foreach (var line in Environment.GetCommandLineArgs())
            {
                counter++;
                if (counter != 1)
                {
                    Arg += line;
                }
            }

            if (asked == false)
            {
                if (MessageBox.Show("Do you want to discard the changes?", "Ninponix Office", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {


                    if (Arg.EndsWith(".txt") == false)
                    {
                    }
                    else
                    {
                        Application.ExitThread();
                        Close();
                    }
                }
                else
                {

                }
            }
            else
            {
                if (Arg.EndsWith(".txt") == true)
                {
                    Application.ExitThread();
                }
            }
        }


        bool menuopen = false;
        int speed = 10;

        private void menu_animation_Tick(object sender, EventArgs e)
        {
            if (menuopen == true)
            {
                if (menu_pane.Width < 200)
                {
                    menu_pane.Width += speed;
                    if (speed > 5)
                    {
                        speed -= 1;
                    }

                } else
                {
                    speed = 20;

                }
            }
            else
            {
                if (menu_pane.Width != 0)
                {
                    menu_pane.Width -= speed;
                    if (speed > 5)
                    {
                        speed -= 1;
                    }
                }
                else
                {

                    speed = 20;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (menuopen == true)
            {
                menuopen = false;
            }
            else
            {
                menuopen = true;
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (Ninponix_Office.Properties.Settings.Default.TEXT_DOCUMENT_SHORTCUTS_ENABLED)
            {
                if (e.KeyCode == Keys.Menu)
                {   //MENU BTN / ALTERNATIVE BUTTON (ALT) = MENU OPEN
                    menuopen = true;
                }

                if (e.Alt == true)
                { //Alternatives
                    if (e.KeyCode == Keys.M)
                    {   //ALT + M = MAXIMIZE / NORMAL TOGGLE
                        maxbutton_Click("Sender1", new EventArgs());
                    }
                    if (e.KeyCode == Keys.N)
                    {   //ALT + N = MINIMIZE TOGGLE
                        min_button_Click("Sender1", new EventArgs());
                    }
                }

                if (e.KeyCode == Keys.F1)
                {   //F1 = OFFICE HELP
                    button17_Click("Sender1", new EventArgs());
                }

                if (e.KeyCode == Keys.F2)
                {   //F2 = FEEDBACK TO NINPONIX
                    button19_Click("Sender1", new EventArgs());
                }

                if (e.Control == true)
                {//Shortcut mode enabled in the TextDocumentEditor
                    if (e.KeyCode == Keys.S)
                    {
                        if (e.Shift == true)
                        {   //CTRL + SHIFT + S = SAVE AS
                            button6_Click("Sender1", new EventArgs());
                        }
                        else
                        {   //CTRL + S = SAVE FILE
                            button5_Click("Sender1", new EventArgs());
                        }
                    }

                    if (e.KeyCode == Keys.W)
                    {
                        if (e.Shift == true)
                        {   //CTRL + SHIFT + W = TOGGLE WORD WRAP DOCUMENT
                            checkBox1.Checked = !checkBox1.Checked;
                        }
                    }

                    if (e.KeyCode == Keys.F)
                    {
                        if (e.Shift == true)
                        {   //CTRL + SHIFT + F = CHANGE FONT
                            button16_Click("Sender1", new EventArgs());
                        }
                        else
                        {   //CTRL + F = FIND
                            button14_Click("Sender1", new EventArgs());
                        }
                    }

                    if (e.KeyCode == Keys.C)
                    {
                        if (e.Shift == true)
                        {   //CTRL + SHIFT + C = CHANGE FONT COLOR
                            button11_Click_1("Sender1", new EventArgs());
                        }
                    }

                    if (e.KeyCode == Keys.Q)
                    {   // Spelling Check shortcut is CTRL + Q
                        CheckSpellings("Sender1", new EventArgs());
                        label2.Text = "Spellings Checked";
                    }

                    if (e.KeyCode == Keys.N)
                    {
                        if (e.Shift == true)
                        {   //CTRL + SHIFT + N = NEW DOCUMENT (SEPERATE)
                            button21_Click("Sender1", new EventArgs());
                        }
                        else
                        {   //CTRL + N = NEW DOCUMENT (SAME DOCUMENT)
                            button20_Click("Sender1", new EventArgs());
                        }
                    }

                    if (e.KeyCode == Keys.O)
                    {
                        if (e.Shift == false)
                        {   //CTRL + O = OPEN FILE
                            button4_Click("Sender1", new EventArgs());
                        }
                        else
                        {   //CTRL + SHIFT + O = OPEN THE DIRECTORY OF THE FILE
                            if (docloc == "" | System.IO.File.Exists(docloc) == false)
                            {//File does not exists
                                Message msg = new Message("Ninponix Office 2017", "Please save the file before trying to open the project directory.", MessageIcon.MessageIconType.Warning, MessageIcon.MessageMode.Normal);
                                msg.ShowDialog();
                            }
                            else
                            {
                                try
                                {
                                    string[] splits = docloc.Split('\\');
                                    string filename = splits[splits.Length - 1];
                                    int length = filename.Length;
                                    string directoryname = docloc.Remove(docloc.Length - length, length);

                                    System.Diagnostics.Process.Start("explorer.exe", directoryname);
                                }
                                catch (Exception)
                                {

                                }
                            }
                        }
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (new_pane_show == false)
            {
                new_pane_show = true;
                new_animation.Start();
            }
            else
            {
                new_pane_show = false;
                new_animation.Start();
            }
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            menuopen = false;
            new_pane_show = false;
            new_animation.Start();


            int start = textBox1.SelectionStart;
            textBox1.SelectAll();
            textBox1.SelectionFont = Properties.Settings.Default.textdoc_Font;
            textBox1.SelectionColor = Properties.Settings.Default.textdoc_fontcolor;
            textBox1.Select(start, 0);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to discard the document?", "Ninponix Office", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Title = "Please select a document";
                open.Filter = "Text Document|*.txt|All Files|*.*";
                open.FileName = "";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    docloc = open.FileName;
                    int expands = open.FileName.Split('\\').Count();

                    doctitle = open.FileName.Split('\\')[expands - 1];
                    title.Text = doctitle;

                    try
                    {
                        using (System.IO.StreamReader sr = new System.IO.StreamReader(docloc))
                        {
                            textBox1.Text = sr.ReadToEnd();
                            tempString = sr.ReadToEnd();
                            if (tempString == textBox1.Text)
                            {
                                title.Text = doctitle;
                            }

                            label2.Text = "Opened File Successfully.";
                        }

                    } catch (Exception ex)
                    {

                    }
                } else
                {
                    title.Text = doctitle;
                }

            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (docloc != "")
            {
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(docloc))
                {
                    sw.Write(textBox1.Text);
                    label2.Text = "Successfully Saved!";
                    sw.Flush();
                    sw.Close();
                }
            }
            else
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Title = "Please Save the document";
                save.Filter = "Text Document|*.txt|All Files|*.*";
                save.FileName = "";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    docloc = save.FileName;
                    using (System.IO.StreamWriter sw = new System.IO.StreamWriter(docloc))
                    {
                        sw.Write(textBox1.Text);
                        label2.Text = "Successfully Saved!";
                        menuopen = false;
                    }
                    int expands = save.FileName.Split('\\').Count();

                    doctitle = save.FileName.Split('\\')[expands - 1];
                    title.Text = doctitle;

                    System.IO.FileInfo f = new System.IO.FileInfo(save.FileName.ToString());

                    fileSystemWatcher1.Path = f.DirectoryName.ToString();
                }
                else
                {
                    title.Text = doctitle;
                }

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Please Save the document";
            save.Filter = "Text Document|*.txt|All Files|*.*";
            save.FileName = "";
            if (save.ShowDialog() == DialogResult.OK)
            {
                docloc = save.FileName;
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(docloc))
                {
                    sw.Write(textBox1.Text);
                    label2.Text = "Successfully Saved!";
                    menuopen = false;
                }

                int expands = save.FileName.Split('\\').Count();

                doctitle = save.FileName.Split('\\')[expands - 1];
                title.Text = doctitle;
            }
            else
            {
                title.Text = doctitle;
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Print Command needed here!
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Undo();
            label2.Text = "Undo Changes.";
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
            label2.Text = "Cut Text";
            menuopen = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
            label2.Text = "Copied Text";
            menuopen = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
            label2.Text = "Pasted Text";
            menuopen = false;
        }

        string findText;

        private void button14_Click(object sender, EventArgs e)
        {
            Find findform = new Find();
            findform.ShowDialog();


            findText = findform.query_txt.Text;
            int start = textBox1.SelectionStart;


            int chars = 0;
            string nowtext = "";
            foreach (var t in textBox1.Text)
            {
                chars++;
                if (t == ' ' | t == '\n')
                {
                    nowtext = "";
                }
                else
                {
                    nowtext += t;
                    if (nowtext == findText)
                    {
                        textBox1.Select(chars - nowtext.Count(), nowtext.Count());
                        textBox1.SelectionColor = Color.DeepSkyBlue;
                    }
                }


            }
        } 

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox1.WordWrap == true)
            {
                textBox1.WordWrap = false;
                Properties.Settings.Default.textDocuments_WordWrap = false;
                label2.Text = "Disabled Word Wrap";
                checkBox1.Text = "Word Wrap (disabled)";
                textBox1.WordWrap = false;
            }
            else
            {
                textBox1.WordWrap = true;
                Properties.Settings.Default.textDocuments_WordWrap = true;
                label2.Text = "Enabled Word Wrap";
                checkBox1.Text = "Word Wrap (enabled)";
                textBox1.WordWrap = true;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();
            font.Font = Properties.Settings.Default.textdoc_Font;
            if (font.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.textdoc_Font = font.Font;
                textBox1.Font = Properties.Settings.Default.textdoc_Font;
                Properties.Settings.Default.Save();
            }
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            ColorDialog col = new ColorDialog();
            col.Color = Properties.Settings.Default.textdoc_fontcolor;
            col.SolidColorOnly = false;
            col.FullOpen = true;
            
            if (col.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.textdoc_fontcolor = col.Color;
                textBox1.ForeColor = Properties.Settings.Default.textdoc_fontcolor;
                Properties.Settings.Default.Save();
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("help\\office_docs\\index.html");
            }
            catch (Exception)
            {
                Message msg1 = new Message("Ninponix Office: Documentation Error", "The Ninponix Office Documentation has been removed from your computer. Please reinstall the product and try again", MessageIcon.MessageIconType.Error, MessageIcon.MessageMode.Normal);
                msg1.ShowDialog();
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("http://www.facebook.com/ninponixoffice");
            }
            catch (Exception)
            {
                Message msg2 = new Message("Ninponix Office", "Cannot send the HTTP request. Please make sure your web browser integrations are ready or working correctly for \"HTTP://\"", MessageIcon.MessageIconType.Error, MessageIcon.MessageMode.Normal);
                msg2.ShowDialog();
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:fbackninponix@gmail.com");
        }

        int new_count;
        bool new_pane_show;

        private void new_animation_Tick(object sender, EventArgs e)
        {
            if (new_pane_show == true)
            {
                new_count++;

                switch (new_count)
                {
                    case 1:
                        new_pane.Visible = true;
                        new_pane.Height = 0;
                        break;
                    case 2:
                        new_pane.Height = 20;
                        break;
                    case 3:
                        new_pane.Height = 30;
                        break;
                    case 4:
                        new_pane.Height = 35;
                        break;
                    case 5:
                        new_pane.Height = 40;
                        break;
                    case 6:
                        new_pane.Height = 41;
                        break;
                    case 7:
                        new_pane.Height = 42;
                        break;
                    case 8:
                        new_pane.Height = 43;
                        break;
                    case 9:
                        new_pane.Height = 44;
                        break;
                    case 10:
                        new_pane.Height = 45;
                        new_count = 0;
                        new_animation.Stop();
                        break;
                }
            }
            else
            {
                new_count++;

                switch (new_count)
                {
                    case 1:
                        new_pane.Height = 45;
                        break;
                    case 2:
                        new_pane.Height = 44;
                        break;
                    case 3:
                        new_pane.Height = 43;
                        break;
                    case 4:
                        new_pane.Height = 42;
                        break;
                    case 5:
                        new_pane.Height = 41;
                        break;
                    case 6:
                        new_pane.Height = 40;
                        break;
                    case 7:
                        new_pane.Height = 35;
                        break;
                    case 8:
                        new_pane.Height = 30;
                        break;
                    case 9:
                        new_pane.Height = 20;
                        break;
                    case 10:
                        new_pane.Height = 10;
                        break;
                    case 11:
                        new_pane.Height = 0;
                        new_pane.Visible = false;
                        new_animation.Stop();
                        new_count = 0;
                        break;
                }
            }
            
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != tempString)
            {
                if (MessageBox.Show("Do you want to discard the Document?", "Ninponix Office", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    textBox1.Text = null;
                    tempString = null;
                    label2.Text = "Created new document";
                    doctitle = "New Text Document";
                    title.Text = doctitle;
                }
                new_pane_show = false;
                new_animation.Start();
                menuopen = false;
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            txtDocument myform = new txtDocument();
            myform.Show();
            new_pane_show = false;
            new_animation.Start();
            menuopen = false;
        }

        private void menu_pane_MouseClick(object sender, MouseEventArgs e)
        {
            new_pane_show = false;
            new_animation.Start();
        }

        public void AutoSave()
        {
            try
            {
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(Application.StartupPath.Replace("Ninponix Office.exe", "") + "\\" + "Recovery\\TextDocument.txt"))
                {
                    sw.Write(textBox1.Text);
                }

                label2.Text = "Auto Saved your document";
            }
            catch (Exception)
            {
                Message error = new Message("Ninponix Office: Auto Save", "Ninponix Office has failed saving your text document automatically. Please make sure the Recovery Path is correct and not in use", MessageIcon.MessageIconType.Error, MessageIcon.MessageMode.Normal);
                error.ShowDialog();
         
                label2.Text = "Failed Auto Saving";
            }
        }

        private void autosave_timer_Tick(object sender, EventArgs e)
        {
            AutoSave();
        }

        private void txtDocument_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (tempString != textBox1.Text)
            {
            //    if (MessageBox.Show("Do you want to discard the changes?", "Ninponix Office", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //    {
            //        Properties.Settings.Default.TextDocumentsThreadCount--;
            //        open = false;
            //        if (Properties.Settings.Default.TextDocumentsThreadCount == 0)
            //        {
            //            Form1 frm = new Form1();
            //            frm.Opacity = 0;
            //            frm.Show();
            //            frm.recovery_pane_show = false;
            //        }

            //        try
            //        {
            //            System.IO.File.Delete("Recovery\\TextDocument.txt");
            //        }
            //        catch (Exception)
            //        {
            //            Message error = new Message("Ninponix Office: Auto Save", "Cannot clear Auto Save files and information. Make sure the Recovery files are not in use.", MessageIcon.MessageIconType.Error);
            //        }
            //    }
            //    else
            //    {
            //        e.Cancel = true;
            //    }
            //}
            //else
            //{
            //    open = false;
            //    Properties.Settings.Default.TextDocumentsThreadCount--;
            //    if (Properties.Settings.Default.TextDocumentsThreadCount == 0)
            //    {
            //        Form1 frm = new Form1();
            //        frm.Opacity = 0;
            //        frm.Show();
            //        frm.recovery_pane_show = false;
            //    }

            //    try
            //    {
            //        System.IO.File.Delete("Recovery\\TextDocument.txt");
            //    }
            //    catch (Exception)
            //    {
            //        Message error = new Message("Ninponix Office: Auto Save", "Cannot clear Auto Save files and information. Make sure the Recovery files are not in use.", MessageIcon.MessageIconType.Error);
            //    }
            }

        }

        private void fileSystemWatcher1_Deleted(object sender, System.IO.FileSystemEventArgs e)
        {
            if (e.FullPath == docloc.ToString())
            {
                if ( MessageBox.Show("The file \""+ docloc.ToString() + "\" has been deleted from your computer. Do you want to save it again?","Ninponix Office",MessageBoxButtons.YesNo,MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    using (System.IO.StreamWriter sw = new System.IO.StreamWriter(docloc))
                    {
                        sw.Write(textBox1.Text);
                        label2.Text = "Successfully Saved to: " + docloc.ToString();
                    }
                }
            }
        }

        private void CheckSpellings(object sender, EventArgs e)
        {
            //Start Checking for spelling
            int line_c = 0;
            int wrong_count = 0;
            foreach (var line in textBox1.Lines)
            {
                line_c++;
                int word_count = 0;
                foreach (var word in line.Split(' '))
                {
                    word_count++;
                    bool wrong = false;

                    if (word.Contains("0") | word.Contains("1") | word.Contains("2") | word.Contains("3") | word.Contains("4") | word.Contains("5") | word.Contains("6") | word.Contains("7") | word.Contains("8") | word.Contains("9") | word.Contains("!") | word.Contains("@") | word.Contains("#") | word.Contains("$") | word.Contains("%") | word.Contains("^") | word.Contains("&") | word.Contains("*") | word == "("  | word == ")")
                    {
                        wrong = false;
                    }
                    else { 
                        foreach (var wordd in wordslist.Split(','))
                        {
                            if (wordd.ToLower() != word.ToLower().Replace("(","").Replace(")",""))
                            {
                                wrong_count++;
                                wrong = true;
                            }
                            else
                            {
                                wrong = false;
                                break;
                            }
                        }

                        int start = textBox1.SelectionStart;

                        if (wrong == true)
                        {

                            int lettercount = 0;
                            string theword = "";
                            foreach (var letters in textBox1.Text)
                            {
                                lettercount++;
                                if (letters == ' ' | letters == '\n')
                                {

                                    if (theword == word)
                                    {
                                        textBox1.Select(lettercount - theword.Count() - 1, theword.Count());
                                        textBox1.SelectionColor = Color.Red;
                                        textBox1.SelectionFont = new Font(textBox1.Font.FontFamily, textBox1.Font.Size, FontStyle.Underline);
                                        textBox1.Select(start, 0);

                                    }
                                    theword = "";
                                }
                                else
                                {
                                    theword += letters;
                                    if (theword == word)
                                    {
                                        textBox1.Select(lettercount - theword.Count(), theword.Count());
                                        textBox1.SelectionColor = Color.Red;
                                        textBox1.SelectionFont = new Font(textBox1.Font.FontFamily, textBox1.Font.Size, FontStyle.Underline);
                                        textBox1.Select(start, 0);

                                    }


                                }
                            }

                        }
                    }
                }
            }

            schecked = true;
        }

        private void textBox1_SelectionChanged(object sender, EventArgs e)
        {
            if (textBox1.SelectedText.ToString() != "")
            {
                char_count.Text = textBox1.SelectedText.Count().ToString() + " Character(s)";
                lines_count.Text = textBox1.SelectedText.Split('\n').Count().ToString() + " Line(s)";

                //Get Word count
                int words = 0;
                foreach (var lines in textBox1.SelectedText.Split('\n'))
                {
                    foreach (var word in lines.Split(' '))
                    {
                        if (word.Replace(" ", "").Count() != 0)
                        {
                            words++;
                        }   
                    }
                }

                word_count.Text = words.ToString() + " Word(s)";
            }
            else
            {
                //Standard all Counting System
                int count = 0;

                foreach (var lines in textBox1.Lines)
                {
                    //Theory 433: Finding the no. of words of an string
                    if (lines.Replace(" ", "").Count() != 0)
                    {
                        if (lines.EndsWith(" "))
                        {
                            count += (lines.Split(' ').Count() - 1);
                        }
                        else if (lines.EndsWith("\r"))
                        {
                            count += (lines.Split(' ').Count() - 1);
                        }
                        else
                        {
                            count += lines.Split(' ').Count();
                        }
                    }
                }

                //Set the count of words into the label.
                word_count.Text = count + " Word(s)";
            }
        }

        private void menu_pane_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}