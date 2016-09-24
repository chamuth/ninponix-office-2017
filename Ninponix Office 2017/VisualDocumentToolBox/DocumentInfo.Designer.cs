namespace Ninponix_Office.VisualDocumentToolBox
{
    partial class DocumentInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocumentInfo));
            this.doc_attr_tag = new System.Windows.Forms.Label();
            this.name_tag = new System.Windows.Forms.Label();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.width_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.height_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.doc_col = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // doc_attr_tag
            // 
            this.doc_attr_tag.AutoSize = true;
            this.doc_attr_tag.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.doc_attr_tag.ForeColor = System.Drawing.Color.Gray;
            this.doc_attr_tag.Location = new System.Drawing.Point(12, 93);
            this.doc_attr_tag.Name = "doc_attr_tag";
            this.doc_attr_tag.Size = new System.Drawing.Size(198, 15);
            this.doc_attr_tag.TabIndex = 0;
            this.doc_attr_tag.Text = "* Document Attributes Tag Not Found";
            // 
            // name_tag
            // 
            this.name_tag.AutoSize = true;
            this.name_tag.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.name_tag.ForeColor = System.Drawing.Color.Gray;
            this.name_tag.Location = new System.Drawing.Point(12, 10);
            this.name_tag.Name = "name_tag";
            this.name_tag.Size = new System.Drawing.Size(179, 15);
            this.name_tag.TabIndex = 0;
            this.name_tag.Text = "* Document Name Tag Not Found";
            // 
            // name_txt
            // 
            this.name_txt.BackColor = System.Drawing.Color.White;
            this.name_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name_txt.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.name_txt.Location = new System.Drawing.Point(23, 39);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(185, 23);
            this.name_txt.TabIndex = 0;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Orange;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Segoe UI Light", 8.75F);
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(216, 38);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(122, 24);
            this.button9.TabIndex = 1;
            this.button9.Text = "Change / Create";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.label3.ForeColor = System.Drawing.Color.Orange;
            this.label3.Location = new System.Drawing.Point(30, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Width:";
            // 
            // width_txt
            // 
            this.width_txt.BackColor = System.Drawing.Color.White;
            this.width_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.width_txt.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.width_txt.Location = new System.Drawing.Point(80, 126);
            this.width_txt.Name = "width_txt";
            this.width_txt.Size = new System.Drawing.Size(62, 23);
            this.width_txt.TabIndex = 2;
            this.width_txt.TextChanged += new System.EventHandler(this.width_txt_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.label4.ForeColor = System.Drawing.Color.Orange;
            this.label4.Location = new System.Drawing.Point(187, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Height:";
            // 
            // height_txt
            // 
            this.height_txt.BackColor = System.Drawing.Color.White;
            this.height_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.height_txt.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.height_txt.Location = new System.Drawing.Point(237, 126);
            this.height_txt.Name = "height_txt";
            this.height_txt.Size = new System.Drawing.Size(62, 23);
            this.height_txt.TabIndex = 3;
            this.height_txt.TextChanged += new System.EventHandler(this.height_txt_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(145, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "px";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(302, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "px";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(30, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Color:";
            // 
            // doc_col
            // 
            this.doc_col.BackColor = System.Drawing.Color.White;
            this.doc_col.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.doc_col.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.doc_col.Location = new System.Drawing.Point(80, 160);
            this.doc_col.Name = "doc_col";
            this.doc_col.Size = new System.Drawing.Size(241, 23);
            this.doc_col.TabIndex = 4;
            this.doc_col.TextChanged += new System.EventHandler(this.doc_col_TextChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Orange;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Light", 8.75F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(18, 209);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(315, 24);
            this.button2.TabIndex = 5;
            this.button2.Text = "Change / Create Document Attribute";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DocumentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(350, 252);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.height_txt);
            this.Controls.Add(this.doc_col);
            this.Controls.Add(this.width_txt);
            this.Controls.Add(this.name_txt);
            this.Controls.Add(this.name_tag);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.doc_attr_tag);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DocumentInfo";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Document Information";
            this.Load += new System.EventHandler(this.DocumentInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label doc_attr_tag;
        private System.Windows.Forms.Label name_tag;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox width_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox height_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox doc_col;
        private System.Windows.Forms.Button button2;
    }
}