namespace Ninponix_Office
{
    partial class Presentation_Editor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Presentation_Editor));
            this.panel1 = new System.Windows.Forms.Panel();
            this.code_box = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.maximize_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.title_doc = new System.Windows.Forms.Label();
            this.panel_not_implemented = new System.Windows.Forms.Panel();
            this.start_animation = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.status = new System.Windows.Forms.Label();
            this.normal_timer = new System.Windows.Forms.Timer(this.components);
            this.maximize_timer = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.style_management_btn = new System.Windows.Forms.Button();
            this.presentation_information = new System.Windows.Forms.Button();
            this.slide_management = new System.Windows.Forms.Button();
            this.add_style_btn = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.add_image_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.slide_container = new System.Windows.Forms.Panel();
            this.previous_slide = new System.Windows.Forms.Button();
            this.next_slide = new System.Windows.Forms.Button();
            this.slide = new System.Windows.Forms.Panel();
            this.menu_panel = new System.Windows.Forms.Panel();
            this.button19 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.menu_animation = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.RecoveryTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.slide_container.SuspendLayout();
            this.menu_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LimeGreen;
            this.panel1.Controls.Add(this.code_box);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.maximize_btn);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.title_doc);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(999, 30);
            this.panel1.TabIndex = 5;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // code_box
            // 
            this.code_box.AcceptsTab = true;
            this.code_box.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.code_box.BackColor = System.Drawing.Color.Green;
            this.code_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.code_box.Font = new System.Drawing.Font("Consolas", 10F);
            this.code_box.ForeColor = System.Drawing.Color.White;
            this.code_box.Location = new System.Drawing.Point(11, 77);
            this.code_box.Name = "code_box";
            this.code_box.Size = new System.Drawing.Size(976, 0);
            this.code_box.TabIndex = 6;
            this.code_box.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Script in NVL (Presentation):";
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.Location = new System.Drawing.Point(811, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(23, 30);
            this.button4.TabIndex = 2;
            this.button4.TabStop = false;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            this.button4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Presentation_Editor_KeyDown);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.Location = new System.Drawing.Point(840, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(23, 30);
            this.button3.TabIndex = 2;
            this.button3.TabStop = false;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.button3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Presentation_Editor_KeyDown);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.Location = new System.Drawing.Point(873, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 30);
            this.button2.TabIndex = 2;
            this.button2.TabStop = false;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Presentation_Editor_KeyDown);
            // 
            // maximize_btn
            // 
            this.maximize_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximize_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("maximize_btn.BackgroundImage")));
            this.maximize_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.maximize_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.maximize_btn.FlatAppearance.BorderSize = 0;
            this.maximize_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximize_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maximize_btn.ForeColor = System.Drawing.Color.White;
            this.maximize_btn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.maximize_btn.Location = new System.Drawing.Point(916, 0);
            this.maximize_btn.Name = "maximize_btn";
            this.maximize_btn.Size = new System.Drawing.Size(40, 30);
            this.maximize_btn.TabIndex = 2;
            this.maximize_btn.TabStop = false;
            this.maximize_btn.UseVisualStyleBackColor = true;
            this.maximize_btn.Click += new System.EventHandler(this.maximize_btn_Click);
            this.maximize_btn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Presentation_Editor_KeyDown);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(959, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 30);
            this.button1.TabIndex = 2;
            this.button1.TabStop = false;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Presentation_Editor_KeyDown);
            // 
            // title_doc
            // 
            this.title_doc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.title_doc.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.title_doc.ForeColor = System.Drawing.Color.White;
            this.title_doc.Location = new System.Drawing.Point(7, 6);
            this.title_doc.Name = "title_doc";
            this.title_doc.Size = new System.Drawing.Size(790, 19);
            this.title_doc.TabIndex = 4;
            this.title_doc.Text = "Ninponix Office: Presentation";
            // 
            // panel_not_implemented
            // 
            this.panel_not_implemented.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_not_implemented.Location = new System.Drawing.Point(999, 30);
            this.panel_not_implemented.Name = "panel_not_implemented";
            this.panel_not_implemented.Size = new System.Drawing.Size(0, 505);
            this.panel_not_implemented.TabIndex = 8;
            // 
            // start_animation
            // 
            this.start_animation.Enabled = true;
            this.start_animation.Interval = 1;
            this.start_animation.Tick += new System.EventHandler(this.start_animation_Tick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LimeGreen;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.status);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 510);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(999, 25);
            this.panel3.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.LimeGreen;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(932, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "</>";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(973, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(26, 25);
            this.panel4.TabIndex = 5;
            this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            this.panel4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(15, 10);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(2, 10);
            this.panel5.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(7, 19);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(10, 2);
            this.panel6.TabIndex = 0;
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.status.ForeColor = System.Drawing.Color.White;
            this.status.Location = new System.Drawing.Point(7, 5);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(38, 15);
            this.status.TabIndex = 4;
            this.status.Text = "Ready";
            // 
            // normal_timer
            // 
            this.normal_timer.Interval = 1;
            this.normal_timer.Tick += new System.EventHandler(this.normal_timer_Tick);
            // 
            // maximize_timer
            // 
            this.maximize_timer.Enabled = true;
            this.maximize_timer.Interval = 1;
            this.maximize_timer.Tick += new System.EventHandler(this.maximize_timer_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LimeGreen;
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(74, 480);
            this.panel2.TabIndex = 12;
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Controls.Add(this.style_management_btn);
            this.panel7.Controls.Add(this.presentation_information);
            this.panel7.Controls.Add(this.slide_management);
            this.panel7.Controls.Add(this.add_style_btn);
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.add_image_btn);
            this.panel7.Controls.Add(this.add_btn);
            this.panel7.Location = new System.Drawing.Point(1, 31);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(74, 449);
            this.panel7.TabIndex = 6;
            // 
            // style_management_btn
            // 
            this.style_management_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.style_management_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("style_management_btn.BackgroundImage")));
            this.style_management_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.style_management_btn.FlatAppearance.BorderSize = 0;
            this.style_management_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.style_management_btn.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.style_management_btn.ForeColor = System.Drawing.Color.LimeGreen;
            this.style_management_btn.Location = new System.Drawing.Point(5, 89);
            this.style_management_btn.Name = "style_management_btn";
            this.style_management_btn.Size = new System.Drawing.Size(30, 30);
            this.style_management_btn.TabIndex = 14;
            this.toolTip1.SetToolTip(this.style_management_btn, "Manage Styles");
            this.style_management_btn.UseVisualStyleBackColor = true;
            this.style_management_btn.Click += new System.EventHandler(this.style_management_btn_Click);
            this.style_management_btn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Presentation_Editor_KeyDown);
            // 
            // presentation_information
            // 
            this.presentation_information.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.presentation_information.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("presentation_information.BackgroundImage")));
            this.presentation_information.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.presentation_information.FlatAppearance.BorderSize = 0;
            this.presentation_information.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.presentation_information.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.presentation_information.ForeColor = System.Drawing.Color.LimeGreen;
            this.presentation_information.Location = new System.Drawing.Point(5, 124);
            this.presentation_information.Name = "presentation_information";
            this.presentation_information.Size = new System.Drawing.Size(30, 30);
            this.presentation_information.TabIndex = 7;
            this.toolTip1.SetToolTip(this.presentation_information, "Manage Presentation Information");
            this.presentation_information.UseVisualStyleBackColor = true;
            this.presentation_information.Click += new System.EventHandler(this.presentation_information_Click);
            this.presentation_information.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Presentation_Editor_KeyDown);
            // 
            // slide_management
            // 
            this.slide_management.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.slide_management.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("slide_management.BackgroundImage")));
            this.slide_management.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.slide_management.FlatAppearance.BorderSize = 0;
            this.slide_management.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.slide_management.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.slide_management.ForeColor = System.Drawing.Color.LimeGreen;
            this.slide_management.Location = new System.Drawing.Point(39, 89);
            this.slide_management.Name = "slide_management";
            this.slide_management.Size = new System.Drawing.Size(30, 30);
            this.slide_management.TabIndex = 6;
            this.toolTip1.SetToolTip(this.slide_management, "Manage Slides");
            this.slide_management.UseVisualStyleBackColor = true;
            this.slide_management.Click += new System.EventHandler(this.slide_management_Click);
            this.slide_management.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Presentation_Editor_KeyDown);
            // 
            // add_style_btn
            // 
            this.add_style_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.add_style_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("add_style_btn.BackgroundImage")));
            this.add_style_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.add_style_btn.FlatAppearance.BorderSize = 0;
            this.add_style_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_style_btn.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.add_style_btn.ForeColor = System.Drawing.Color.LimeGreen;
            this.add_style_btn.Location = new System.Drawing.Point(5, 42);
            this.add_style_btn.Name = "add_style_btn";
            this.add_style_btn.Size = new System.Drawing.Size(30, 30);
            this.add_style_btn.TabIndex = 5;
            this.toolTip1.SetToolTip(this.add_style_btn, "Create Style");
            this.add_style_btn.UseVisualStyleBackColor = true;
            this.add_style_btn.Click += new System.EventHandler(this.add_style_btn_Click);
            this.add_style_btn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Presentation_Editor_KeyDown);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.LimeGreen;
            this.panel8.Location = new System.Drawing.Point(0, 80);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(74, 2);
            this.panel8.TabIndex = 4;
            // 
            // add_image_btn
            // 
            this.add_image_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.add_image_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("add_image_btn.BackgroundImage")));
            this.add_image_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.add_image_btn.FlatAppearance.BorderSize = 0;
            this.add_image_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_image_btn.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.add_image_btn.ForeColor = System.Drawing.Color.LimeGreen;
            this.add_image_btn.Location = new System.Drawing.Point(39, 6);
            this.add_image_btn.Name = "add_image_btn";
            this.add_image_btn.Size = new System.Drawing.Size(30, 30);
            this.add_image_btn.TabIndex = 1;
            this.toolTip1.SetToolTip(this.add_image_btn, "Add Image");
            this.add_image_btn.UseVisualStyleBackColor = true;
            this.add_image_btn.Click += new System.EventHandler(this.add_image_btn_Click);
            this.add_image_btn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Presentation_Editor_KeyDown);
            // 
            // add_btn
            // 
            this.add_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.add_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("add_btn.BackgroundImage")));
            this.add_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.add_btn.FlatAppearance.BorderSize = 0;
            this.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_btn.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.add_btn.ForeColor = System.Drawing.Color.LimeGreen;
            this.add_btn.Location = new System.Drawing.Point(5, 6);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(30, 30);
            this.add_btn.TabIndex = 0;
            this.toolTip1.SetToolTip(this.add_btn, "Add Text");
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            this.add_btn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Presentation_Editor_KeyDown);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(7, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "TOOLBOX";
            // 
            // slide_container
            // 
            this.slide_container.AutoScroll = true;
            this.slide_container.BackColor = System.Drawing.SystemColors.Control;
            this.slide_container.Controls.Add(this.previous_slide);
            this.slide_container.Controls.Add(this.next_slide);
            this.slide_container.Controls.Add(this.slide);
            this.slide_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slide_container.Location = new System.Drawing.Point(74, 30);
            this.slide_container.Name = "slide_container";
            this.slide_container.Size = new System.Drawing.Size(925, 480);
            this.slide_container.TabIndex = 13;
            // 
            // previous_slide
            // 
            this.previous_slide.Dock = System.Windows.Forms.DockStyle.Left;
            this.previous_slide.Enabled = false;
            this.previous_slide.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.previous_slide.FlatAppearance.BorderSize = 0;
            this.previous_slide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.previous_slide.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previous_slide.ForeColor = System.Drawing.Color.LimeGreen;
            this.previous_slide.Location = new System.Drawing.Point(0, 0);
            this.previous_slide.Name = "previous_slide";
            this.previous_slide.Size = new System.Drawing.Size(40, 480);
            this.previous_slide.TabIndex = 6;
            this.previous_slide.Text = "<";
            this.previous_slide.UseVisualStyleBackColor = true;
            this.previous_slide.Click += new System.EventHandler(this.previous_slide_Click_1);
            // 
            // next_slide
            // 
            this.next_slide.Dock = System.Windows.Forms.DockStyle.Right;
            this.next_slide.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.next_slide.FlatAppearance.BorderSize = 0;
            this.next_slide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.next_slide.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next_slide.ForeColor = System.Drawing.Color.LimeGreen;
            this.next_slide.Location = new System.Drawing.Point(885, 0);
            this.next_slide.Name = "next_slide";
            this.next_slide.Size = new System.Drawing.Size(40, 480);
            this.next_slide.TabIndex = 5;
            this.next_slide.Text = ">";
            this.next_slide.UseVisualStyleBackColor = true;
            this.next_slide.Click += new System.EventHandler(this.next_slide_Click_1);
            // 
            // slide
            // 
            this.slide.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.slide.BackColor = System.Drawing.Color.White;
            this.slide.Location = new System.Drawing.Point(87, 63);
            this.slide.Name = "slide";
            this.slide.Size = new System.Drawing.Size(718, 365);
            this.slide.TabIndex = 4;
            // 
            // menu_panel
            // 
            this.menu_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.menu_panel.BackColor = System.Drawing.Color.LimeGreen;
            this.menu_panel.Controls.Add(this.button19);
            this.menu_panel.Controls.Add(this.button15);
            this.menu_panel.Controls.Add(this.button14);
            this.menu_panel.Controls.Add(this.button13);
            this.menu_panel.Controls.Add(this.button12);
            this.menu_panel.Controls.Add(this.button11);
            this.menu_panel.Controls.Add(this.button10);
            this.menu_panel.Controls.Add(this.button9);
            this.menu_panel.Location = new System.Drawing.Point(723, 39);
            this.menu_panel.Name = "menu_panel";
            this.menu_panel.Size = new System.Drawing.Size(200, 260);
            this.menu_panel.TabIndex = 14;
            // 
            // button19
            // 
            this.button19.FlatAppearance.BorderSize = 0;
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button19.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button19.ForeColor = System.Drawing.Color.White;
            this.button19.Location = new System.Drawing.Point(1, 160);
            this.button19.Name = "button19";
            this.button19.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button19.Size = new System.Drawing.Size(196, 27);
            this.button19.TabIndex = 6;
            this.button19.Text = "Export...";
            this.button19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            this.button19.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Presentation_Editor_KeyDown);
            // 
            // button15
            // 
            this.button15.FlatAppearance.BorderSize = 0;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.ForeColor = System.Drawing.Color.White;
            this.button15.Location = new System.Drawing.Point(2, 229);
            this.button15.Name = "button15";
            this.button15.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button15.Size = new System.Drawing.Size(196, 27);
            this.button15.TabIndex = 5;
            this.button15.Text = "Exit";
            this.button15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            this.button15.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Presentation_Editor_KeyDown);
            // 
            // button14
            // 
            this.button14.FlatAppearance.BorderSize = 0;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.ForeColor = System.Drawing.Color.White;
            this.button14.Location = new System.Drawing.Point(1, 196);
            this.button14.Name = "button14";
            this.button14.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button14.Size = new System.Drawing.Size(196, 27);
            this.button14.TabIndex = 4;
            this.button14.Text = "Help";
            this.button14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            this.button14.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Presentation_Editor_KeyDown);
            // 
            // button13
            // 
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.ForeColor = System.Drawing.Color.White;
            this.button13.Location = new System.Drawing.Point(2, 130);
            this.button13.Name = "button13";
            this.button13.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button13.Size = new System.Drawing.Size(196, 27);
            this.button13.TabIndex = 3;
            this.button13.Text = "Run";
            this.button13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            this.button13.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Presentation_Editor_KeyDown);
            // 
            // button12
            // 
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.ForeColor = System.Drawing.Color.White;
            this.button12.Location = new System.Drawing.Point(2, 92);
            this.button12.Name = "button12";
            this.button12.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button12.Size = new System.Drawing.Size(196, 27);
            this.button12.TabIndex = 2;
            this.button12.Text = "Save As...";
            this.button12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            this.button12.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Presentation_Editor_KeyDown);
            // 
            // button11
            // 
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.Color.White;
            this.button11.Location = new System.Drawing.Point(2, 62);
            this.button11.Name = "button11";
            this.button11.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button11.Size = new System.Drawing.Size(196, 27);
            this.button11.TabIndex = 1;
            this.button11.Text = "Save";
            this.button11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            this.button11.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Presentation_Editor_KeyDown);
            // 
            // button10
            // 
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Location = new System.Drawing.Point(2, 32);
            this.button10.Name = "button10";
            this.button10.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button10.Size = new System.Drawing.Size(196, 27);
            this.button10.TabIndex = 0;
            this.button10.Text = "Open";
            this.button10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            this.button10.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Presentation_Editor_KeyDown);
            // 
            // button9
            // 
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(2, 2);
            this.button9.Name = "button9";
            this.button9.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button9.Size = new System.Drawing.Size(196, 27);
            this.button9.TabIndex = 0;
            this.button9.Text = "New";
            this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click_1);
            this.button9.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Presentation_Editor_KeyDown);
            // 
            // menu_animation
            // 
            this.menu_animation.Enabled = true;
            this.menu_animation.Interval = 1;
            this.menu_animation.Tick += new System.EventHandler(this.menu_animation_Tick);
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.White;
            this.toolTip1.ForeColor = System.Drawing.Color.LimeGreen;
            // 
            // RecoveryTimer
            // 
            this.RecoveryTimer.Enabled = true;
            this.RecoveryTimer.Interval = 60000;
            this.RecoveryTimer.Tick += new System.EventHandler(this.RecoveryTimer_Tick);
            // 
            // Presentation_Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(999, 535);
            this.Controls.Add(this.menu_panel);
            this.Controls.Add(this.slide_container);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel_not_implemented);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Presentation_Editor";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ninponix Office Presentation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Presentation_Editor_FormClosing);
            this.Load += new System.EventHandler(this.Presentation_Editor_Load);
            this.TextChanged += new System.EventHandler(this.Presentation_Editor_TextChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Presentation_Editor_KeyDown);
            this.Resize += new System.EventHandler(this.Presentation_Editor_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.slide_container.ResumeLayout(false);
            this.menu_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label title_doc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel_not_implemented;
        private System.Windows.Forms.Timer start_animation;
        private System.Windows.Forms.Button maximize_btn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Timer normal_timer;
        private System.Windows.Forms.Timer maximize_timer;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox code_box;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel slide_container;
        private System.Windows.Forms.Button previous_slide;
        private System.Windows.Forms.Button next_slide;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel slide;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button add_image_btn;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button presentation_information;
        private System.Windows.Forms.Button slide_management;
        private System.Windows.Forms.Button add_style_btn;
        private System.Windows.Forms.Button style_management_btn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel menu_panel;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Timer menu_animation;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Timer RecoveryTimer;
    }
}