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
    public partial class VisualDocument : Form
    {
        public VisualDocument()
        {
            InitializeComponent();
        }
        Color nor;
        bool showform = true;

        private void VD_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.LearnMore == true)
            {
                LearnMore.VisualDocument vd = new LearnMore.VisualDocument();
                vd.Show();
            }

            nor = template1.BackColor;
            document_url.Items.Add(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\");
            document_url.Items.Add("Select Other location");
            document_url.SelectedIndex = 0;
            document_name.Focus();
        }

        int count = 0;
        int count2 = 0;
        int screenx = Screen.PrimaryScreen.WorkingArea.Width;
        int screeny = Screen.PrimaryScreen.WorkingArea.Height;

        bool open = true;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (open == true)
            {
                if (Opacity != 1)
                {
                    Opacity += 0.1;
                }

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
                        break;
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
                    if (showform == true)
                    {
                        Form1 frm = new Form1();
                        frm.Show();
                    }
                }

                count2++;

                switch (count2)
                {
                    case 1:
                        Width = screenx;
                        Height = screeny;
                        Location = new Point((Screen.PrimaryScreen.WorkingArea.Width / 2) - (Width / 2), (Screen.PrimaryScreen.WorkingArea.Height / 2) - ((Height) / 2));
                        break;
                    case 2:
                        Width = screenx - 1;
                        Height = screeny - 1;
                        Location = new Point((Screen.PrimaryScreen.WorkingArea.Width / 2) - (Width / 2), (Screen.PrimaryScreen.WorkingArea.Height / 2) - ((Height) / 2));
                        break;
                    case 3:
                        Width = screenx - 2;
                        Height = screeny - 2;
                        Location = new Point((Screen.PrimaryScreen.WorkingArea.Width / 2) - (Width / 2), (Screen.PrimaryScreen.WorkingArea.Height / 2) - ((Height) / 2));
                        break;
                    case 4:
                        Width = screenx - 3;
                        Height = screeny - 3;
                        Location = new Point((Screen.PrimaryScreen.WorkingArea.Width / 2) - (Width / 2), (Screen.PrimaryScreen.WorkingArea.Height / 2) - ((Height) / 2));
                        break;
                    case 5:
                        Width = screenx - 4;
                        Height = screeny - 4;
                        Location = new Point((Screen.PrimaryScreen.WorkingArea.Width / 2) - (Width / 2), (Screen.PrimaryScreen.WorkingArea.Height / 2) - ((Height) / 2));
                        break;
                    case 6:
                        Width = screenx - 5;
                        Height = screeny - 5;
                        Location = new Point((Screen.PrimaryScreen.WorkingArea.Width / 2) - (Width / 2), (Screen.PrimaryScreen.WorkingArea.Height / 2) - ((Height) / 2));
                        break;
                    case 7:
                        Width = screenx - 10;
                        Height = screeny - 10;
                        Location = new Point((Screen.PrimaryScreen.WorkingArea.Width / 2) - (Width / 2), (Screen.PrimaryScreen.WorkingArea.Height / 2) - ((Height) / 2));
                        break;
                    case 8:
                        Width = screenx - 15;
                        Height = screeny - 15;
                        Location = new Point((Screen.PrimaryScreen.WorkingArea.Width / 2) - (Width / 2), (Screen.PrimaryScreen.WorkingArea.Height / 2) - ((Height) / 2));
                        break;
                    case 9:
                        Width = screenx - 20;
                        Height = screeny - 20;
                        Location = new Point((Screen.PrimaryScreen.WorkingArea.Width / 2) - (Width / 2), ((Screen.PrimaryScreen.Bounds.Height - 34) / 2) - ((Height) / 2));
                        break;
                    case 10:
                        Width = screenx - 25;
                        Height = screeny - 25;
                        Location = new Point((Screen.PrimaryScreen.WorkingArea.Width / 2) - (Width / 2), (Screen.PrimaryScreen.WorkingArea.Height / 2) - ((Height) / 2));
                        break;
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            showform = true;
            open = false;
        }

        private void template1_Click(object sender, EventArgs e)
        {
            create_panel.Enabled = true;
            template_title.Text = "Document";
            document_name.Text = "NewDocument1";
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            create_panel.Enabled = false;
            template_title.Text = "Create";
            document_name.Text = "NewDocument1";
        }

        private void template2_Click(object sender, EventArgs e)
        {
            create_panel.Enabled = true;
            template_title.Text = "Letter";
            document_name.Text = "NewLetter1";
        }

        private void template3_Click(object sender, EventArgs e)
        {
            create_panel.Enabled = true;
            template_title.Text = "Report";
            document_name.Text = "NewReport1";
        }

        private void template4_Click(object sender, EventArgs e)
        {
            create_panel.Enabled = true;
            template_title.Text = "Resume";
            document_name.Text = "NewResume1";
        }

        private void document_url_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (document_url.SelectedIndex == document_url.Items.Count - 1)
            {
                DirectoryDialog dir = new DirectoryDialog("Visual Document Save Location", "Please select a valid location", MessageIcon.MessageMode.NVL);
                dir.ShowDialog();
                string saveloc = dir.GetDirectoryURL();
                if (saveloc.Replace(" ", "").Count() != 0)
                {
                    document_url.Items.Clear();
                    document_url.Items.Add(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
                    document_url.Items.Add(saveloc.ToString());
                    document_url.Items.Add("Select Other location");
                    document_url.SelectedIndex = 1;
                }
            }
        }

        private void create_button_Click(object sender, EventArgs e)
        {
            //Check for the existence of the directory before continue
            if (System.IO.Directory.Exists(document_url.SelectedText) == false)
            {
                if (MessageBox.Show("The directory \"" + document_url.SelectedText + "\" does not exist. Do you want to create it now?", "Ninponix Office", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //Execution 1
                    try
                    {
                        System.IO.Directory.CreateDirectory(document_url.SelectedText);
                    }
                    catch (Exception)
                    {
                        Message msg = new Message("Ninponix Office", "Couldn't create the directory for you.", MessageIcon.MessageIconType.Error, MessageIcon.MessageMode.NVL);
                        msg.ShowDialog();
                    }
                    try
                    {
                        switch (template_title.Text)
                        {
                            case "Document":
                                if (document_url.SelectedText.EndsWith("\\") == true)
                                {
                                    System.IO.File.Copy(Application.ExecutablePath.Replace("Ninponix Office.exe", "")  + "OfficeData\\Templates\\NVL\\Documents\\Empty.nvldoc", document_url.SelectedText + document_name.Text + ".nvldoc",true);
                                }
                                else
                                {
                                    System.IO.File.Copy(Application.ExecutablePath.Replace("Ninponix Office.exe", "")  + "OfficeData\\Templates\\NVL\\Documents\\Empty.nvldoc", document_url.SelectedText + "\\" + document_name.Text + ".nvldoc",true);
                                }

                                break;
                            case "Letter":
                                if (document_url.SelectedText.EndsWith("\\") == true)
                                {
                                    System.IO.File.Copy(Application.ExecutablePath.Replace("Ninponix Office.exe", "") + "OfficeData\\Templates\\NVL\\Documents\\Letter.nvldoc", document_url.SelectedText + document_name.Text + ".nvldoc", true );
                                }
                                else
                                {
                                    System.IO.File.Copy(Application.ExecutablePath.Replace("Ninponix Office.exe", "") + "OfficeData\\Templates\\NVL\\Documents\\Letter.snvldoc", document_url.SelectedText + "\\" + document_name.Text + ".nvldoc", true );
                                }
                                break;
                            case "Resume":
                                if (document_url.SelectedText.EndsWith("\\") == true)
                                {
                                    System.IO.File.Copy(Application.ExecutablePath.Replace("Ninponix Office.exe", "") + "OfficeData\\Templates\\NVL\\Documents\\Resume.nvldoc", document_url.SelectedText + document_name.Text + ".nvldoc", true);
                                }
                                else
                                {
                                    System.IO.File.Copy(Application.ExecutablePath.Replace("Ninponix Office.exe", "")+ "OfficeData\\Templates\\NVL\\Documents\\Resume.snvldoc", document_url.SelectedText + "\\" + document_name.Text + ".nvldoc",true);
                                }
                                break;
                            case "Report":
                                if (document_url.SelectedText.EndsWith("\\") == true)
                                {
                                    System.IO.File.Copy(Application.ExecutablePath.Replace("Ninponix Office.exe", "")+ "OfficeData\\Templates\\NVL\\Documents\\Report.nvldoc", document_url.SelectedText + document_name.Text + ".nvldoc",true);
                                }
                                else
                                {
                                    System.IO.File.Copy(Application.ExecutablePath.Replace("Ninponix Office.exe", "") + "OfficeData\\Templates\\NVL\\Documents\\Report.snvldoc", document_url.SelectedText + "\\" + document_name.Text + ".nvldoc",true);
                                }
                                break;
                        }
                        if (document_url.SelectedText.EndsWith("\\") == true)
                        {
                            VisualDocumentEditor edit = new VisualDocumentEditor(document_url.SelectedText + document_name.Text.ToString() + ".nvldoc",false);
                            edit.Show();
                            button1.Enabled = false;
                            open = false;
                            showform = false;
                        }
                        else
                        {
                            VisualDocumentEditor edit = new VisualDocumentEditor(document_url.SelectedText + "\\" + document_name.Text.ToString() + ".nvldoc", false);
                            edit.Show();
                            button1.Enabled = false;
                            open = false;
                            showform = false;
                        }
                    }
                    catch (Exception)
                    {
                        Message msg = new Message("Ninponix Office", "Cannot create the instance for the new document template.", MessageIcon.MessageIconType.Error, MessageIcon.MessageMode.NVL);
                        msg.ShowDialog();

                    }
                }
            }
            else
            {
                //Execution 1: on the existence dialog
                try
                {
                    System.IO.Directory.CreateDirectory(document_url.SelectedText);
                }
                catch (Exception)
                {
                    Message msg = new Message("Ninponix Office", "Couldn't create the directory for you.", MessageIcon.MessageIconType.Error, MessageIcon.MessageMode.NVL);
                    msg.ShowDialog();
                }
                try
                {
                    switch (template_title.Text)
                    {
                        case "Document":
                            if (document_url.SelectedText.EndsWith("\\") == true)
                            {
                                System.IO.File.Copy(Application.ExecutablePath.Replace("Ninponix Office.exe", "") + "OfficeData\\Templates\\NVL\\Documents\\Empty.nvldoc", document_url.SelectedText + document_name.Text + ".nvldoc",true);
                            }
                            else
                            {
                                System.IO.File.Copy(Application.ExecutablePath.Replace("Ninponix Office.exe", "") + "OfficeData\\Templates\\NVL\\Documents\\Empty.nvldoc", document_url.SelectedText + "\\" + document_name.Text + ".nvldoc",true);
                            }

                            break;
                        case "Letter":
                            if (document_url.SelectedText.EndsWith("\\") == true)
                            {
                                System.IO.File.Copy(Application.ExecutablePath.Replace("Ninponix Office.exe", "") + "OfficeData\\Templates\\NVL\\Documents\\Letter.nvldoc", document_url.SelectedText + document_name.Text + ".nvldoc",true);
                            }
                            else
                            {
                                System.IO.File.Copy(Application.ExecutablePath.Replace("Ninponix Office.exe", "") + "OfficeData\\Templates\\NVL\\Documents\\Letter.snvldoc", document_url.SelectedText + "\\" + document_name.Text + ".nvldoc",true);
                            }
                            break;
                        case "Resume":
                            if (document_url.SelectedText.EndsWith("\\") == true)
                            {
                                System.IO.File.Copy(Application.ExecutablePath.Replace("Ninponix Office.exe", "") + "OfficeData\\Templates\\NVL\\Documents\\Resume.nvldoc", document_url.SelectedText + document_name.Text + ".nvldoc", true );
                            }
                            else
                            {
                                System.IO.File.Copy(Application.ExecutablePath.Replace("Ninponix Office.exe", "") + "OfficeData\\Templates\\NVL\\Documents\\Resume.snvldoc", document_url.SelectedText + "\\" + document_name.Text + ".nvldoc", true );
                            }
                            break;
                        case "Report":
                            if (document_url.SelectedText.EndsWith("\\") == true)
                            {
                                System.IO.File.Copy(Application.ExecutablePath.Replace("Ninponix Office.exe", "") + "OfficeData\\Templates\\NVL\\Documents\\Report.nvldoc", document_url.SelectedText + document_name.Text + ".nvldoc", true);
                            }
                            else
                            {
                                System.IO.File.Copy(Application.ExecutablePath.Replace("Ninponix Office.exe", "") + "OfficeData\\Templates\\NVL\\Documents\\Report.snvldoc", document_url.SelectedText + "\\" + document_name.Text + ".nvldoc", true );
                            }
                            break;
                    }
                    if (document_url.SelectedText.EndsWith("\\") == true)
                    {
                        VisualDocumentEditor edit = new VisualDocumentEditor(document_url.SelectedText + document_name.Text.ToString() + ".nvldoc", false);
                        edit.Show();
                        open = false;
                        showform = false;
                    }
                    else
                    {
                        VisualDocumentEditor edit = new VisualDocumentEditor(document_url.SelectedText + "\\" + document_name.Text.ToString() + ".nvldoc", false);
                        edit.Show();
                        open = false;
                        showform = false;
                    }
                }
                catch (Exception)
                {
                    Message msg = new Message("Ninponix Office", "Cannot create the instance for the new document template.", MessageIcon.MessageIconType.Error, MessageIcon.MessageMode.NVL);
                    msg.ShowDialog();

                }

            }


        }
    }
}
