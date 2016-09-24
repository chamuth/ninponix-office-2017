using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ninponix_Office.VisualDocumentToolBox
{
    public partial class ExportWizard : Form
    {
        string CODE_STRING;
        string project_location;

        public ExportWizard(string Code, string Project_Path)
        {
            InitializeComponent();
            CODE_STRING = Code;
            project_location = Project_Path;
        }

        private void ExportWizard_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            folder.Description = "Choose the location you need to export your project to...";
            folder.ShowNewFolderButton = true;

            if (folder.ShowDialog() == DialogResult.OK)
            {
                System.IO.DirectoryInfo i = new System.IO.DirectoryInfo(folder.SelectedPath);

                if (i.Root.FullName == i.FullName)
                {
                    MessageBox.Show("Sorry, you cannot select a root directory to export the project. Use a subdirectory instead", "Ninponix Office 2017", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    textBox1.Text = folder.SelectedPath;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (System.IO.Directory.Exists(textBox1.Text))
            {
                System.IO.DirectoryInfo i = new System.IO.DirectoryInfo(textBox1.Text);
                if (i.Root.FullName == i.FullName)
                {
                    MessageBox.Show("Sorry, you cannot select a root directory to export the project. Use a subdirectory instead", "Ninponix Office 2017", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //GOOD TO GO CODE
                    bool good = true;

                    foreach (var lines in CODE_STRING.Split('\n'))
                    {
                        if (lines.StartsWith("{IMAGE>"))
                        {
                            string path = lines.Split('}')[1];

                            if (!(path.StartsWith("..")))
                            {
                                good = false;
                            }
                        }
                    }

                    if (good == false)
                    {
                        MessageBox.Show("Cannot continue exporting your project. Please make sure you have copied all the resources need for the project in to the project folder using the \"..\"\\ tag in the resource locator of the {IMAGE} Tag", "Ninponix Office 2017", MessageBoxButtons.OK,MessageBoxIcon.Error);
                        Close();
                    }
                    else
                    {
                        if (VisualDocumentToolBox.ExportVD.Export(project_location, textBox1.Text, CODE_STRING.ToString()))
                        {
                            MessageBox.Show("Successfully Exported to " + textBox1.Text, "Ninponix Office 2017",MessageBoxButtons.OK,MessageBoxIcon.Information);
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Failed exporting your project. Please make sure everything is Okay.", "Ninponix Office 2017", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                        }
                    }
                }
            } else
            {
                MessageBox.Show("Please select a valid location, to continue exporting the project", "Ninponix Office 2017", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
