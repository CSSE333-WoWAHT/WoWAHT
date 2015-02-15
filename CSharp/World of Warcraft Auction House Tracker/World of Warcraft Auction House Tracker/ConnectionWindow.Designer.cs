namespace World_of_Warcraft_Auction_House_Tracker
{
    partial class ConnectionWindow
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
            this.connectionWarningLabel = new System.Windows.Forms.Label();
            this.connectionStringEntry = new System.Windows.Forms.TextBox();
            this.connectionStringLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // connectionWarningLabel
            // 
            this.connectionWarningLabel.AutoSize = true;
            this.connectionWarningLabel.Location = new System.Drawing.Point(12, 31);
            this.connectionWarningLabel.Name = "connectionWarningLabel";
            this.connectionWarningLabel.Size = new System.Drawing.Size(563, 34);
            this.connectionWarningLabel.TabIndex = 5;
            this.connectionWarningLabel.Text = "WARNING: Changes to the connection string are not reversible. If you want to be a" +
    "ble to\r\nreconnect to the current server, copy the existing string first.";
            // 
            // connectionStringEntry
            // 
            this.connectionStringEntry.Location = new System.Drawing.Point(253, 6);
            this.connectionStringEntry.Name = "connectionStringEntry";
            this.connectionStringEntry.Size = new System.Drawing.Size(318, 22);
            this.connectionStringEntry.TabIndex = 4;
            // 
            // connectionStringLabel
            // 
            this.connectionStringLabel.AutoSize = true;
            this.connectionStringLabel.Location = new System.Drawing.Point(12, 9);
            this.connectionStringLabel.Name = "connectionStringLabel";
            this.connectionStringLabel.Size = new System.Drawing.Size(235, 17);
            this.connectionStringLabel.TabIndex = 3;
            this.connectionStringLabel.Text = "Connection String (requires restart):";
            // 
            // ConnectionWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 75);
            this.Controls.Add(this.connectionWarningLabel);
            this.Controls.Add(this.connectionStringEntry);
            this.Controls.Add(this.connectionStringLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ConnectionWindow";
            this.Text = "Connection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label connectionWarningLabel;
        private System.Windows.Forms.TextBox connectionStringEntry;
        private System.Windows.Forms.Label connectionStringLabel;
    }
}