namespace Ninponix_Office.VisualDocumentToolBox
{
    partial class AddImage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddImage));
            this.copy_check = new System.Windows.Forms.CheckBox();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.height_txt = new System.Windows.Forms.TextBox();
            this.width_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.y_txt = new System.Windows.Forms.TextBox();
            this.x_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.preview_panel = new System.Windows.Forms.Panel();
            this.image_preview = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.preview_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image_preview)).BeginInit();
            this.SuspendLayout();
            // 
            // copy_check
            // 
            this.copy_check.AutoSize = true;
            this.copy_check.Checked = true;
            this.copy_check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.copy_check.Font = new System.Drawing.Font("Segoe UI Light", 8F);
            this.copy_check.Location = new System.Drawing.Point(17, 157);
            this.copy_check.Name = "copy_check";
            this.copy_check.Size = new System.Drawing.Size(176, 17);
            this.copy_check.TabIndex = 2;
            this.copy_check.Text = "Copy image to the project folder";
            this.copy_check.UseVisualStyleBackColor = true;
            // 
            // name_txt
            // 
            this.name_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name_txt.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.name_txt.ForeColor = System.Drawing.Color.Gray;
            this.name_txt.Location = new System.Drawing.Point(17, 119);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(256, 23);
            this.name_txt.TabIndex = 0;
            this.name_txt.TextChanged += new System.EventHandler(this.name_txt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(14, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Image Path:";
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Orange;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Segoe UI Light", 8.75F);
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(279, 119);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(79, 24);
            this.button9.TabIndex = 1;
            this.button9.Text = "Browse";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Light", 29F);
            this.label9.ForeColor = System.Drawing.Color.Orange;
            this.label9.Location = new System.Drawing.Point(8, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(205, 52);
            this.label9.TabIndex = 8;
            this.label9.Text = "Add Image";
            // 
            // height_txt
            // 
            this.height_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.height_txt.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.height_txt.ForeColor = System.Drawing.Color.Black;
            this.height_txt.Location = new System.Drawing.Point(66, 231);
            this.height_txt.Name = "height_txt";
            this.height_txt.Size = new System.Drawing.Size(88, 23);
            this.height_txt.TabIndex = 4;
            this.height_txt.Text = "0";
            this.height_txt.TextChanged += new System.EventHandler(this.height_txt_TextChanged);
            // 
            // width_txt
            // 
            this.width_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.width_txt.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.width_txt.ForeColor = System.Drawing.Color.Black;
            this.width_txt.Location = new System.Drawing.Point(66, 202);
            this.width_txt.Name = "width_txt";
            this.width_txt.Size = new System.Drawing.Size(88, 23);
            this.width_txt.TabIndex = 3;
            this.width_txt.Text = "0";
            this.width_txt.TextChanged += new System.EventHandler(this.width_txt_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(162, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "px";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(162, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "px";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(16, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Height:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(16, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Width:";
            // 
            // y_txt
            // 
            this.y_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.y_txt.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.y_txt.ForeColor = System.Drawing.Color.Black;
            this.y_txt.Location = new System.Drawing.Point(243, 231);
            this.y_txt.Name = "y_txt";
            this.y_txt.Size = new System.Drawing.Size(88, 23);
            this.y_txt.TabIndex = 6;
            this.y_txt.Text = "0";
            this.y_txt.TextChanged += new System.EventHandler(this.y_txt_TextChanged);
            // 
            // x_txt
            // 
            this.x_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.x_txt.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.x_txt.ForeColor = System.Drawing.Color.Black;
            this.x_txt.Location = new System.Drawing.Point(243, 202);
            this.x_txt.Name = "x_txt";
            this.x_txt.Size = new System.Drawing.Size(88, 23);
            this.x_txt.TabIndex = 5;
            this.x_txt.Text = "0";
            this.x_txt.TextChanged += new System.EventHandler(this.x_txt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(339, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "px";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(339, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "px";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(212, 233);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 15);
            this.label8.TabIndex = 17;
            this.label8.Text = "Y: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(212, 204);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 15);
            this.label10.TabIndex = 18;
            this.label10.Text = "X: ";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Light", 9.75F);
            this.button2.ForeColor = System.Drawing.Color.Orange;
            this.button2.Location = new System.Drawing.Point(271, 493);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 33);
            this.button2.TabIndex = 20;
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
            this.button1.Location = new System.Drawing.Point(140, 493);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 33);
            this.button1.TabIndex = 19;
            this.button1.Text = "Add Image";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // preview_panel
            // 
            this.preview_panel.AutoScroll = true;
            this.preview_panel.BackColor = System.Drawing.SystemColors.Control;
            this.preview_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.preview_panel.Controls.Add(this.image_preview);
            this.preview_panel.Location = new System.Drawing.Point(17, 323);
            this.preview_panel.Name = "preview_panel";
            this.preview_panel.Size = new System.Drawing.Size(341, 123);
            this.preview_panel.TabIndex = 22;
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
            this.label11.Location = new System.Drawing.Point(14, 301);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 15);
            this.label11.TabIndex = 21;
            this.label11.Text = "Preview:";
            // 
            // AddImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(373, 542);
            this.Controls.Add(this.preview_panel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.y_txt);
            this.Controls.Add(this.x_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.height_txt);
            this.Controls.Add(this.width_txt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.copy_check);
            this.Controls.Add(this.name_txt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddImage";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Image";
            this.Load += new System.EventHandler(this.AddImage_Load);
            this.preview_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.image_preview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox copy_check;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox height_txt;
        private System.Windows.Forms.TextBox width_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox y_txt;
        private System.Windows.Forms.TextBox x_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel preview_panel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox image_preview;
    }
}