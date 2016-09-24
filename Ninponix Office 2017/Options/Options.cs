using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ninponix_Office.Options
{
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Sync the settings in the properties file with the settings controls in the options.cs
        /// </summary>
        public void SyncSettings()
        {
            //PREFERENCES
            //SET OPENWHAT
            switch (Ninponix_Office.Properties.Settings.Default.OpenWhat)
            {
                case "START_SCREEN":
                    open_start_screen_radio_button.Checked = true;
                    open_other_radio_button.Checked = false;
                    open_new_radio_button.Checked = false;
                    break;
                case "TEXT_DOCUMENT":
                    open_start_screen_radio_button.Checked = false;
                    open_other_radio_button.Checked = false;
                    open_new_radio_button.Checked = true;

                    open_new_combobox.SelectedIndex = 0;
                    break;
                case "VISUAL_DOCUMENT":
                    open_start_screen_radio_button.Checked = false;
                    open_other_radio_button.Checked = false;
                    open_new_radio_button.Checked = true;

                    open_new_combobox.SelectedIndex = 1;
                    break;
                case "PRESENTATION":
                    open_start_screen_radio_button.Checked = false;
                    open_other_radio_button.Checked = false;
                    open_new_radio_button.Checked = true;

                    open_new_combobox.SelectedIndex = 2;
                    break;
                case "LAST_OPEN":
                    open_start_screen_radio_button.Checked = false;
                    open_other_radio_button.Checked = true;
                    open_new_radio_button.Checked = false;

                    open_other_combobox.SelectedIndex = 0;
                    break;
                case "PRIORITY":
                    open_start_screen_radio_button.Checked = false;
                    open_other_radio_button.Checked = true;
                    open_new_radio_button.Checked = false;

                    open_other_combobox.SelectedIndex = 1;
                    break;
            }

            //SET PRIORITY DOCUMENT
            priority_document_txt.Text = Ninponix_Office.Properties.Settings.Default.PriorityDocument;

            //SET RECOVERY
            enable_recovery_checkbox.Checked = Ninponix_Office.Properties.Settings.Default.RECOVERY_ENABLED;
            recovery_time_interval_numeric_updown.Value = Ninponix_Office.Properties.Settings.Default.RECOVERY_TIME;

            //UPDATE LINKS
            update_links_checkbox.Checked = Ninponix_Office.Properties.Settings.Default.UPDATE_LINKS;

            //UPDATE LINKS ON
            switch (Ninponix_Office.Properties.Settings.Default.UPDATE_LINKS_ON)
            {
                case "START":
                    update_links_on_program_start_radio_button.Checked = true;
                    update_links_according_to_time_radiobutton.Checked = false;
                    break;
                case "TIME":
                    update_links_on_program_start_radio_button.Checked = false;
                    update_links_according_to_time_radiobutton.Checked = true;
                    break;
            }

            //RENDERING SYSTEM
            rendering_system_combobox.SelectedIndex = Ninponix_Office.Properties.Settings.Default.RENDERING_SYSTEM;

            //MUIP CACHING
            muip_caching_checkbox.Checked = Ninponix_Office.Properties.Settings.Default.MUIP_CACHING;


            //TEXT DOCUMENT SETTINGS
            //FONT
            change_font_btn.Text = Ninponix_Office.Properties.Settings.Default.textdoc_Font.Name + ", " + Ninponix_Office.Properties.Settings.Default.textdoc_Font.Size.ToString();
            //FONTCOLOR
            change_font_color_btn.BackColor = Ninponix_Office.Properties.Settings.Default.textdoc_fontcolor;

            //WORDWRAP
            word_wrap_enabled_checkbox.Checked = Ninponix_Office.Properties.Settings.Default.textDocuments_WordWrap;

            //SHORTCUTS ENABLED
            shortcuts_enabled_check_box.Checked = Ninponix_Office.Properties.Settings.Default.TEXT_DOCUMENT_SHORTCUTS_ENABLED;


            //EXTERNAL TOOLS
            //EXTERNAL TOOLS LAUNCH ENABLED
            enable_external_tools_launch_checkbox.Checked = Ninponix_Office.Properties.Settings.Default.ENABLE_EXTERNAL_TOOLS;
        }

        /// <summary>
        /// Apply the settings
        /// </summary>
        public void Apply()
        {
            //OPENWHAT
            if (open_start_screen_radio_button.Checked == true)
            {
                Ninponix_Office.Properties.Settings.Default.OpenWhat = "START_SCREEN";
            }
            else
            {
                if (open_new_radio_button.Checked == true)
                {
                    //NEW
                    switch (open_new_combobox.SelectedIndex)
                    {
                        case 0:
                            Ninponix_Office.Properties.Settings.Default.OpenWhat = "TEXT_DOCUMENT";
                            break;
                        case 1:
                            Ninponix_Office.Properties.Settings.Default.OpenWhat = "VISUAL_DOCUMENT";
                            break;
                        case 2:
                            Ninponix_Office.Properties.Settings.Default.OpenWhat = "PRESENTATION";
                            break;
                    }
                }
                else
                {
                    //OTHER
                    switch (open_other_combobox.SelectedIndex)
                    {
                        case 0:
                            Ninponix_Office.Properties.Settings.Default.OpenWhat = "LAST_OPEN";
                            break;
                        case 1:
                            Ninponix_Office.Properties.Settings.Default.OpenWhat = "PRIORITY";
                            break;
                    }
                }
            }

            //SET PRIORITY DOCUMENT
            Ninponix_Office.Properties.Settings.Default.PriorityDocument = priority_document_txt.Text;

            //SET RECOVERY
            Ninponix_Office.Properties.Settings.Default.RECOVERY_ENABLED = enable_recovery_checkbox.Checked;
            Ninponix_Office.Properties.Settings.Default.RECOVERY_TIME = (int)recovery_time_interval_numeric_updown.Value;

            //UPDATE LINKS
            Ninponix_Office.Properties.Settings.Default.UPDATE_LINKS = update_links_checkbox.Checked;

            if (update_links_according_to_time_radiobutton.Checked == true)
            {
                Ninponix_Office.Properties.Settings.Default.UPDATE_LINKS_ON = "TIME";
            }
            else if (update_links_on_program_start_radio_button.Checked == true)
            {
                Ninponix_Office.Properties.Settings.Default.UPDATE_LINKS_ON = "START";
            }

            //RENDERING SYSTEM
            Ninponix_Office.Properties.Settings.Default.RENDERING_SYSTEM = rendering_system_combobox.SelectedIndex;

            //MUIP CACHING
            Ninponix_Office.Properties.Settings.Default.MUIP_CACHING = muip_caching_checkbox.Checked;


            //TEXT DOCUMENT SETTINGS
            //FONT
            Ninponix_Office.Properties.Settings.Default.textdoc_Font = new Font(change_font_btn.Text.Split(',')[0].TrimStart().TrimEnd(), float.Parse(change_font_btn.Text.Split(',')[1].TrimStart().TrimEnd()));

            //FONTCOLOR
            Ninponix_Office.Properties.Settings.Default.textdoc_fontcolor = change_font_color_btn.BackColor;

            //WORDWRAP
            Ninponix_Office.Properties.Settings.Default.textDocuments_WordWrap = word_wrap_enabled_checkbox.Checked;

            //SHORTCUTS ENABLED
            Ninponix_Office.Properties.Settings.Default.TEXT_DOCUMENT_SHORTCUTS_ENABLED = shortcuts_enabled_check_box.Checked;


            //EXTERNAL TOOLS
            //EXTERNAL TOOLS LAUNCH ENABLED
            Ninponix_Office.Properties.Settings.Default.ENABLE_EXTERNAL_TOOLS = enable_external_tools_launch_checkbox.Checked;
        }

        /// <summary>
        /// Reset the settings
        /// </summary>
        public void Reset()
        {
            if (MessageBox.Show("Do you really want to reset the settings?", "Ninponix Office 2017", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Ninponix_Office.Properties.Settings.Default.Reset();
                Application.Exit();
                Application.ExitThread();
            }
        }

        private void Options_Load(object sender, EventArgs e)
        {
            try
            {
                SyncSettings();
            }
            catch (Exception)
            {
                MessageBox.Show("Could not sync the settings. Please retry", "Ninponix Office 2017", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
            }
        }

        private void install_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Browse Tusker Plugin";
            open.Filter = "Ninponix Office Plugin|*.noplug";
            
            if (open.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("No valid classname found. Please try another Plugin.", "Ninponix Office 2017", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void change_font_btn_Click(object sender, EventArgs e)
        {
            FontDialog f = new FontDialog();
            string fontname = change_font_btn.Text.ToString().Split(',')[0];
            float fontsize = float.Parse(change_font_btn.Text.ToString().Split(',')[1].TrimStart().TrimEnd());

            f.Font = new Font(fontname, fontsize);

            if (f.ShowDialog() == DialogResult.OK)
            {
                change_font_btn.Text = f.Font.Name + ", " + f.Font.Size.ToString();
            }
        }

        private void open_new_radio_button_CheckedChanged(object sender, EventArgs e)
        {
            if (open_new_radio_button.Checked == true)
            {
                open_new_combobox.Enabled = true;
                open_other_combobox.Enabled = false;
            }
            else
            {
                open_new_combobox.Enabled = false;
            }
        }

        private void open_other_radio_button_CheckedChanged(object sender, EventArgs e)
        {
            if (open_other_radio_button.Checked ==true)
            {
                open_other_combobox.Enabled = true;
                open_new_combobox.Enabled = false;
            }
            else
            {
                open_other_combobox.Enabled = false;
            }
        }

        private void open_start_screen_radio_button_CheckedChanged(object sender, EventArgs e)
        {
            if (open_start_screen_radio_button.Checked == true)
            {
                open_other_combobox.Enabled = false;
                open_new_combobox.Enabled = false;
            }
        }

        private void Apply_btn_Click(object sender, EventArgs e)
        {
            Apply();
            Close();
        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void OuterTouch(object sender, EventArgs e)
        {
            ChangeStatus("Options : Manage Options related to preferences, languages, plugins, text document, visual documents, presentations, and external tools.");
        }

        public void ChangeStatus(string txt)
        {
            status_txt.Text = txt;
        }

        private void change_font_color_btn_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ColorDialog color = new ColorDialog();
            color.Color = change_font_color_btn.BackColor;
            color.AllowFullOpen = true;

            if (color.ShowDialog() == DialogResult.OK)
            {
                change_font_color_btn.BackColor = color.Color;
            }
        }

        private void Reset_btn_Click(object sender, EventArgs e)
        {
            Reset();
            Close();
        }

        private void open_start_screen_radio_button_MouseEnter(object sender, EventArgs e)
        {
            ChangeStatus("Open the Official Start Screen when Ninponix Office starts");
        }
        
        private void open_new_radio_button_MouseEnter(object sender, EventArgs e)
        {
            ChangeStatus("Open a new Text, Visual Document or Presentation when Ninponix Office starts");
        }

        private void open_other_radio_button_MouseEnter(object sender, EventArgs e)
        {
            ChangeStatus("Open other such as Recent file or Priority file");
        }

        private void priority_document_txt_MouseEnter(object sender, EventArgs e)
        {
            ChangeStatus("The file / document with the highest priority");
        }

        private void enable_recovery_checkbox_MouseEnter(object sender, EventArgs e)
        {
            ChangeStatus("Enable the Recovery of Documents");
        }

        private void label6_MouseEnter(object sender, EventArgs e)
        {
            ChangeStatus("Time interval of Backing up the Content");
        }

        private void update_links_checkbox_MouseEnter(object sender, EventArgs e)
        {
            ChangeStatus("Update the external links (http and https) from the Ninponix Server");
        }

        private void update_links_on_program_start_radio_button_MouseEnter(object sender, EventArgs e)
        {
            ChangeStatus("Update links on the start of Ninponix Office");
        }

        private void update_links_according_to_time_radiobutton_MouseEnter(object sender, EventArgs e)
        {
            ChangeStatus("Update links according to certain time intervals");
        }

        private void rendering_system_combobox_MouseEnter(object sender, EventArgs e)
        {
            ChangeStatus("Overall rendering system of NVL Documents (Visual Documents and Presentations)");
        }

        private void muip_caching_checkbox_MouseEnter(object sender, EventArgs e)
        {
            ChangeStatus("Whether caches MUIP (Multiple User Interface Program) Cache or not");
        }

        private void nlpp_caching_reading_checkbo_MouseEnter(object sender, EventArgs e)
        {
            ChangeStatus("Reads Ninponix Live Preview Protocol Cache stored");
        }

        private void install_btn_MouseEnter(object sender, EventArgs e)
        {
            ChangeStatus("Install new Plugins to Ninponix Office 2017 in the format of .noplug");
        }

        private void change_font_btn_MouseEnter(object sender, EventArgs e)
        {
            ChangeStatus("Shows current selection of font in text documents. Click to change it.");
        }

        private void change_font_color_btn_MouseEnter(object sender, EventArgs e)
        {
            ChangeStatus("Shows current font color of text documents. Click to select another");
        }

        private void word_wrap_enabled_checkbox_MouseEnter(object sender, EventArgs e)
        {
            ChangeStatus("Word Wrap status of the text document Preview");
        }

        private void shortcuts_enabled_check_box_MouseEnter(object sender, EventArgs e)
        {
            ChangeStatus("Enables and disables shortcuts in the Ninponix Office Text Document GUI");
        }

        private void listView1_MouseEnter(object sender, EventArgs e)
        {
            ChangeStatus("Shows a map of shortcuts that can be used in the Text Documents GUI");
        }
    }
}
