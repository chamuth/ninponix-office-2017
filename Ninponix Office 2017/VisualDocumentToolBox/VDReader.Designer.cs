namespace Ninponix_Office.VisualDocumentToolBox
{
    partial class VDReader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VDReader));
            this.sizing_timer = new System.Windows.Forms.Timer(this.components);
            this.Tools_Panel = new System.Windows.Forms.Panel();
            this.title_doc = new System.Windows.Forms.Label();
            this.edit_btn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.document_background = new System.Windows.Forms.Panel();
            this.doc_panel = new System.Windows.Forms.Panel();
            this.maximization = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.zoomout = new System.Windows.Forms.Button();
            this.zoomin = new System.Windows.Forms.Button();
            this.minimize = new System.Windows.Forms.Timer(this.components);
            this.Tools_Panel.SuspendLayout();
            this.document_background.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sizing_timer
            // 
            this.sizing_timer.Enabled = true;
            this.sizing_timer.Interval = 1;
            this.sizing_timer.Tick += new System.EventHandler(this.sizing_timer_Tick);
            // 
            // Tools_Panel
            // 
            this.Tools_Panel.BackColor = System.Drawing.Color.White;
            this.Tools_Panel.Controls.Add(this.title_doc);
            this.Tools_Panel.Controls.Add(this.edit_btn);
            this.Tools_Panel.Controls.Add(this.button2);
            this.Tools_Panel.Controls.Add(this.button1);
            this.Tools_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Tools_Panel.Location = new System.Drawing.Point(0, 0);
            this.Tools_Panel.Name = "Tools_Panel";
            this.Tools_Panel.Size = new System.Drawing.Size(931, 30);
            this.Tools_Panel.TabIndex = 0;
            // 
            // title_doc
            // 
            this.title_doc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.title_doc.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.title_doc.ForeColor = System.Drawing.Color.Orange;
            this.title_doc.Location = new System.Drawing.Point(7, 6);
            this.title_doc.Name = "title_doc";
            this.title_doc.Size = new System.Drawing.Size(790, 19);
            this.title_doc.TabIndex = 5;
            this.title_doc.Text = "Preview - Ninponix Office 2017 (NLPP)";
            // 
            // edit_btn
            // 
            this.edit_btn.AccessibleName = "Editor Launchment Button";
            this.edit_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.edit_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("edit_btn.BackgroundImage")));
            this.edit_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.edit_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.edit_btn.FlatAppearance.BorderSize = 0;
            this.edit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(174)))), ((int)(((byte)(0)))));
            this.edit_btn.Location = new System.Drawing.Point(810, 0);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(25, 30);
            this.edit_btn.TabIndex = 4;
            this.edit_btn.TabStop = false;
            this.edit_btn.UseVisualStyleBackColor = true;
            this.edit_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(174)))), ((int)(((byte)(0)))));
            this.button2.Location = new System.Drawing.Point(848, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 30);
            this.button2.TabIndex = 4;
            this.button2.TabStop = false;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(174)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(891, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 30);
            this.button1.TabIndex = 3;
            this.button1.TabStop = false;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // document_background
            // 
            this.document_background.AutoScroll = true;
            this.document_background.BackColor = System.Drawing.Color.Transparent;
            this.document_background.Controls.Add(this.doc_panel);
            this.document_background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.document_background.Location = new System.Drawing.Point(0, 30);
            this.document_background.Name = "document_background";
            this.document_background.Size = new System.Drawing.Size(931, 494);
            this.document_background.TabIndex = 1;
            this.document_background.Scroll += new System.Windows.Forms.ScrollEventHandler(this.document_background_Scroll);
            // 
            // doc_panel
            // 
            this.doc_panel.BackColor = System.Drawing.Color.White;
            this.doc_panel.Location = new System.Drawing.Point(0, 0);
            this.doc_panel.Name = "doc_panel";
            this.doc_panel.Size = new System.Drawing.Size(0, 0);
            this.doc_panel.TabIndex = 0;
            // 
            // maximization
            // 
            this.maximization.Enabled = true;
            this.maximization.Interval = 1;
            this.maximization.Tick += new System.EventHandler(this.maximization_Tick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.zoomout);
            this.panel1.Controls.Add(this.zoomin);
            this.panel1.Location = new System.Drawing.Point(803, 455);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(84, 44);
            this.panel1.TabIndex = 4;
            // 
            // zoomout
            // 
            this.zoomout.BackColor = System.Drawing.Color.Orange;
            this.zoomout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("zoomout.BackgroundImage")));
            this.zoomout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.zoomout.FlatAppearance.BorderSize = 0;
            this.zoomout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zoomout.ForeColor = System.Drawing.Color.White;
            this.zoomout.Location = new System.Drawing.Point(43, 3);
            this.zoomout.Name = "zoomout";
            this.zoomout.Size = new System.Drawing.Size(38, 38);
            this.zoomout.TabIndex = 1;
            this.zoomout.UseVisualStyleBackColor = false;
            this.zoomout.Click += new System.EventHandler(this.zoomout_Click);
            // 
            // zoomin
            // 
            this.zoomin.BackColor = System.Drawing.Color.Orange;
            this.zoomin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("zoomin.BackgroundImage")));
            this.zoomin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.zoomin.FlatAppearance.BorderSize = 0;
            this.zoomin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zoomin.ForeColor = System.Drawing.Color.White;
            this.zoomin.Location = new System.Drawing.Point(3, 3);
            this.zoomin.Name = "zoomin";
            this.zoomin.Size = new System.Drawing.Size(38, 38);
            this.zoomin.TabIndex = 0;
            this.zoomin.UseVisualStyleBackColor = false;
            this.zoomin.Click += new System.EventHandler(this.zoomin_Click);
            // 
            // minimize
            // 
            this.minimize.Interval = 1;
            this.minimize.Tick += new System.EventHandler(this.minimize_Tick);
            // 
            // VDReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(931, 524);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.document_background);
            this.Controls.Add(this.Tools_Panel);
            this.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "VDReader";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Preview - Ninponix Office 2017 (NLPP)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VDReader_FormClosing);
            this.Load += new System.EventHandler(this.VDReader_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.VDReader_KeyDown);
            this.Tools_Panel.ResumeLayout(false);
            this.document_background.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer sizing_timer;
        private System.Windows.Forms.Panel Tools_Panel;
        private System.Windows.Forms.Panel document_background;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel doc_panel;
        private System.Windows.Forms.Label title_doc;
        private System.Windows.Forms.Timer maximization;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button zoomin;
        private System.Windows.Forms.Button zoomout;
        private System.Windows.Forms.Timer minimize;
    }
}