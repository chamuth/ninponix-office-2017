using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace noffice_admin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            load_image.Image = Image.FromFile(Application.StartupPath.Replace("Ninponix Office.exe", "") + "\\" + "OfficeData\\ImageRaw\\UI_ELEMS\\noffice_load.nofficeimageraw");
        }

        bool open = true;
        int count = 0;

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
                    System.Diagnostics.Process.Start("Ninponix Office.exe");
                    try
                    {
                        using (System.IO.StreamWriter sw = new System.IO.StreamWriter(Application.StartupPath.Replace("Ninponix Office.exe", "") + "\\" + "Runtime\\AdminQuote.nofficeraw"))
                        {
                            sw.Write("TRUE");
                            sw.Close();
                        }
                    }
                    catch (Exception)
                    {

                    }
                    Application.Exit();
                }
            }

            count++;

            int x = (Screen.PrimaryScreen.WorkingArea.Width / 2) - (Width / 2);
            int y = (Screen.PrimaryScreen.WorkingArea.Height / 2) - (Height / 2);

            switch (count)
            {
                case 1:
                    Location = new Point(x, y - 100);
                    break;
                case 2:
                    Location = new Point(x, y - 50);
                    break;
                case 3:
                    Location = new Point(x, y - 25);
                    break;
                case 4:
                    Location = new Point(x, y - 15);
                    break;
                case 5:
                    Location = new Point(x, y - 10);
                    break;
                case 6:
                    Location = new Point(x, y - 5);
                    break;
                case 7:
                    Location = new Point(x, y - 4);
                    break;
                case 8:
                    Location = new Point(x, y - 3);
                    break;
                case 9:
                    Location = new Point(x, y - 2);
                    break;
                case 10:
                    Location = new Point(x, y - 1);
                    break;
                case 11:
                    Location = new Point(x, y );
                    break;
                case 450:
                    open = false;
                    break;
            }
        }
    }
}
