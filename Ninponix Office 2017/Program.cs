using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ninponix_Office
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //PROGRAM START
            Properties.Settings.Default.Reset();
            Properties.Settings.Default.StartCount++;
            Properties.Settings.Default.Save();

            //Check for Command Line Arguments

            if (Environment.GetCommandLineArgs().Count() != 1)
            {
                string Arg = "";
                string Path = "";
                string Type;
                int counter = 0;

                foreach (var line in Environment.GetCommandLineArgs())
                {
                    counter++;
                    if (counter != 1)
                    {
                        if (line.EndsWith(" "))
                            Arg += line;
                        else
                            Arg += line + " ";
                    }
                }

                Path = Arg.ToString();
                Path = Path.Remove(Path.Count() - 1, 1);

                if (Path.EndsWith(" -edit"))
                {
                    string newstring = Path.Remove(Path.Length - 6, 6);

                    if (newstring.EndsWith(".nvldoc") | newstring.EndsWith(".nvlexp"))
                    {
                        if (Properties.Settings.Default.StartCount % 10 == 1)
                        {
                            Notification info = new Notification(Notification.NotificationMode.OrangeMode, @"Documentation\index.html", "Ninponix Office 2017", "Welcome to Ninponix Office 2017. Get started with Ninponix Office 2017...");
                            info.Show();
                        }
                        //NVL Editing Option
                        VisualDocumentEditor vde = new VisualDocumentEditor(newstring, true);
                        Application.Run(vde);
                    }
                    else if (newstring.EndsWith(".nopres"))
                    {
                        if (Properties.Settings.Default.StartCount % 10 == 1)
                        {
                            Notification info = new Notification(Notification.NotificationMode.GreenMode, @"Documentation\index.html", "Ninponix Office 2017", "Welcome to Ninponix Office 2017. Get started with Ninponix Office 2017...");
                            info.Show();
                        }
                        //NVL Editing Option
                        Presentation_Editor pre = new Presentation_Editor(newstring);
                        Application.Run(pre);
                    }
                }
                else
                {
                    if (Path.EndsWith(".html") | Path.EndsWith(".htm"))
                    {
                        Type = "HTML Document";
                    }
                    else if (Path.EndsWith(".txt") | Path.EndsWith(".txt"))
                    {
                        if (Properties.Settings.Default.StartCount % 10 == 1)
                        {
                            Notification info = new Notification(Notification.NotificationMode.BlueMode, @"Documentation\index.html", "Ninponix Office 2017", "Welcome to Ninponix Office 2017. Get started with Ninponix Office 2017...");
                            info.Show();
                        }
                        Type = "Text Document";
                        txtDocument myform = new txtDocument();

                        myform.docloc = Path;
                        int expands = Path.Split('\\').Count();

                        myform.doctitle = Path.Split('\\')[expands - 1];
                        myform.title.Text = myform.doctitle;

                        using (System.IO.StreamReader sr = new System.IO.StreamReader(Path))
                        {
                            myform.textBox1.Text = sr.ReadToEnd();
                        }

                        Application.Run(myform);
                        Properties.Settings.Default.TextDocumentsThreadCount = 0;
                    }
                    else if (Path.EndsWith(".nvldoc") | Path.EndsWith(".nvlexp"))
                    {
                        if (Properties.Settings.Default.StartCount % 10 == 1)
                        {
                            Notification info = new Notification(Notification.NotificationMode.OrangeMode, @"Documentation\index.html", "Ninponix Office 2017", "Welcome to Ninponix Office 2017. Get started with Ninponix Office 2017...");
                            info.Show();
                        }
                        Type = "NVL Visual Document";
                        VisualDocumentToolBox.VDReader vd = new VisualDocumentToolBox.VDReader(Path.ToString(), false);
                        Application.Run(vd);
                    }
                    else if (Path.EndsWith(".nvl"))
                    {
                        Type = "NVL Document";
                    }
                    else if (Path.EndsWith(".nopres"))
                    {
                        if (Properties.Settings.Default.StartCount % 10 == 1)
                        {
                            Notification info = new Notification(Notification.NotificationMode.GreenMode, @"Documentation\index.html", "Ninponix Office 2017", "Welcome to Ninponix Office 2017. Get started with Ninponix Office 2017...");
                            info.Show();
                        }
                        Type = "Ninponix Office Presentation";
                        //PRESENTATION PREVIEW WINDOWS MUST BE SHOWN
                        Ninponix_Office.PresentationToolBox.PresentationViewer pre = new Ninponix_Office.PresentationToolBox.PresentationViewer();
                        pre._URL = Path;
                        Application.Run(pre);
                    }
                    else if (Path.EndsWith(".nospread"))
                    {
                        Type = "Ninponix Office Spreadsheet";
                    }
                    else if (Path.EndsWith(".rtf"))
                    {
                        Type = "Rich Text Document";
                    }
                    else
                    {
                        MessageBox.Show("The file format is not supported by the Ninponix Office", "Ninponix Office 2017", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            else
            {
                Application.Run(new Form1());
            }

        }
    }
}
