namespace Ninponix_Office
{
    partial class VisualDocument
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisualDocument));
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.template4 = new System.Windows.Forms.Button();
            this.template3 = new System.Windows.Forms.Button();
            this.template2 = new System.Windows.Forms.Button();
            this.template1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.template_title = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.document_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.document_url = new System.Windows.Forms.ComboBox();
            this.create_panel = new System.Windows.Forms.Panel();
            this.create_button = new System.Windows.Forms.Button();
            this.title_doc = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.create_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(174)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(983, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 30);
            this.button1.TabIndex = 2;
            this.button1.TabStop = false;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 35F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 71);
            this.label1.TabIndex = 4;
            this.label1.Text = "Templates";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(174)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.template4);
            this.panel2.Controls.Add(this.template3);
            this.panel2.Controls.Add(this.template2);
            this.panel2.Controls.Add(this.template1);
            this.panel2.Location = new System.Drawing.Point(37, 159);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(666, 414);
            this.panel2.TabIndex = 5;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // template4
            // 
            this.template4.BackColor = System.Drawing.Color.Orange;
            this.template4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.template4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.template4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.template4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.template4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.template4.ForeColor = System.Drawing.Color.White;
            this.template4.Image = ((System.Drawing.Image)(resources.GetObject("template4.Image")));
            this.template4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.template4.Location = new System.Drawing.Point(478, 10);
            this.template4.Name = "template4";
            this.template4.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.template4.Size = new System.Drawing.Size(150, 205);
            this.template4.TabIndex = 3;
            this.template4.Text = "Resume";
            this.template4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.template4.UseVisualStyleBackColor = false;
            this.template4.Click += new System.EventHandler(this.template4_Click);
            // 
            // template3
            // 
            this.template3.BackColor = System.Drawing.Color.Orange;
            this.template3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.template3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.template3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.template3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.template3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.template3.ForeColor = System.Drawing.Color.White;
            this.template3.Image = ((System.Drawing.Image)(resources.GetObject("template3.Image")));
            this.template3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.template3.Location = new System.Drawing.Point(322, 10);
            this.template3.Name = "template3";
            this.template3.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.template3.Size = new System.Drawing.Size(150, 205);
            this.template3.TabIndex = 2;
            this.template3.Text = "Report";
            this.template3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.template3.UseVisualStyleBackColor = false;
            this.template3.Click += new System.EventHandler(this.template3_Click);
            // 
            // template2
            // 
            this.template2.BackColor = System.Drawing.Color.Orange;
            this.template2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.template2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.template2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.template2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.template2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.template2.ForeColor = System.Drawing.Color.White;
            this.template2.Image = ((System.Drawing.Image)(resources.GetObject("template2.Image")));
            this.template2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.template2.Location = new System.Drawing.Point(166, 10);
            this.template2.Name = "template2";
            this.template2.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.template2.Size = new System.Drawing.Size(150, 205);
            this.template2.TabIndex = 1;
            this.template2.Text = "Letter";
            this.template2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.template2.UseVisualStyleBackColor = false;
            this.template2.Click += new System.EventHandler(this.template2_Click);
            // 
            // template1
            // 
            this.template1.BackColor = System.Drawing.Color.Orange;
            this.template1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.template1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.template1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.template1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.template1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.template1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.template1.ForeColor = System.Drawing.Color.White;
            this.template1.Image = ((System.Drawing.Image)(resources.GetObject("template1.Image")));
            this.template1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.template1.Location = new System.Drawing.Point(10, 10);
            this.template1.Name = "template1";
            this.template1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.template1.Size = new System.Drawing.Size(150, 205);
            this.template1.TabIndex = 0;
            this.template1.Text = "Empty";
            this.template1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.template1.UseVisualStyleBackColor = false;
            this.template1.Click += new System.EventHandler(this.template1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(38, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "NEW DOCUMENT";
            this.label2.UseCompatibleTextRendering = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // template_title
            // 
            this.template_title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.template_title.AutoSize = true;
            this.template_title.Font = new System.Drawing.Font("Segoe UI Light", 25F);
            this.template_title.ForeColor = System.Drawing.Color.White;
            this.template_title.Location = new System.Drawing.Point(18, 28);
            this.template_title.Name = "template_title";
            this.template_title.Size = new System.Drawing.Size(236, 52);
            this.template_title.TabIndex = 4;
            this.template_title.Text = "New Document";
            this.template_title.UseCompatibleTextRendering = true;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(24, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 27);
            this.label4.TabIndex = 4;
            this.label4.Text = "Document Name:";
            this.label4.UseCompatibleTextRendering = true;
            // 
            // document_name
            // 
            this.document_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.document_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(174)))), ((int)(((byte)(0)))));
            this.document_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.document_name.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.document_name.ForeColor = System.Drawing.Color.White;
            this.document_name.Location = new System.Drawing.Point(26, 132);
            this.document_name.Name = "document_name";
            this.document_name.Size = new System.Drawing.Size(230, 25);
            this.document_name.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(24, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 27);
            this.label5.TabIndex = 4;
            this.label5.Text = "Document Location:";
            this.label5.UseCompatibleTextRendering = true;
            // 
            // document_url
            // 
            this.document_url.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.document_url.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(174)))), ((int)(((byte)(0)))));
            this.document_url.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.document_url.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.document_url.ForeColor = System.Drawing.Color.White;
            this.document_url.FormattingEnabled = true;
            this.document_url.Location = new System.Drawing.Point(26, 201);
            this.document_url.Name = "document_url";
            this.document_url.Size = new System.Drawing.Size(230, 25);
            this.document_url.TabIndex = 5;
            this.document_url.SelectedIndexChanged += new System.EventHandler(this.document_url_SelectedIndexChanged);
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
            this.create_panel.TabIndex = 6;
            // 
            // create_button
            // 
            this.create_button.BackColor = System.Drawing.Color.White;
            this.create_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.create_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.create_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.create_button.ForeColor = System.Drawing.Color.Orange;
            this.create_button.Location = new System.Drawing.Point(137, 267);
            this.create_button.Name = "create_button";
            this.create_button.Size = new System.Drawing.Size(119, 32);
            this.create_button.TabIndex = 6;
            this.create_button.Text = "Create";
            this.create_button.UseVisualStyleBackColor = false;
            this.create_button.Click += new System.EventHandler(this.create_button_Click);
            // 
            // title_doc
            // 
            this.title_doc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.title_doc.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.title_doc.ForeColor = System.Drawing.Color.Orange;
            this.title_doc.Location = new System.Drawing.Point(7, 6);
            this.title_doc.Name = "title_doc";
            this.title_doc.Size = new System.Drawing.Size(230, 19);
            this.title_doc.TabIndex = 4;
            this.title_doc.Text = "Ninponix Visual Document";
            // 
            // VisualDocument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(1023, 644);
            this.Controls.Add(this.create_panel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "VisualDocument";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VisualDocument";
            this.Load += new System.EventHandler(this.VD_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.create_panel.ResumeLayout(false);
            this.create_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button template1;
        private System.Windows.Forms.Button template2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button template4;
        private System.Windows.Forms.Button template3;
        private System.Windows.Forms.Label template_title;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox document_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox document_url;
        private System.Windows.Forms.Panel create_panel;
        private System.Windows.Forms.Button create_button;
        private System.Windows.Forms.Label title_doc;
    }
}