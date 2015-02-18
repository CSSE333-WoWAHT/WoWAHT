namespace World_of_Warcraft_Auction_House_Tracker
{
    partial class ReadMeWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(515, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Overview: Contains statistics about the Auction House Tracker Database. There \r\ni" +
    "s also an option to change the connection string.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Auctions: Shows list of current auctions.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(512, 34);
            this.label3.TabIndex = 2;
            this.label3.Text = "Items: Shows list of auctionable items. List can be filtered using search box, an" +
    "d \r\nstatistics for each item can be found by selecting one in the table.";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(523, 34);
            this.label4.TabIndex = 3;
            this.label4.Text = "Servers: Shows list of servers. List can be filtered using search box, and statis" +
    "tics \r\nfor each server can be found by selecting one in the table.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(516, 34);
            this.label5.TabIndex = 4;
            this.label5.Text = "Players: Shows list of players. List can be filtered using search box, and statis" +
    "tics\r\nabout each player can be found by selecting one.  ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(406, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Professions: Lists all potential professions in World of Warcraft.\r\n";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(494, 34);
            this.label7.TabIndex = 6;
            this.label7.Text = "Search Raw: Allows user to do an advanced search for auctions or to search \r\nusin" +
    "g raw sql code.";
            // 
            // ReadMeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 468);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ReadMeWindow";
            this.Text = "Read Me";
            this.Load += new System.EventHandler(this.ReadMeWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}