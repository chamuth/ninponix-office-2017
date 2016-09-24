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
    public partial class Solutions : Form
    {
        public Solutions(int ErrorCode)
        {
            InitializeComponent();
            
            switch (ErrorCode)
            {
                case 0x000:
                    error_name.Text = "Ninponix Office Error Testing";
                    code_txt.Text = ErrorCode.ToString();
                    description_txt.Text = "This is an Error Testing Session. This can be skipped normally by clicking any button appears below.";
                    fix_txt.Text = "This is an Error Testing Session. Therefore no fix is needed. You are good to go";
                    button1.Click += new EventHandler(TestingVoid);
                    break;
                case 0x100:
                    error_name.Text = "File(s) Missing";
                    code_txt.Text = ErrorCode.ToString();
                    description_txt.Text = "Some file(s) that are essential to run Ninponix Office have/has been missing from your computer.";
                    fix_txt.Text = "1. Check Recycle bin to see whether deleted files are available to restore.\n2. Restart Ninponix Office with Administrators previliges to prove whether the file(s) are accessible.\n3. Reinstall Ninponix Office on your computer.";
                    button1.Click += new EventHandler(ExitVoid);
                    break;
             }
        }

        public void MissingFixVoid(object sender, EventArgs e)
        {
            //Restart with Administrators Previliges
            
        }

        public void ExitVoid(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void TestingVoid(object sender, EventArgs e)
        {
            Close();
        }

        private void Solutions_Load(object sender, EventArgs e)
        {

        }
    }
}
