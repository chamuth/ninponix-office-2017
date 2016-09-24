namespace Ninponix_Office.PresentationToolBox
{
    partial class AddStyle_NAME
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStyle_NAME));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.style_name = new System.Windows.Forms.TextBox();
            this.font_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.font_size = new System.Windows.Forms.NumericUpDown();
            this.font_browsing_Button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.text_style = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.fore_Color = new System.Windows.Forms.Panel();
            this.back_Color = new System.Windows.Forms.Panel();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.add_Style = new System.Windows.Forms.Button();
            this.start_animation = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.font_size)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.label1.Location = new System.Drawing.Point(19, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Style";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.Location = new System.Drawing.Point(20, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Style Name:";
            // 
            // style_name
            // 
            this.style_name.Location = new System.Drawing.Point(23, 95);
            this.style_name.Name = "style_name";
            this.style_name.Size = new System.Drawing.Size(343, 25);
            this.style_name.TabIndex = 1;
            // 
            // font_name
            // 
            this.font_name.Location = new System.Drawing.Point(23, 160);
            this.font_name.Name = "font_name";
            this.font_name.Size = new System.Drawing.Size(225, 25);
            this.font_name.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.Location = new System.Drawing.Point(20, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Font:";
            // 
            // font_size
            // 
            this.font_size.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.font_size.Location = new System.Drawing.Point(254, 160);
            this.font_size.Maximum = new decimal(new int[] {
            80000,
            0,
            0,
            0});
            this.font_size.Name = "font_size";
            this.font_size.Size = new System.Drawing.Size(45, 25);
            this.font_size.TabIndex = 4;
            // 
            // font_browsing_Button
            // 
            this.font_browsing_Button.BackColor = System.Drawing.Color.White;
            this.font_browsing_Button.FlatAppearance.BorderSize = 0;
            this.font_browsing_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.font_browsing_Button.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.font_browsing_Button.ForeColor = System.Drawing.Color.LimeGreen;
            this.font_browsing_Button.Location = new System.Drawing.Point(305, 158);
            this.font_browsing_Button.Name = "font_browsing_Button";
            this.font_browsing_Button.Size = new System.Drawing.Size(61, 27);
            this.font_browsing_Button.TabIndex = 5;
            this.font_browsing_Button.Text = "...";
            this.font_browsing_Button.UseVisualStyleBackColor = false;
            this.font_browsing_Button.Click += new System.EventHandler(this.font_browsing_Button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.Location = new System.Drawing.Point(20, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Style:";
            // 
            // text_style
            // 
            this.text_style.AutoCompleteCustomSource.AddRange(new string[] {
            "REGULAR",
            "BOLD",
            "ITALIC",
            "UNDERLINE",
            "STRIKEOUT",
            "BOLDITALIC",
            "BOLDUNDERLINE",
            "BOLDSTRIKEOUT",
            "ITALICUNDERLINE",
            "ITALICSTRIKEOUT",
            "BOLDITALICUNDERLINE",
            "BOLDITALICUNDERLINESTRIKEOUT"});
            this.text_style.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.text_style.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.text_style.Location = new System.Drawing.Point(74, 207);
            this.text_style.Name = "text_style";
            this.text_style.Size = new System.Drawing.Size(292, 25);
            this.text_style.TabIndex = 7;
            this.text_style.Text = "REGULAR";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label5.Location = new System.Drawing.Point(53, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Forecolor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label6.Location = new System.Drawing.Point(211, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "Backcolor:";
            // 
            // fore_Color
            // 
            this.fore_Color.BackColor = System.Drawing.Color.Black;
            this.fore_Color.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fore_Color.Location = new System.Drawing.Point(134, 275);
            this.fore_Color.Name = "fore_Color";
            this.fore_Color.Size = new System.Drawing.Size(30, 30);
            this.fore_Color.TabIndex = 9;
            this.fore_Color.MouseDown += new System.Windows.Forms.MouseEventHandler(this.fore_Color_MouseDown);
            // 
            // back_Color
            // 
            this.back_Color.BackColor = System.Drawing.Color.White;
            this.back_Color.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.back_Color.Location = new System.Drawing.Point(293, 276);
            this.back_Color.Name = "back_Color";
            this.back_Color.Size = new System.Drawing.Size(30, 30);
            this.back_Color.TabIndex = 10;
            this.back_Color.MouseDown += new System.Windows.Forms.MouseEventHandler(this.back_Color_MouseDown);
            // 
            // Cancel_button
            // 
            this.Cancel_button.BackColor = System.Drawing.Color.White;
            this.Cancel_button.FlatAppearance.BorderSize = 0;
            this.Cancel_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel_button.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel_button.ForeColor = System.Drawing.Color.LimeGreen;
            this.Cancel_button.Location = new System.Drawing.Point(274, 360);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(92, 37);
            this.Cancel_button.TabIndex = 5;
            this.Cancel_button.Text = "Cancel";
            this.Cancel_button.UseVisualStyleBackColor = false;
            this.Cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
            // 
            // add_Style
            // 
            this.add_Style.BackColor = System.Drawing.Color.White;
            this.add_Style.FlatAppearance.BorderSize = 0;
            this.add_Style.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_Style.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_Style.ForeColor = System.Drawing.Color.LimeGreen;
            this.add_Style.Location = new System.Drawing.Point(176, 360);
            this.add_Style.Name = "add_Style";
            this.add_Style.Size = new System.Drawing.Size(92, 37);
            this.add_Style.TabIndex = 5;
            this.add_Style.Text = "Add Style";
            this.add_Style.UseVisualStyleBackColor = false;
            this.add_Style.Click += new System.EventHandler(this.button2_Click);
            // 
            // start_animation
            // 
            this.start_animation.Enabled = true;
            this.start_animation.Interval = 1;
            this.start_animation.Tick += new System.EventHandler(this.start_animation_Tick);
            // 
            // AddStyle_NAME
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(389, 418);
            this.Controls.Add(this.back_Color);
            this.Controls.Add(this.fore_Color);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.text_style);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.add_Style);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.font_browsing_Button);
            this.Controls.Add(this.font_size);
            this.Controls.Add(this.font_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.style_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddStyle_NAME";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Style";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddImage_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.font_size)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox style_name;
        private System.Windows.Forms.TextBox font_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown font_size;
        private System.Windows.Forms.Button font_browsing_Button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox text_style;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel fore_Color;
        private System.Windows.Forms.Panel back_Color;
        private System.Windows.Forms.Button Cancel_button;
        private System.Windows.Forms.Button add_Style;
        private System.Windows.Forms.Timer start_animation;
    }
}