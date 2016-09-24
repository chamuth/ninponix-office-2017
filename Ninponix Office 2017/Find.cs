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
    public partial class Find : Form
    {
        public enum FindDialogResult{
            FindOKResult,
            FindCancelResult,
            NullResult
        }

        bool open = true;

        public Find()
        {
            InitializeComponent();
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

        private void close_btn_Click(object sender, EventArgs e)
        {
            open = false;
        }

        public FindDialogResult Result = FindDialogResult.NullResult;

        private void Find_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (query_txt.Text == "" | query_txt.Text.Replace(" ", "").Count() == 0)
            {
                Message error1 = new Message("Ninponix Office 2017: Find", "Please enter a valid Text Value to search / find for.", MessageIcon.MessageIconType.Error, MessageIcon.MessageMode.Normal);
                error1.ShowDialog();
            }
            else
            { 
                Result = FindDialogResult.FindOKResult;
                open = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            open = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Result = FindDialogResult.FindCancelResult;
            open = false;
        }
    }
}
