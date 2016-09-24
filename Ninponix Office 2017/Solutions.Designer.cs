namespace Ninponix_Office
{
    partial class Solutions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Solutions));
            this.label1 = new System.Windows.Forms.Label();
            this.error_name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.code_txt = new System.Windows.Forms.Label();
            this.description_txt = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.fix_txt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Solution for,";
            // 
            // error_name
            // 
            this.error_name.ForeColor = System.Drawing.Color.Gray;
            this.error_name.Location = new System.Drawing.Point(13, 39);
            this.error_name.Name = "error_name";
            this.error_name.Size = new System.Drawing.Size(355, 26);
            this.error_name.TabIndex = 1;
            this.error_name.Text = "<ERROR_NAME>";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.label2.Location = new System.Drawing.Point(17, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Error Code:";
            // 
            // code_txt
            // 
            this.code_txt.AutoSize = true;
            this.code_txt.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.code_txt.ForeColor = System.Drawing.Color.Gray;
            this.code_txt.Location = new System.Drawing.Point(113, 94);
            this.code_txt.Name = "code_txt";
            this.code_txt.Size = new System.Drawing.Size(67, 20);
            this.code_txt.TabIndex = 2;
            this.code_txt.Text = "<CODE>";
            // 
            // description_txt
            // 
            this.description_txt.BackColor = System.Drawing.SystemColors.Control;
            this.description_txt.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.description_txt.ForeColor = System.Drawing.Color.Black;
            this.description_txt.Location = new System.Drawing.Point(17, 155);
            this.description_txt.Name = "description_txt";
            this.description_txt.Size = new System.Drawing.Size(283, 82);
            this.description_txt.TabIndex = 3;
            this.description_txt.Text = "<description>";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.label4.Location = new System.Drawing.Point(17, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Description:";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.button1.Location = new System.Drawing.Point(225, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 24);
            this.button1.TabIndex = 5;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(144, 399);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 24);
            this.button2.TabIndex = 5;
            this.button2.Text = "Fix it";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.label5.Location = new System.Drawing.Point(17, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fix:";
            // 
            // fix_txt
            // 
            this.fix_txt.BackColor = System.Drawing.SystemColors.Control;
            this.fix_txt.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.fix_txt.ForeColor = System.Drawing.Color.Black;
            this.fix_txt.Location = new System.Drawing.Point(17, 285);
            this.fix_txt.Name = "fix_txt";
            this.fix_txt.Size = new System.Drawing.Size(283, 82);
            this.fix_txt.TabIndex = 3;
            this.fix_txt.Text = "<FIX>";
            // 
            // Solutions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(316, 437);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fix_txt);
            this.Controls.Add(this.description_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.code_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.error_name);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Solutions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Solutions";
            this.Load += new System.EventHandler(this.Solutions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label error_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label code_txt;
        private System.Windows.Forms.Label description_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label fix_txt;
    }
}