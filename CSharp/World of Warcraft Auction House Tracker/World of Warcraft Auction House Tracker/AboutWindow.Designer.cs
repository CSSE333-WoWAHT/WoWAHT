namespace World_of_Warcraft_Auction_House_Tracker
{
    partial class AboutWindow
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
            this.playerTableAdapter1 = new World_of_Warcraft_Auction_House_Tracker.wowahtDataSetTableAdapters.playerTableAdapter();
            this.CreatedByLabel = new System.Windows.Forms.Label();
            this.CJLabel = new System.Windows.Forms.Label();
            this.JasonLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LoganLabel = new System.Windows.Forms.Label();
            this.SourceLink = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // playerTableAdapter1
            // 
            this.playerTableAdapter1.ClearBeforeFill = true;
            // 
            // CreatedByLabel
            // 
            this.CreatedByLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CreatedByLabel.AutoSize = true;
            this.CreatedByLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CreatedByLabel.Location = new System.Drawing.Point(187, 42);
            this.CreatedByLabel.Name = "CreatedByLabel";
            this.CreatedByLabel.Size = new System.Drawing.Size(82, 17);
            this.CreatedByLabel.TabIndex = 0;
            this.CreatedByLabel.Text = "Created By:";
            this.CreatedByLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CreatedByLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // CJLabel
            // 
            this.CJLabel.AutoSize = true;
            this.CJLabel.Location = new System.Drawing.Point(197, 59);
            this.CJLabel.Name = "CJLabel";
            this.CJLabel.Size = new System.Drawing.Size(61, 17);
            this.CJLabel.TabIndex = 1;
            this.CJLabel.Text = "CJ Miller";
            this.CJLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // JasonLabel
            // 
            this.JasonLabel.AutoSize = true;
            this.JasonLabel.Location = new System.Drawing.Point(187, 76);
            this.JasonLabel.Name = "JasonLabel";
            this.JasonLabel.Size = new System.Drawing.Size(82, 17);
            this.JasonLabel.TabIndex = 2;
            this.JasonLabel.Text = "Jason Lane";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(264, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Created as a team project by students of";
            // 
            // LoganLabel
            // 
            this.LoganLabel.AutoSize = true;
            this.LoganLabel.Location = new System.Drawing.Point(177, 93);
            this.LoganLabel.Name = "LoganLabel";
            this.LoganLabel.Size = new System.Drawing.Size(103, 17);
            this.LoganLabel.TabIndex = 4;
            this.LoganLabel.Text = "Logan Erexson";
            // 
            // SourceLink
            // 
            this.SourceLink.AutoSize = true;
            this.SourceLink.Location = new System.Drawing.Point(197, 219);
            this.SourceLink.Name = "SourceLink";
            this.SourceLink.Size = new System.Drawing.Size(53, 17);
            this.SourceLink.TabIndex = 5;
            this.SourceLink.TabStop = true;
            this.SourceLink.Text = "Source";
            this.SourceLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(302, 156);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(94, 17);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Rose-Hulman";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // AboutWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 294);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.SourceLink);
            this.Controls.Add(this.LoganLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.JasonLabel);
            this.Controls.Add(this.CJLabel);
            this.Controls.Add(this.CreatedByLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AboutWindow";
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private wowahtDataSetTableAdapters.playerTableAdapter playerTableAdapter1;
        private System.Windows.Forms.Label CreatedByLabel;
        private System.Windows.Forms.Label CJLabel;
        private System.Windows.Forms.Label JasonLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LoganLabel;
        private System.Windows.Forms.LinkLabel SourceLink;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}