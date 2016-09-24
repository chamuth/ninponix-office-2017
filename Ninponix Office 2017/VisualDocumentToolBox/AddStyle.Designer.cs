namespace Ninponix_Office.VisualDocumentToolBox
{
    partial class AddStyle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStyle));
            this.label1 = new System.Windows.Forms.Label();
            this.style_name = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fontfamily = new System.Windows.Forms.TextBox();
            this.fontsize = new System.Windows.Forms.TextBox();
            this.browse_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.font_color_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.background_color_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.style_container = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.preview_panel = new System.Windows.Forms.Panel();
            this.preview_label = new System.Windows.Forms.Label();
            this.image_preview = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.preview_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image_preview)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(18, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            // 
            // style_name
            // 
            this.style_name.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.style_name.Location = new System.Drawing.Point(66, 92);
            this.style_name.Name = "style_name";
            this.style_name.Size = new System.Drawing.Size(321, 23);
            this.style_name.TabIndex = 0;
            this.style_name.Text = "Style1";
            this.style_name.TextChanged += new System.EventHandler(this.style_name_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Light", 29F);
            this.label9.ForeColor = System.Drawing.Color.Orange;
            this.label9.Location = new System.Drawing.Point(8, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(180, 52);
            this.label9.TabIndex = 4;
            this.label9.Text = "Add Style";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(18, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Font:";
            // 
            // fontfamily
            // 
            this.fontfamily.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.fontfamily.Location = new System.Drawing.Point(66, 126);
            this.fontfamily.Name = "fontfamily";
            this.fontfamily.Size = new System.Drawing.Size(199, 23);
            this.fontfamily.TabIndex = 1;
            this.fontfamily.Text = "Arial";
            this.fontfamily.TextChanged += new System.EventHandler(this.fontfamily_TextChanged);
            // 
            // fontsize
            // 
            this.fontsize.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.fontsize.Location = new System.Drawing.Point(271, 126);
            this.fontsize.Name = "fontsize";
            this.fontsize.Size = new System.Drawing.Size(55, 23);
            this.fontsize.TabIndex = 2;
            this.fontsize.Text = "12";
            this.fontsize.TextChanged += new System.EventHandler(this.fontsize_TextChanged);
            // 
            // browse_btn
            // 
            this.browse_btn.BackColor = System.Drawing.Color.Orange;
            this.browse_btn.FlatAppearance.BorderSize = 0;
            this.browse_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browse_btn.Font = new System.Drawing.Font("Segoe UI Light", 8.75F);
            this.browse_btn.ForeColor = System.Drawing.Color.White;
            this.browse_btn.Location = new System.Drawing.Point(334, 125);
            this.browse_btn.Name = "browse_btn";
            this.browse_btn.Size = new System.Drawing.Size(53, 24);
            this.browse_btn.TabIndex = 3;
            this.browse_btn.Text = "...";
            this.browse_btn.UseVisualStyleBackColor = false;
            this.browse_btn.Click += new System.EventHandler(this.button9_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(18, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Color:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // font_color_txt
            // 
            this.font_color_txt.BackColor = System.Drawing.Color.Black;
            this.font_color_txt.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.font_color_txt.ForeColor = System.Drawing.Color.White;
            this.font_color_txt.Location = new System.Drawing.Point(101, 170);
            this.font_color_txt.Name = "font_color_txt";
            this.font_color_txt.Size = new System.Drawing.Size(100, 23);
            this.font_color_txt.TabIndex = 4;
            this.font_color_txt.Text = "0,0,0";
            this.font_color_txt.TextChanged += new System.EventHandler(this.font_color_txt_TextChanged);
            this.font_color_txt.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseDoubleClick);
            this.font_color_txt.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseDoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(62, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Font:";
            this.label4.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(209, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Background:";
            this.label5.Click += new System.EventHandler(this.label3_Click);
            // 
            // background_color_txt
            // 
            this.background_color_txt.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.background_color_txt.Location = new System.Drawing.Point(287, 170);
            this.background_color_txt.Name = "background_color_txt";
            this.background_color_txt.Size = new System.Drawing.Size(100, 23);
            this.background_color_txt.TabIndex = 5;
            this.background_color_txt.Text = "255,255,255";
            this.background_color_txt.TextChanged += new System.EventHandler(this.background_color_txt_TextChanged);
            this.background_color_txt.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.background_color_txt_MouseDoubleClick);
            this.background_color_txt.MouseDown += new System.Windows.Forms.MouseEventHandler(this.background_color_txt_MouseDoubleClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(18, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Style:";
            this.label6.Click += new System.EventHandler(this.label3_Click);
            // 
            // style_container
            // 
            this.style_container.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.style_container.FormattingEnabled = true;
            this.style_container.Location = new System.Drawing.Point(66, 215);
            this.style_container.Name = "style_container";
            this.style_container.Size = new System.Drawing.Size(321, 23);
            this.style_container.TabIndex = 6;
            this.style_container.SelectedIndexChanged += new System.EventHandler(this.style_container_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Light", 9.75F);
            this.button2.ForeColor = System.Drawing.Color.Orange;
            this.button2.Location = new System.Drawing.Point(299, 446);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 33);
            this.button2.TabIndex = 8;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Orange;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Light", 9.75F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(168, 446);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 33);
            this.button1.TabIndex = 7;
            this.button1.Text = "Create Style";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // preview_panel
            // 
            this.preview_panel.AutoScroll = true;
            this.preview_panel.AutoSize = true;
            this.preview_panel.BackColor = System.Drawing.SystemColors.Control;
            this.preview_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.preview_panel.Controls.Add(this.preview_label);
            this.preview_panel.Controls.Add(this.image_preview);
            this.preview_panel.Location = new System.Drawing.Point(21, 288);
            this.preview_panel.Name = "preview_panel";
            this.preview_panel.Size = new System.Drawing.Size(366, 130);
            this.preview_panel.TabIndex = 24;
            // 
            // preview_label
            // 
            this.preview_label.AutoSize = true;
            this.preview_label.Location = new System.Drawing.Point(4, 4);
            this.preview_label.Name = "preview_label";
            this.preview_label.Size = new System.Drawing.Size(0, 13);
            this.preview_label.TabIndex = 1;
            // 
            // image_preview
            // 
            this.image_preview.Location = new System.Drawing.Point(0, 0);
            this.image_preview.Name = "image_preview";
            this.image_preview.Size = new System.Drawing.Size(0, 0);
            this.image_preview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.image_preview.TabIndex = 0;
            this.image_preview.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(18, 266);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 15);
            this.label11.TabIndex = 23;
            this.label11.Text = "Preview:";
            // 
            // AddStyle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(411, 500);
            this.Controls.Add(this.preview_panel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.style_container);
            this.Controls.Add(this.browse_btn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.fontsize);
            this.Controls.Add(this.background_color_txt);
            this.Controls.Add(this.font_color_txt);
            this.Controls.Add(this.fontfamily);
            this.Controls.Add(this.style_name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddStyle";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Style";
            this.Load += new System.EventHandler(this.AddStyle_Load);
            this.preview_panel.ResumeLayout(false);
            this.preview_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image_preview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox style_name;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fontfamily;
        private System.Windows.Forms.TextBox fontsize;
        private System.Windows.Forms.Button browse_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox font_color_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox background_color_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox style_container;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel preview_panel;
        private System.Windows.Forms.PictureBox image_preview;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label preview_label;
    }
}