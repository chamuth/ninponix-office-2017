namespace Ninponix_Office.PresentationToolBox
{
    partial class choose_style
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(choose_style));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.height = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.width = new System.Windows.Forms.NumericUpDown();
            this.auto_size = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.y = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.x = new System.Windows.Forms.NumericUpDown();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.previewWindow = new System.Windows.Forms.Panel();
            this.lbl = new System.Windows.Forms.Label();
            this.styleBox = new System.Windows.Forms.ListBox();
            this.preview_text = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.start_animation = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.height)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x)).BeginInit();
            this.previewWindow.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose a style";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.height);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.width);
            this.panel1.Controls.Add(this.auto_size);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.y);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.x);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.previewWindow);
            this.panel1.Controls.Add(this.styleBox);
            this.panel1.Controls.Add(this.preview_text);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 404);
            this.panel1.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(402, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(258, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "NOTE: The size varies between slide / screen sizes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.ForeColor = System.Drawing.Color.LimeGreen;
            this.label4.Location = new System.Drawing.Point(584, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "H:";
            // 
            // height
            // 
            this.height.Enabled = false;
            this.height.Location = new System.Drawing.Point(610, 308);
            this.height.Maximum = new decimal(new int[] {
            44000,
            0,
            0,
            0});
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(55, 23);
            this.height.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label5.ForeColor = System.Drawing.Color.LimeGreen;
            this.label5.Location = new System.Drawing.Point(486, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "W:";
            // 
            // width
            // 
            this.width.Enabled = false;
            this.width.Location = new System.Drawing.Point(512, 308);
            this.width.Maximum = new decimal(new int[] {
            44000,
            0,
            0,
            0});
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(55, 23);
            this.width.TabIndex = 8;
            // 
            // auto_size
            // 
            this.auto_size.AutoSize = true;
            this.auto_size.Checked = true;
            this.auto_size.CheckState = System.Windows.Forms.CheckState.Checked;
            this.auto_size.ForeColor = System.Drawing.Color.LimeGreen;
            this.auto_size.Location = new System.Drawing.Point(593, 275);
            this.auto_size.Name = "auto_size";
            this.auto_size.Size = new System.Drawing.Size(72, 19);
            this.auto_size.TabIndex = 7;
            this.auto_size.Text = "AutoSize";
            this.auto_size.UseVisualStyleBackColor = true;
            this.auto_size.CheckedChanged += new System.EventHandler(this.auto_size_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.ForeColor = System.Drawing.Color.LimeGreen;
            this.label3.Location = new System.Drawing.Point(382, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Y:";
            // 
            // y
            // 
            this.y.Location = new System.Drawing.Point(408, 308);
            this.y.Maximum = new decimal(new int[] {
            44000,
            0,
            0,
            0});
            this.y.Name = "y";
            this.y.Size = new System.Drawing.Size(55, 23);
            this.y.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.ForeColor = System.Drawing.Color.LimeGreen;
            this.label2.Location = new System.Drawing.Point(284, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "X:";
            // 
            // x
            // 
            this.x.Location = new System.Drawing.Point(310, 308);
            this.x.Maximum = new decimal(new int[] {
            44000,
            0,
            0,
            0});
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(55, 23);
            this.x.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LimeGreen;
            this.button3.Enabled = false;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(475, 358);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 31);
            this.button3.TabIndex = 2;
            this.button3.Text = "Create";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.button2.ForeColor = System.Drawing.Color.LimeGreen;
            this.button2.Location = new System.Drawing.Point(573, 358);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 31);
            this.button2.TabIndex = 2;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // previewWindow
            // 
            this.previewWindow.AutoSize = true;
            this.previewWindow.Controls.Add(this.lbl);
            this.previewWindow.Location = new System.Drawing.Point(285, 49);
            this.previewWindow.Name = "previewWindow";
            this.previewWindow.Size = new System.Drawing.Size(380, 207);
            this.previewWindow.TabIndex = 1;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(8, 9);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(0, 15);
            this.lbl.TabIndex = 0;
            // 
            // styleBox
            // 
            this.styleBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.styleBox.FormattingEnabled = true;
            this.styleBox.IntegralHeight = false;
            this.styleBox.ItemHeight = 17;
            this.styleBox.Location = new System.Drawing.Point(16, 16);
            this.styleBox.Name = "styleBox";
            this.styleBox.Size = new System.Drawing.Size(250, 373);
            this.styleBox.TabIndex = 0;
            this.styleBox.SelectedIndexChanged += new System.EventHandler(this.styleBox_SelectedIndexChanged);
            // 
            // preview_text
            // 
            this.preview_text.AutoSize = true;
            this.preview_text.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.preview_text.ForeColor = System.Drawing.Color.LimeGreen;
            this.preview_text.Location = new System.Drawing.Point(281, 16);
            this.preview_text.Name = "preview_text";
            this.preview_text.Size = new System.Drawing.Size(63, 19);
            this.preview_text.TabIndex = 0;
            this.preview_text.Text = "Preview: ";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(644, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 30);
            this.button1.TabIndex = 4;
            this.button1.TabStop = false;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // start_animation
            // 
            this.start_animation.Enabled = true;
            this.start_animation.Interval = 1;
            this.start_animation.Tick += new System.EventHandler(this.start_animation_Tick);
            // 
            // choose_style
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(684, 448);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "choose_style";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Choose Style";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Choose_Style_FormClosing);
            this.Load += new System.EventHandler(this.choose_style_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.height)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.x)).EndInit();
            this.previewWindow.ResumeLayout(false);
            this.previewWindow.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel previewWindow;
        private System.Windows.Forms.ListBox styleBox;
        private System.Windows.Forms.Label preview_text;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer start_animation;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown height;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown width;
        private System.Windows.Forms.CheckBox auto_size;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown y;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown x;
        private System.Windows.Forms.Label label6;
    }
}