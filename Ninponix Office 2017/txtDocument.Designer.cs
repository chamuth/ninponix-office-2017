namespace Ninponix_Office
{
    partial class txtDocument
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(txtDocument));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.min_button = new System.Windows.Forms.Button();
            this.maxbutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.max_animation = new System.Windows.Forms.Timer(this.components);
            this.min_animation = new System.Windows.Forms.Timer(this.components);
            this.mize_animation = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel6 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.RichTextBox();
            this.menu_pane = new System.Windows.Forms.Panel();
            this.new_pane = new System.Windows.Forms.Panel();
            this.button21 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.expansion_pane = new System.Windows.Forms.Panel();
            this.button11 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button19 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button16 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menu_animation = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lines_count = new System.Windows.Forms.Label();
            this.word_count = new System.Windows.Forms.Label();
            this.char_count = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.new_animation = new System.Windows.Forms.Timer(this.components);
            this.autosave_timer = new System.Windows.Forms.Timer(this.components);
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.menu_pane.SuspendLayout();
            this.new_pane.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.min_button);
            this.panel1.Controls.Add(this.maxbutton);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 91);
            this.panel1.TabIndex = 0;
            this.panel1.DoubleClick += new System.EventHandler(this.maxbutton_Click);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(25, 33);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 25);
            this.button2.TabIndex = 9;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // min_button
            // 
            this.min_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.min_button.BackColor = System.Drawing.Color.White;
            this.min_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.min_button.FlatAppearance.BorderSize = 0;
            this.min_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.min_button.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.min_button.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.min_button.Image = ((System.Drawing.Image)(resources.GetObject("min_button.Image")));
            this.min_button.Location = new System.Drawing.Point(829, 1);
            this.min_button.Name = "min_button";
            this.min_button.Size = new System.Drawing.Size(40, 30);
            this.min_button.TabIndex = 8;
            this.min_button.TabStop = false;
            this.min_button.UseVisualStyleBackColor = false;
            this.min_button.Click += new System.EventHandler(this.min_button_Click);
            // 
            // maxbutton
            // 
            this.maxbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maxbutton.BackColor = System.Drawing.Color.White;
            this.maxbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.maxbutton.FlatAppearance.BorderSize = 0;
            this.maxbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maxbutton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxbutton.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.maxbutton.Image = ((System.Drawing.Image)(resources.GetObject("maxbutton.Image")));
            this.maxbutton.Location = new System.Drawing.Point(869, 1);
            this.maxbutton.Name = "maxbutton";
            this.maxbutton.Size = new System.Drawing.Size(40, 30);
            this.maxbutton.TabIndex = 7;
            this.maxbutton.TabStop = false;
            this.maxbutton.UseVisualStyleBackColor = false;
            this.maxbutton.Click += new System.EventHandler(this.maxbutton_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.Location = new System.Drawing.Point(909, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 30);
            this.button1.TabIndex = 6;
            this.button1.TabStop = false;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // title
            // 
            this.title.Font = new System.Drawing.Font("Segoe UI Light", 20F);
            this.title.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.title.Location = new System.Drawing.Point(61, 26);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(380, 37);
            this.title.TabIndex = 0;
            this.title.Text = "New Text Document";
            // 
            // max_animation
            // 
            this.max_animation.Interval = 1;
            this.max_animation.Tick += new System.EventHandler(this.max_animation_Tick);
            // 
            // min_animation
            // 
            this.min_animation.Enabled = true;
            this.min_animation.Interval = 1;
            this.min_animation.Tick += new System.EventHandler(this.min_animation_Tick);
            // 
            // mize_animation
            // 
            this.mize_animation.Interval = 1;
            this.mize_animation.Tick += new System.EventHandler(this.mize_animation_Tick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.textBox1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 91);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(950, 529);
            this.panel6.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(8, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(932, 511);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "";
            this.textBox1.SelectionChanged += new System.EventHandler(this.textBox1_SelectionChanged);
            this.textBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseClick);
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // menu_pane
            // 
            this.menu_pane.AutoScroll = true;
            this.menu_pane.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.menu_pane.Controls.Add(this.new_pane);
            this.menu_pane.Controls.Add(this.expansion_pane);
            this.menu_pane.Controls.Add(this.button11);
            this.menu_pane.Controls.Add(this.label6);
            this.menu_pane.Controls.Add(this.button19);
            this.menu_pane.Controls.Add(this.button18);
            this.menu_pane.Controls.Add(this.button17);
            this.menu_pane.Controls.Add(this.label5);
            this.menu_pane.Controls.Add(this.checkBox1);
            this.menu_pane.Controls.Add(this.button16);
            this.menu_pane.Controls.Add(this.label4);
            this.menu_pane.Controls.Add(this.button15);
            this.menu_pane.Controls.Add(this.button14);
            this.menu_pane.Controls.Add(this.button8);
            this.menu_pane.Controls.Add(this.button9);
            this.menu_pane.Controls.Add(this.button10);
            this.menu_pane.Controls.Add(this.button12);
            this.menu_pane.Controls.Add(this.label3);
            this.menu_pane.Controls.Add(this.button7);
            this.menu_pane.Controls.Add(this.button6);
            this.menu_pane.Controls.Add(this.button5);
            this.menu_pane.Controls.Add(this.button4);
            this.menu_pane.Controls.Add(this.button3);
            this.menu_pane.Controls.Add(this.label1);
            this.menu_pane.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu_pane.Location = new System.Drawing.Point(0, 91);
            this.menu_pane.Name = "menu_pane";
            this.menu_pane.Size = new System.Drawing.Size(197, 529);
            this.menu_pane.TabIndex = 4;
            this.menu_pane.Paint += new System.Windows.Forms.PaintEventHandler(this.menu_pane_Paint);
            this.menu_pane.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menu_pane_MouseClick);
            // 
            // new_pane
            // 
            this.new_pane.BackColor = System.Drawing.Color.White;
            this.new_pane.Controls.Add(this.button21);
            this.new_pane.Controls.Add(this.button20);
            this.new_pane.Location = new System.Drawing.Point(67, 54);
            this.new_pane.Name = "new_pane";
            this.new_pane.Size = new System.Drawing.Size(102, 45);
            this.new_pane.TabIndex = 26;
            this.new_pane.Visible = false;
            // 
            // button21
            // 
            this.button21.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button21.Font = new System.Drawing.Font("Segoe UI Light", 8F);
            this.button21.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.button21.Location = new System.Drawing.Point(0, 22);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(102, 23);
            this.button21.TabIndex = 1;
            this.button21.Text = "New Window";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // button20
            // 
            this.button20.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button20.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button20.Font = new System.Drawing.Font("Segoe UI Light", 8F);
            this.button20.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.button20.Location = new System.Drawing.Point(0, 0);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(102, 23);
            this.button20.TabIndex = 0;
            this.button20.Text = "This Window";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // expansion_pane
            // 
            this.expansion_pane.Location = new System.Drawing.Point(11, 780);
            this.expansion_pane.Name = "expansion_pane";
            this.expansion_pane.Size = new System.Drawing.Size(159, 7);
            this.expansion_pane.TabIndex = 25;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.White;
            this.button11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.button11.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.button11.Location = new System.Drawing.Point(12, 593);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(157, 30);
            this.button11.TabIndex = 24;
            this.button11.Text = "Change Font Color";
            this.button11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(112, 771);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 21);
            this.label6.TabIndex = 23;
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.White;
            this.button19.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button19.FlatAppearance.BorderSize = 0;
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button19.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.button19.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.button19.Location = new System.Drawing.Point(12, 745);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(157, 30);
            this.button19.TabIndex = 22;
            this.button19.Text = "Feedback";
            this.button19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.White;
            this.button18.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button18.FlatAppearance.BorderSize = 0;
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.button18.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.button18.Location = new System.Drawing.Point(12, 709);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(157, 30);
            this.button18.TabIndex = 21;
            this.button18.Text = "Online Forum";
            this.button18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.White;
            this.button17.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button17.FlatAppearance.BorderSize = 0;
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button17.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.button17.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.button17.Location = new System.Drawing.Point(12, 679);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(157, 30);
            this.button17.TabIndex = 20;
            this.button17.Text = "Office Help";
            this.button17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(9, 636);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 28);
            this.label5.TabIndex = 19;
            this.label5.Text = "HELP";
            // 
            // checkBox1
            // 
            this.checkBox1.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox1.BackColor = System.Drawing.Color.White;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox1.FlatAppearance.BorderSize = 0;
            this.checkBox1.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlLight;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.checkBox1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.checkBox1.Location = new System.Drawing.Point(12, 527);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(157, 30);
            this.checkBox1.TabIndex = 18;
            this.checkBox1.Text = "Word Wrap (enabled)";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.White;
            this.button16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button16.FlatAppearance.BorderSize = 0;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.button16.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.button16.Location = new System.Drawing.Point(12, 563);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(157, 30);
            this.button16.TabIndex = 17;
            this.button16.Text = "Change Font";
            this.button16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(9, 486);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 28);
            this.label4.TabIndex = 16;
            this.label4.Text = "FORMAT";
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.White;
            this.button15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button15.FlatAppearance.BorderSize = 0;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.button15.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.button15.Location = new System.Drawing.Point(12, 440);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(157, 30);
            this.button15.TabIndex = 15;
            this.button15.Text = "Select All";
            this.button15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.White;
            this.button14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button14.FlatAppearance.BorderSize = 0;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.button14.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.button14.Location = new System.Drawing.Point(12, 404);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(157, 30);
            this.button14.TabIndex = 13;
            this.button14.Text = "Find";
            this.button14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.White;
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.button8.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.button8.Location = new System.Drawing.Point(12, 368);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(157, 30);
            this.button8.TabIndex = 12;
            this.button8.Text = "Paste";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.White;
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.button9.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.button9.Location = new System.Drawing.Point(12, 338);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(157, 30);
            this.button9.TabIndex = 11;
            this.button9.Text = "Copy";
            this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.White;
            this.button10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.button10.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.button10.Location = new System.Drawing.Point(12, 308);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(157, 30);
            this.button10.TabIndex = 10;
            this.button10.Text = "Cut";
            this.button10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.White;
            this.button12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.button12.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.button12.Location = new System.Drawing.Point(12, 272);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(157, 30);
            this.button12.TabIndex = 8;
            this.button12.Text = "Undo";
            this.button12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(9, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "EDIT";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.button7.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.button7.Location = new System.Drawing.Point(12, 187);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(157, 30);
            this.button7.TabIndex = 6;
            this.button7.Text = "Print";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.button6.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.button6.Location = new System.Drawing.Point(12, 151);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(157, 30);
            this.button6.TabIndex = 5;
            this.button6.Text = "Save As";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.button5.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.button5.Location = new System.Drawing.Point(12, 121);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(157, 30);
            this.button5.TabIndex = 4;
            this.button5.Text = "Save";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.button4.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.button4.Location = new System.Drawing.Point(12, 91);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(157, 30);
            this.button4.TabIndex = 3;
            this.button4.Text = "Open";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.button3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.button3.Location = new System.Drawing.Point(12, 61);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(157, 30);
            this.button3.TabIndex = 2;
            this.button3.Text = "New";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "FILE";
            // 
            // menu_animation
            // 
            this.menu_animation.Enabled = true;
            this.menu_animation.Interval = 1;
            this.menu_animation.Tick += new System.EventHandler(this.menu_animation_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.label2.Location = new System.Drawing.Point(7, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Not Saved";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(924, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(26, 30);
            this.panel3.TabIndex = 1;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(15, 10);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(2, 10);
            this.panel5.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(7, 19);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 2);
            this.panel4.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 620);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(950, 30);
            this.panel2.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.lines_count);
            this.flowLayoutPanel1.Controls.Add(this.word_count);
            this.flowLayoutPanel1.Controls.Add(this.char_count);
            this.flowLayoutPanel1.Controls.Add(this.label7);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(459, 5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(463, 24);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // lines_count
            // 
            this.lines_count.AutoSize = true;
            this.lines_count.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.lines_count.Location = new System.Drawing.Point(412, 0);
            this.lines_count.Name = "lines_count";
            this.lines_count.Size = new System.Drawing.Size(48, 19);
            this.lines_count.TabIndex = 0;
            this.lines_count.Text = "0 Lines";
            // 
            // word_count
            // 
            this.word_count.AutoSize = true;
            this.word_count.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.word_count.Location = new System.Drawing.Point(348, 0);
            this.word_count.Name = "word_count";
            this.word_count.Size = new System.Drawing.Size(58, 19);
            this.word_count.TabIndex = 1;
            this.word_count.Text = "0 Words";
            // 
            // char_count
            // 
            this.char_count.AutoSize = true;
            this.char_count.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.char_count.Location = new System.Drawing.Point(260, 0);
            this.char_count.Name = "char_count";
            this.char_count.Size = new System.Drawing.Size(82, 19);
            this.char_count.TabIndex = 2;
            this.char_count.Text = "0 Characters";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label7.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.label7.Location = new System.Drawing.Point(128, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "    Spelling Check    ";
            this.label7.Click += new System.EventHandler(this.CheckSpellings);
            // 
            // new_animation
            // 
            this.new_animation.Interval = 1;
            this.new_animation.Tick += new System.EventHandler(this.new_animation_Tick);
            // 
            // autosave_timer
            // 
            this.autosave_timer.Enabled = true;
            this.autosave_timer.Interval = 60000;
            this.autosave_timer.Tick += new System.EventHandler(this.autosave_timer_Tick);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            this.fileSystemWatcher1.Deleted += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Deleted);
            // 
            // txtDocument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(950, 650);
            this.Controls.Add(this.menu_pane);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "txtDocument";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text Document Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.txtDocument_FormClosing);
            this.Load += new System.EventHandler(this.txtDocument_Load);
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.menu_pane.ResumeLayout(false);
            this.menu_pane.PerformLayout();
            this.new_pane.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button min_button;
        private System.Windows.Forms.Button maxbutton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer max_animation;
        private System.Windows.Forms.Timer min_animation;
        private System.Windows.Forms.Timer mize_animation;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel menu_pane;
        private System.Windows.Forms.Timer menu_animation;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lines_count;
        private System.Windows.Forms.Label word_count;
        private System.Windows.Forms.Label char_count;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button8;
        public System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Panel expansion_pane;
        private System.Windows.Forms.Panel new_pane;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Timer new_animation;
        public System.Windows.Forms.Timer autosave_timer;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        public System.Windows.Forms.Label title;
        public System.Windows.Forms.RichTextBox textBox1;
        private System.Windows.Forms.Label label7;
    }
}     