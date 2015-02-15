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
            this.createdByLabel = new System.Windows.Forms.Label();
            this.cJLabel = new System.Windows.Forms.Label();
            this.jasonLabel = new System.Windows.Forms.Label();
            this.teamProjectLabel = new System.Windows.Forms.Label();
            this.loganLabel = new System.Windows.Forms.Label();
            this.sourceLink = new System.Windows.Forms.LinkLabel();
            this.roseHulmanLink = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // playerTableAdapter1
            // 
            this.playerTableAdapter1.ClearBeforeFill = true;
            // 
            // createdByLabel
            // 
            this.createdByLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.createdByLabel.AutoSize = true;
            this.createdByLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.createdByLabel.Location = new System.Drawing.Point(187, 42);
            this.createdByLabel.Name = "createdByLabel";
            this.createdByLabel.Size = new System.Drawing.Size(82, 17);
            this.createdByLabel.TabIndex = 0;
            this.createdByLabel.Text = "Created By:";
            this.createdByLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.createdByLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // cJLabel
            // 
            this.cJLabel.AutoSize = true;
            this.cJLabel.Location = new System.Drawing.Point(197, 59);
            this.cJLabel.Name = "cJLabel";
            this.cJLabel.Size = new System.Drawing.Size(61, 17);
            this.cJLabel.TabIndex = 1;
            this.cJLabel.Text = "CJ Miller";
            this.cJLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // jasonLabel
            // 
            this.jasonLabel.AutoSize = true;
            this.jasonLabel.Location = new System.Drawing.Point(187, 76);
            this.jasonLabel.Name = "jasonLabel";
            this.jasonLabel.Size = new System.Drawing.Size(82, 17);
            this.jasonLabel.TabIndex = 2;
            this.jasonLabel.Text = "Jason Lane";
            // 
            // teamProjectLabel
            // 
            this.teamProjectLabel.AutoSize = true;
            this.teamProjectLabel.Location = new System.Drawing.Point(43, 156);
            this.teamProjectLabel.Name = "teamProjectLabel";
            this.teamProjectLabel.Size = new System.Drawing.Size(264, 17);
            this.teamProjectLabel.TabIndex = 3;
            this.teamProjectLabel.Text = "Created as a team project by students of";
            // 
            // loganLabel
            // 
            this.loganLabel.AutoSize = true;
            this.loganLabel.Location = new System.Drawing.Point(177, 93);
            this.loganLabel.Name = "loganLabel";
            this.loganLabel.Size = new System.Drawing.Size(103, 17);
            this.loganLabel.TabIndex = 4;
            this.loganLabel.Text = "Logan Erexson";
            // 
            // sourceLink
            // 
            this.sourceLink.AutoSize = true;
            this.sourceLink.Location = new System.Drawing.Point(197, 219);
            this.sourceLink.Name = "sourceLink";
            this.sourceLink.Size = new System.Drawing.Size(53, 17);
            this.sourceLink.TabIndex = 5;
            this.sourceLink.TabStop = true;
            this.sourceLink.Text = "Source";
            this.sourceLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // roseHulmanLink
            // 
            this.roseHulmanLink.AutoSize = true;
            this.roseHulmanLink.LinkColor = System.Drawing.Color.Black;
            this.roseHulmanLink.Location = new System.Drawing.Point(302, 156);
            this.roseHulmanLink.Name = "roseHulmanLink";
            this.roseHulmanLink.Size = new System.Drawing.Size(94, 17);
            this.roseHulmanLink.TabIndex = 6;
            this.roseHulmanLink.TabStop = true;
            this.roseHulmanLink.Text = "Rose-Hulman";
            this.roseHulmanLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // AboutWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 294);
            this.Controls.Add(this.roseHulmanLink);
            this.Controls.Add(this.sourceLink);
            this.Controls.Add(this.loganLabel);
            this.Controls.Add(this.teamProjectLabel);
            this.Controls.Add(this.jasonLabel);
            this.Controls.Add(this.cJLabel);
            this.Controls.Add(this.createdByLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AboutWindow";
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private wowahtDataSetTableAdapters.playerTableAdapter playerTableAdapter1;
        private System.Windows.Forms.Label createdByLabel;
        private System.Windows.Forms.Label cJLabel;
        private System.Windows.Forms.Label jasonLabel;
        private System.Windows.Forms.Label teamProjectLabel;
        private System.Windows.Forms.Label loganLabel;
        private System.Windows.Forms.LinkLabel sourceLink;
        private System.Windows.Forms.LinkLabel roseHulmanLink;
    }
}