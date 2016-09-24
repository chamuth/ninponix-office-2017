namespace Ninponix_Office
{
    partial class Presentation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Presentation));
            this.panel1 = new System.Windows.Forms.Panel();
            this.title_doc = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.create_panel = new System.Windows.Forms.Panel();
            this.create_button = new System.Windows.Forms.Button();
            this.template_title = new System.Windows.Forms.Label();
            this.document_url = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.document_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.template1 = new System.Windows.Forms.Button();
            this.color2_5 = new System.Windows.Forms.Panel();
            this.color_2_4 = new System.Windows.Forms.Panel();
            this.color_2_3 = new System.Windows.Forms.Panel();
            this.color2_2 = new System.Windows.Forms.Panel();
            this.color2_1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.color2_6 = new System.Windows.Forms.Panel();
            this.color2_7 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.selected_2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.selected_label_1 = new System.Windows.Forms.Label();
            this.color_1 = new System.Windows.Forms.Panel();
            this.selected_1 = new System.Windows.Forms.Panel();
            this.color_2 = new System.Windows.Forms.Panel();
            this.color_3 = new System.Windows.Forms.Panel();
            this.color_4 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.color_5 = new System.Windows.Forms.Panel();
            this.selected_rgb_1 = new System.Windows.Forms.Label();
            this.selected_label_2 = new System.Windows.Forms.Label();
            this.selected_rgb_2 = new System.Windows.Forms.Label();
            this.start_animation = new System.Windows.Forms.Timer(this.components);
            this.maximize_timer = new System.Windows.Forms.Timer(this.components);
            this.custom_btn2 = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.create_panel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.title_doc);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1023, 31);
            this.panel1.TabIndex = 4;
            // 
            // title_doc
            // 
            this.title_doc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.title_doc.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.title_doc.ForeColor = System.Drawing.Color.LimeGreen;
            this.title_doc.Location = new System.Drawing.Point(7, 6);
            this.title_doc.Name = "title_doc";
            this.title_doc.Size = new System.Drawing.Size(393, 19);
            this.title_doc.TabIndex = 4;
            this.title_doc.Text = "Ninponix Office: Presentation";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.LimeGreen;
            this.button1.Location = new System.Drawing.Point(983, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 30);
            this.button1.TabIndex = 2;
            this.button1.TabStop = false;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(38, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "PRESENTATION";
            this.label2.UseCompatibleTextRendering = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 35F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 71);
            this.label1.TabIndex = 6;
            this.label1.Text = "Themes";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // create_panel
            // 
            this.create_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.create_panel.Controls.Add(this.create_button);
            this.create_panel.Controls.Add(this.template_title);
            this.create_panel.Controls.Add(this.document_url);
            this.create_panel.Controls.Add(this.label4);
            this.create_panel.Controls.Add(this.document_name);
            this.create_panel.Controls.Add(this.label5);
            this.create_panel.Enabled = false;
            this.create_panel.Location = new System.Drawing.Point(717, 159);
            this.create_panel.Name = "create_panel";
            this.create_panel.Size = new System.Drawing.Size(275, 414);
            this.create_panel.TabIndex = 10;
            // 
            // create_button
            // 
            this.create_button.BackColor = System.Drawing.Color.White;
            this.create_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.create_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.create_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.create_button.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.create_button.ForeColor = System.Drawing.Color.LimeGreen;
            this.create_button.Location = new System.Drawing.Point(137, 267);
            this.create_button.Name = "create_button";
            this.create_button.Size = new System.Drawing.Size(119, 32);
            this.create_button.TabIndex = 2;
            this.create_button.Text = "Create";
            this.create_button.UseVisualStyleBackColor = false;
            this.create_button.Click += new System.EventHandler(this.create_button_Click);
            // 
            // template_title
            // 
            this.template_title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.template_title.AutoSize = true;
            this.template_title.Font = new System.Drawing.Font("Segoe UI Light", 25F);
            this.template_title.ForeColor = System.Drawing.Color.White;
            this.template_title.Location = new System.Drawing.Point(18, 28);
            this.template_title.Name = "template_title";
            this.template_title.Size = new System.Drawing.Size(264, 52);
            this.template_title.TabIndex = 4;
            this.template_title.Text = "New Presentation";
            this.template_title.UseCompatibleTextRendering = true;
            // 
            // document_url
            // 
            this.document_url.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.document_url.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(220)))), ((int)(((byte)(77)))));
            this.document_url.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.document_url.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.document_url.ForeColor = System.Drawing.Color.White;
            this.document_url.FormattingEnabled = true;
            this.document_url.Location = new System.Drawing.Point(26, 201);
            this.document_url.Name = "document_url";
            this.document_url.Size = new System.Drawing.Size(230, 25);
            this.document_url.TabIndex = 1;
            this.document_url.SelectedValueChanged += new System.EventHandler(this.document_url_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(24, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 27);
            this.label4.TabIndex = 4;
            this.label4.Text = "Presentation Name:";
            this.label4.UseCompatibleTextRendering = true;
            // 
            // document_name
            // 
            this.document_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.document_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(220)))), ((int)(((byte)(77)))));
            this.document_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.document_name.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.document_name.ForeColor = System.Drawing.Color.White;
            this.document_name.Location = new System.Drawing.Point(26, 132);
            this.document_name.Name = "document_name";
            this.document_name.Size = new System.Drawing.Size(230, 25);
            this.document_name.TabIndex = 0;
            this.document_name.Text = "Presentation1";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(24, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 27);
            this.label5.TabIndex = 4;
            this.label5.Text = "Presentation Location:";
            this.label5.UseCompatibleTextRendering = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(220)))), ((int)(((byte)(77)))));
            this.panel2.Controls.Add(this.template1);
            this.panel2.Location = new System.Drawing.Point(37, 159);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(249, 414);
            this.panel2.TabIndex = 9;
            // 
            // template1
            // 
            this.template1.BackColor = System.Drawing.Color.LimeGreen;
            this.template1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.template1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.template1.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.template1.FlatAppearance.BorderSize = 0;
            this.template1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.template1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.template1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.template1.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.template1.ForeColor = System.Drawing.Color.White;
            this.template1.Image = ((System.Drawing.Image)(resources.GetObject("template1.Image")));
            this.template1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.template1.Location = new System.Drawing.Point(10, 10);
            this.template1.Name = "template1";
            this.template1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.template1.Size = new System.Drawing.Size(229, 181);
            this.template1.TabIndex = 0;
            this.template1.Text = "Blank";
            this.template1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.template1.UseVisualStyleBackColor = false;
            this.template1.Click += new System.EventHandler(this.template1_Click);
            // 
            // color2_5
            // 
            this.color2_5.BackColor = System.Drawing.Color.Orange;
            this.color2_5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.color2_5.Enabled = false;
            this.color2_5.Location = new System.Drawing.Point(445, 464);
            this.color2_5.Name = "color2_5";
            this.color2_5.Size = new System.Drawing.Size(25, 25);
            this.color2_5.TabIndex = 12;
            this.color2_5.Click += new System.EventHandler(this.panel7_Click);
            // 
            // color_2_4
            // 
            this.color_2_4.BackColor = System.Drawing.Color.OrangeRed;
            this.color_2_4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.color_2_4.Enabled = false;
            this.color_2_4.Location = new System.Drawing.Point(414, 464);
            this.color_2_4.Name = "color_2_4";
            this.color_2_4.Size = new System.Drawing.Size(25, 25);
            this.color_2_4.TabIndex = 13;
            this.color_2_4.Click += new System.EventHandler(this.panel6_Click);
            // 
            // color_2_3
            // 
            this.color_2_3.BackColor = System.Drawing.Color.LimeGreen;
            this.color_2_3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.color_2_3.Enabled = false;
            this.color_2_3.Location = new System.Drawing.Point(383, 464);
            this.color_2_3.Name = "color_2_3";
            this.color_2_3.Size = new System.Drawing.Size(25, 25);
            this.color_2_3.TabIndex = 14;
            this.color_2_3.Click += new System.EventHandler(this.panel5_Click);
            // 
            // color2_2
            // 
            this.color2_2.BackColor = System.Drawing.Color.DodgerBlue;
            this.color2_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.color2_2.Enabled = false;
            this.color2_2.Location = new System.Drawing.Point(352, 464);
            this.color2_2.Name = "color2_2";
            this.color2_2.Size = new System.Drawing.Size(25, 25);
            this.color2_2.TabIndex = 15;
            this.color2_2.Click += new System.EventHandler(this.panel4_Click);
            // 
            // color2_1
            // 
            this.color2_1.BackColor = System.Drawing.Color.Black;
            this.color2_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.color2_1.Enabled = false;
            this.color2_1.Location = new System.Drawing.Point(321, 464);
            this.color2_1.Name = "color2_1";
            this.color2_1.Size = new System.Drawing.Size(25, 25);
            this.color2_1.TabIndex = 16;
            this.color2_1.Click += new System.EventHandler(this.panel3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(321, 375);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Text Color:";
            this.label3.UseCompatibleTextRendering = true;
            // 
            // color2_6
            // 
            this.color2_6.BackColor = System.Drawing.Color.Purple;
            this.color2_6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.color2_6.Enabled = false;
            this.color2_6.Location = new System.Drawing.Point(476, 464);
            this.color2_6.Name = "color2_6";
            this.color2_6.Size = new System.Drawing.Size(25, 25);
            this.color2_6.TabIndex = 12;
            this.color2_6.Click += new System.EventHandler(this.panel8_Click);
            // 
            // color2_7
            // 
            this.color2_7.BackColor = System.Drawing.Color.Magenta;
            this.color2_7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.color2_7.Enabled = false;
            this.color2_7.Location = new System.Drawing.Point(507, 464);
            this.color2_7.Name = "color2_7";
            this.color2_7.Size = new System.Drawing.Size(25, 25);
            this.color2_7.TabIndex = 12;
            this.color2_7.Click += new System.EventHandler(this.panel9_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.DarkGreen;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.Enabled = false;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.linkLabel1.LinkColor = System.Drawing.Color.Green;
            this.linkLabel1.Location = new System.Drawing.Point(537, 470);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(54, 19);
            this.linkLabel1.TabIndex = 17;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Custom";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Green;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // selected_2
            // 
            this.selected_2.BackColor = System.Drawing.Color.Black;
            this.selected_2.Enabled = false;
            this.selected_2.Location = new System.Drawing.Point(321, 403);
            this.selected_2.Name = "selected_2";
            this.selected_2.Size = new System.Drawing.Size(50, 50);
            this.selected_2.TabIndex = 16;
            this.selected_2.BackColorChanged += new System.EventHandler(this.selected_2_BackColorChanged);
            this.selected_2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.selected_2_MouseDoubleClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(321, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "Accent Color:";
            this.label7.UseCompatibleTextRendering = true;
            // 
            // selected_label_1
            // 
            this.selected_label_1.AutoSize = true;
            this.selected_label_1.Enabled = false;
            this.selected_label_1.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.selected_label_1.ForeColor = System.Drawing.Color.White;
            this.selected_label_1.Location = new System.Drawing.Point(377, 276);
            this.selected_label_1.Name = "selected_label_1";
            this.selected_label_1.Size = new System.Drawing.Size(38, 21);
            this.selected_label_1.TabIndex = 11;
            this.selected_label_1.Text = "Purple";
            this.selected_label_1.UseCompatibleTextRendering = true;
            // 
            // color_1
            // 
            this.color_1.BackColor = System.Drawing.Color.Purple;
            this.color_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.color_1.Enabled = false;
            this.color_1.Location = new System.Drawing.Point(321, 331);
            this.color_1.Name = "color_1";
            this.color_1.Size = new System.Drawing.Size(25, 25);
            this.color_1.TabIndex = 16;
            this.color_1.Click += new System.EventHandler(this.panel11_Click);
            // 
            // selected_1
            // 
            this.selected_1.BackColor = System.Drawing.Color.Purple;
            this.selected_1.Enabled = false;
            this.selected_1.Location = new System.Drawing.Point(321, 270);
            this.selected_1.Name = "selected_1";
            this.selected_1.Size = new System.Drawing.Size(50, 50);
            this.selected_1.TabIndex = 16;
            this.selected_1.BackColorChanged += new System.EventHandler(this.selected_1_BackColorChanged);
            // 
            // color_2
            // 
            this.color_2.BackColor = System.Drawing.Color.DodgerBlue;
            this.color_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.color_2.Enabled = false;
            this.color_2.Location = new System.Drawing.Point(352, 331);
            this.color_2.Name = "color_2";
            this.color_2.Size = new System.Drawing.Size(25, 25);
            this.color_2.TabIndex = 15;
            this.color_2.Click += new System.EventHandler(this.panel13_Click);
            // 
            // color_3
            // 
            this.color_3.BackColor = System.Drawing.Color.LimeGreen;
            this.color_3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.color_3.Enabled = false;
            this.color_3.Location = new System.Drawing.Point(383, 331);
            this.color_3.Name = "color_3";
            this.color_3.Size = new System.Drawing.Size(25, 25);
            this.color_3.TabIndex = 14;
            this.color_3.Click += new System.EventHandler(this.panel14_Click);
            // 
            // color_4
            // 
            this.color_4.BackColor = System.Drawing.Color.Black;
            this.color_4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.color_4.Enabled = false;
            this.color_4.Location = new System.Drawing.Point(414, 331);
            this.color_4.Name = "color_4";
            this.color_4.Size = new System.Drawing.Size(25, 25);
            this.color_4.TabIndex = 13;
            this.color_4.Click += new System.EventHandler(this.panel15_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Light", 25F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(314, 174);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 52);
            this.label9.TabIndex = 6;
            this.label9.Text = "Blank";
            this.label9.UseCompatibleTextRendering = true;
            // 
            // color_5
            // 
            this.color_5.BackColor = System.Drawing.Color.OrangeRed;
            this.color_5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.color_5.Enabled = false;
            this.color_5.Location = new System.Drawing.Point(445, 331);
            this.color_5.Name = "color_5";
            this.color_5.Size = new System.Drawing.Size(25, 25);
            this.color_5.TabIndex = 12;
            this.color_5.Click += new System.EventHandler(this.panel16_Click);
            // 
            // selected_rgb_1
            // 
            this.selected_rgb_1.AutoSize = true;
            this.selected_rgb_1.Enabled = false;
            this.selected_rgb_1.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.selected_rgb_1.ForeColor = System.Drawing.Color.White;
            this.selected_rgb_1.Location = new System.Drawing.Point(377, 295);
            this.selected_rgb_1.Name = "selected_rgb_1";
            this.selected_rgb_1.Size = new System.Drawing.Size(74, 21);
            this.selected_rgb_1.TabIndex = 11;
            this.selected_rgb_1.Text = "(255,255,255)";
            this.selected_rgb_1.UseCompatibleTextRendering = true;
            // 
            // selected_label_2
            // 
            this.selected_label_2.AutoSize = true;
            this.selected_label_2.Enabled = false;
            this.selected_label_2.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.selected_label_2.ForeColor = System.Drawing.Color.White;
            this.selected_label_2.Location = new System.Drawing.Point(377, 408);
            this.selected_label_2.Name = "selected_label_2";
            this.selected_label_2.Size = new System.Drawing.Size(31, 21);
            this.selected_label_2.TabIndex = 11;
            this.selected_label_2.Text = "Black";
            this.selected_label_2.UseCompatibleTextRendering = true;
            // 
            // selected_rgb_2
            // 
            this.selected_rgb_2.AutoSize = true;
            this.selected_rgb_2.Enabled = false;
            this.selected_rgb_2.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.selected_rgb_2.ForeColor = System.Drawing.Color.White;
            this.selected_rgb_2.Location = new System.Drawing.Point(377, 427);
            this.selected_rgb_2.Name = "selected_rgb_2";
            this.selected_rgb_2.Size = new System.Drawing.Size(36, 21);
            this.selected_rgb_2.TabIndex = 11;
            this.selected_rgb_2.Text = "(0,0,0)";
            this.selected_rgb_2.UseCompatibleTextRendering = true;
            // 
            // start_animation
            // 
            this.start_animation.Enabled = true;
            this.start_animation.Interval = 1;
            this.start_animation.Tick += new System.EventHandler(this.start_animation_Tick);
            // 
            // maximize_timer
            // 
            this.maximize_timer.Enabled = true;
            this.maximize_timer.Interval = 1;
            this.maximize_timer.Tick += new System.EventHandler(this.maximize_timer_Tick);
            // 
            // custom_btn2
            // 
            this.custom_btn2.ActiveLinkColor = System.Drawing.Color.DarkGreen;
            this.custom_btn2.AutoSize = true;
            this.custom_btn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.custom_btn2.Enabled = false;
            this.custom_btn2.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.custom_btn2.LinkColor = System.Drawing.Color.Green;
            this.custom_btn2.Location = new System.Drawing.Point(478, 337);
            this.custom_btn2.Name = "custom_btn2";
            this.custom_btn2.Size = new System.Drawing.Size(54, 19);
            this.custom_btn2.TabIndex = 17;
            this.custom_btn2.TabStop = true;
            this.custom_btn2.Text = "Custom";
            this.custom_btn2.VisitedLinkColor = System.Drawing.Color.Green;
            this.custom_btn2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.custom_btn2_LinkClicked);
            // 
            // Presentation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(1023, 644);
            this.Controls.Add(this.custom_btn2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.color2_7);
            this.Controls.Add(this.color2_6);
            this.Controls.Add(this.color_5);
            this.Controls.Add(this.color2_5);
            this.Controls.Add(this.color_4);
            this.Controls.Add(this.color_2_4);
            this.Controls.Add(this.color_3);
            this.Controls.Add(this.color_2_3);
            this.Controls.Add(this.color_2);
            this.Controls.Add(this.color2_2);
            this.Controls.Add(this.selected_1);
            this.Controls.Add(this.selected_2);
            this.Controls.Add(this.color_1);
            this.Controls.Add(this.color2_1);
            this.Controls.Add(this.selected_rgb_2);
            this.Controls.Add(this.selected_rgb_1);
            this.Controls.Add(this.selected_label_2);
            this.Controls.Add(this.selected_label_1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.create_panel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Presentation";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ninponix Office: Presentation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Presentation_FormClosing);
            this.Load += new System.EventHandler(this.Presentation_Load);
            this.panel1.ResumeLayout(false);
            this.create_panel.ResumeLayout(false);
            this.create_panel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label title_doc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel create_panel;
        private System.Windows.Forms.Button create_button;
        private System.Windows.Forms.Label template_title;
        private System.Windows.Forms.ComboBox document_url;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox document_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button template1;
        private System.Windows.Forms.Panel color2_5;
        private System.Windows.Forms.Panel color_2_4;
        private System.Windows.Forms.Panel color_2_3;
        private System.Windows.Forms.Panel color2_2;
        private System.Windows.Forms.Panel color2_1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel color2_6;
        private System.Windows.Forms.Panel color2_7;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel selected_2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label selected_label_1;
        private System.Windows.Forms.Panel color_1;
        private System.Windows.Forms.Panel selected_1;
        private System.Windows.Forms.Panel color_2;
        private System.Windows.Forms.Panel color_3;
        private System.Windows.Forms.Panel color_4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel color_5;
        private System.Windows.Forms.Label selected_rgb_1;
        private System.Windows.Forms.Label selected_label_2;
        private System.Windows.Forms.Label selected_rgb_2;
        private System.Windows.Forms.Timer start_animation;
        private System.Windows.Forms.Timer maximize_timer;
        private System.Windows.Forms.LinkLabel custom_btn2;
    }
}