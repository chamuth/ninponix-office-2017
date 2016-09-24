namespace Ninponix_Office.VisualDocumentToolBox
{
    partial class AddText
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddText));
            this.name_tag = new System.Windows.Forms.Label();
            this.style_list = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.location_x = new System.Windows.Forms.TextBox();
            this.size_width = new System.Windows.Forms.TextBox();
            this.location_y = new System.Windows.Forms.TextBox();
            this.size_height = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.preview_panel = new System.Windows.Forms.Panel();
            this.preview_txt = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.preview_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // name_tag
            // 
            this.name_tag.AutoSize = true;
            this.name_tag.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.name_tag.ForeColor = System.Drawing.Color.Black;
            this.name_tag.Location = new System.Drawing.Point(14, 93);
            this.name_tag.Name = "name_tag";
            this.name_tag.Size = new System.Drawing.Size(55, 15);
            this.name_tag.TabIndex = 1;
            this.name_tag.Text = "Text Style:";
            // 
            // style_list
            // 
            this.style_list.BackColor = System.Drawing.Color.White;
            this.style_list.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.style_list.ForeColor = System.Drawing.Color.Black;
            this.style_list.FormattingEnabled = true;
            this.style_list.Location = new System.Drawing.Point(17, 119);
            this.style_list.Name = "style_list";
            this.style_list.Size = new System.Drawing.Size(354, 23);
            this.style_list.TabIndex = 0;
            this.style_list.SelectedIndexChanged += new System.EventHandler(this.style_list_SelectedIndexChanged);
            this.style_list.SelectedValueChanged += new System.EventHandler(this.style_list_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(14, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Text Content:";
            // 
            // name_txt
            // 
            this.name_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name_txt.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.name_txt.ForeColor = System.Drawing.Color.Gray;
            this.name_txt.Location = new System.Drawing.Point(17, 182);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(355, 23);
            this.name_txt.TabIndex = 3;
            this.name_txt.Text = "Sample Text";
            this.name_txt.TextChanged += new System.EventHandler(this.name_txt_TextChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI Light", 8F);
            this.checkBox1.Location = new System.Drawing.Point(93, 155);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(69, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Text Area";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(14, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Location:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(14, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Size:";
            // 
            // location_x
            // 
            this.location_x.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.location_x.Font = new System.Drawing.Font("Segoe UI Light", 8F);
            this.location_x.ForeColor = System.Drawing.Color.Gray;
            this.location_x.Location = new System.Drawing.Point(85, 225);
            this.location_x.Name = "location_x";
            this.location_x.Size = new System.Drawing.Size(83, 22);
            this.location_x.TabIndex = 4;
            this.location_x.Text = "0";
            this.location_x.TextChanged += new System.EventHandler(this.location_x_TextChanged);
            // 
            // size_width
            // 
            this.size_width.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.size_width.Font = new System.Drawing.Font("Segoe UI Light", 8F);
            this.size_width.ForeColor = System.Drawing.Color.Gray;
            this.size_width.Location = new System.Drawing.Point(85, 256);
            this.size_width.Name = "size_width";
            this.size_width.Size = new System.Drawing.Size(83, 22);
            this.size_width.TabIndex = 6;
            this.size_width.Text = "0";
            this.size_width.TextChanged += new System.EventHandler(this.size_width_TextChanged);
            // 
            // location_y
            // 
            this.location_y.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.location_y.Font = new System.Drawing.Font("Segoe UI Light", 8F);
            this.location_y.ForeColor = System.Drawing.Color.Gray;
            this.location_y.Location = new System.Drawing.Point(217, 225);
            this.location_y.Name = "location_y";
            this.location_y.Size = new System.Drawing.Size(83, 22);
            this.location_y.TabIndex = 5;
            this.location_y.Text = "0";
            this.location_y.TextChanged += new System.EventHandler(this.location_y_TextChanged);
            // 
            // size_height
            // 
            this.size_height.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.size_height.Font = new System.Drawing.Font("Segoe UI Light", 8F);
            this.size_height.ForeColor = System.Drawing.Color.Gray;
            this.size_height.Location = new System.Drawing.Point(217, 256);
            this.size_height.Name = "size_height";
            this.size_height.Size = new System.Drawing.Size(83, 22);
            this.size_height.TabIndex = 7;
            this.size_height.Text = "0";
            this.size_height.TextChanged += new System.EventHandler(this.size_height_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 8F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(174, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "X";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 8F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(306, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Y";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 8F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(174, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Width";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Light", 8F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(306, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Height";
            // 
            // preview_panel
            // 
            this.preview_panel.AutoScroll = true;
            this.preview_panel.AutoSize = true;
            this.preview_panel.BackColor = System.Drawing.SystemColors.Control;
            this.preview_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.preview_panel.Controls.Add(this.preview_txt);
            this.preview_panel.Location = new System.Drawing.Point(17, 343);
            this.preview_panel.Name = "preview_panel";
            this.preview_panel.Size = new System.Drawing.Size(355, 123);
            this.preview_panel.TabIndex = 7;
            // 
            // preview_txt
            // 
            this.preview_txt.AutoSize = true;
            this.preview_txt.Location = new System.Drawing.Point(5, 5);
            this.preview_txt.Name = "preview_txt";
            this.preview_txt.Size = new System.Drawing.Size(66, 13);
            this.preview_txt.TabIndex = 0;
            this.preview_txt.Text = "Sample Text";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(14, 321);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "Preview:";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Orange;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Light", 9.75F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(115, 492);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 33);
            this.button1.TabIndex = 8;
            this.button1.Text = "Create Text / TextArea";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Light", 9.75F);
            this.button2.ForeColor = System.Drawing.Color.Orange;
            this.button2.Location = new System.Drawing.Point(283, 492);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 33);
            this.button2.TabIndex = 9;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Light", 29F);
            this.label9.ForeColor = System.Drawing.Color.Orange;
            this.label9.Location = new System.Drawing.Point(8, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(165, 52);
            this.label9.TabIndex = 1;
            this.label9.Text = "Add Text";
            // 
            // AddText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(387, 541);
            this.Controls.Add(this.preview_panel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.size_height);
            this.Controls.Add(this.size_width);
            this.Controls.Add(this.location_y);
            this.Controls.Add(this.location_x);
            this.Controls.Add(this.name_txt);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.style_list);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.name_tag);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddText";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Text";
            this.Load += new System.EventHandler(this.AddText_Load);
            this.preview_panel.ResumeLayout(false);
            this.preview_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name_tag;
        private System.Windows.Forms.ComboBox style_list;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox location_x;
        private System.Windows.Forms.TextBox size_width;
        private System.Windows.Forms.TextBox location_y;
        private System.Windows.Forms.TextBox size_height;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel preview_panel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label preview_txt;
        private System.Windows.Forms.Label label9;
    }
}