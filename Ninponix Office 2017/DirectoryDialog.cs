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
    public partial class DirectoryDialog : Form
    {
        string nowpath = "";
        string return_path = "";

        public DirectoryDialog(string title, string description, MessageIcon.MessageMode mode)
        {
            InitializeComponent();
            Text = title;
            description_txt.Text = description;

            if (mode == MessageIcon.MessageMode.Normal)
            {
                BackColor = Color.DeepSkyBlue;
                listBox1.BackColor = Color.SkyBlue;
                button3.ForeColor = Color.DeepSkyBlue;
                button1.BackColor = Color.DeepSkyBlue;
                button2.BackColor = Color.DeepSkyBlue;
                button2.FlatAppearance.BorderColor = Color.SkyBlue;
                button1.FlatAppearance.BorderColor = Color.SkyBlue;
            }
            else if (mode == MessageIcon.MessageMode.NVL)
            {
                BackColor = Color.Orange;
                listBox1.BackColor = Color.FromArgb(255, 174, 0);
                button3.ForeColor = Color.Orange;
                button2.BackColor = Color.Orange;
                button1.BackColor = Color.Orange;
                button2.FlatAppearance.BorderColor = Color.FromArgb(255, 174, 0);
                button1.FlatAppearance.BorderColor = Color.FromArgb(255, 174, 0);
            }
        }
    
        public string GetDirectoryURL()
        {
            return return_path;
        }
        private void DirectoryDialog_Load(object sender, EventArgs e)
        {
            foreach (var drives in System.IO.DriveInfo.GetDrives())
            {
                listBox1.Items.Add(drives.Name.ToString());
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            nowpath = nowpath + listBox1.SelectedItem.ToString();
            listBox1.Items.Clear();
            foreach (var dirs in System.IO.Directory.GetDirectories(nowpath))
            {
                listBox1.Items.Add(dirs.ToString().Replace(nowpath, ""));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nowpath.Count() != 3 || nowpath != "")
            {
                try
                {
                    string rootdir = System.IO.Directory.GetParent(nowpath).FullName;
                    nowpath = rootdir;
                    listBox1.Items.Clear();
                    foreach (var dirs in System.IO.Directory.GetDirectories(nowpath))
                    {
                        listBox1.Items.Add(dirs.ToString().Replace(nowpath, ""));
                    }
                }
                catch (Exception)
                {
                    listBox1.Items.Clear();
                    nowpath = "";
                    foreach (var drives in System.IO.DriveInfo.GetDrives())
                    {
                        listBox1.Items.Add(drives.Name.ToString());
                    }
                }
            }
            else
            {
                listBox1.Items.Clear();
                nowpath = "";
                foreach (var drives in System.IO.DriveInfo.GetDrives())
                {
                    listBox1.Items.Add(drives.Name.ToString());
                }
            }
            
        }

        bool open = true;
        int count;

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
                    Close();
                }
            }

            count++;
            int def_width = 400;
            int def_height = 510;
            switch (count)
            {
                case 1:
                    Width = def_width - 20;
                    Height = def_height - 20;
                    getCentered();
                    break;
                case 2:
                    Width = def_width - 10;
                    Height = def_height - 10;
                    getCentered();
                    break;
                case 3:
                    Width = def_width - 5;
                    Height = def_height - 5;
                    getCentered();
                    break;
                case 4:
                    Width = def_width - 4;
                    Height = def_height - 4;
                    getCentered();
                    break;
                case 5:
                    Width = def_width - 3;
                    Height = def_height - 3;
                    getCentered();
                    break;
                case 6:
                    Width = def_width - 2;
                    Height = def_height - 2;
                    getCentered();
                    break;
                case 7:
                    Width = def_width - 1;
                    Height = def_height - 1;
                    getCentered();
                    break;
                case 8:
                    Width = def_width;
                    Height = def_height;
                    getCentered();
                    break;
            }
        }

        public void getCentered()
        {
            Location = new Point((Screen.PrimaryScreen.WorkingArea.Width / 2) - (Width / 2), (Screen.PrimaryScreen.WorkingArea.Height / 2) - (Height / 2));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (nowpath == "")
            {
                Message msg1 = new Message("Ninponix Office", "Please select a valid location to continue.", MessageIcon.MessageIconType.Warning,MessageIcon.MessageMode.NVL);
                msg1.ShowDialog();
            }
            else
            {
                return_path = nowpath;
                open = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            return_path = "";
            open = false;
        }
    }
}
