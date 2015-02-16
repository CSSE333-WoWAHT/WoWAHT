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
            this.recipe_inRMLabel = new System.Windows.Forms.Label();
            this.auctionRMLabel = new System.Windows.Forms.Label();
            this.recipeRMLabel = new System.Windows.Forms.Label();
            this.playerRMLabel = new System.Windows.Forms.Label();
            this.itemRMLabel = new System.Windows.Forms.Label();
            this.serverRMLabel = new System.Windows.Forms.Label();
            this.professionRMLabel = new System.Windows.Forms.Label();
            this.recipe_outRMLabel = new System.Windows.Forms.Label();
            this.timeRMLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(469, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Overview: Contains statistics about the Auction House Tracker Database.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(543, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Auctions: Shows list of current auctions. List can be filtered by item, player, o" +
    "r server.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(924, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Items: Shows list of auctionable items. List can be filtered using search box, an" +
    "d statistics for each item can be found by selecting one in the table.";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(891, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Servers: Shows list of servers. List can be filtered using search box, and statis" +
    "tics for each server can be found by selecting one in the table.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(840, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Players: Shows list of players. List can be filtered using search box, and statis" +
    "tics about each player can be found by selecting one.  ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(406, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Professions: Lists all potential professions in World of Warcraft.\r\n";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(682, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Search Raw: Allows user to search the database using raw sql code. The following " +
    "tables can be accessed:";
            // 
            // recipe_inRMLabel
            // 
            this.recipe_inRMLabel.AutoSize = true;
            this.recipe_inRMLabel.Location = new System.Drawing.Point(21, 271);
            this.recipe_inRMLabel.Name = "recipe_inRMLabel";
            this.recipe_inRMLabel.Size = new System.Drawing.Size(401, 17);
            this.recipe_inRMLabel.TabIndex = 7;
            this.recipe_inRMLabel.Text = "recipe_input: Contains data about each input item for a recipe.";
            // 
            // auctionRMLabel
            // 
            this.auctionRMLabel.AutoSize = true;
            this.auctionRMLabel.Location = new System.Drawing.Point(21, 189);
            this.auctionRMLabel.Name = "auctionRMLabel";
            this.auctionRMLabel.Size = new System.Drawing.Size(278, 17);
            this.auctionRMLabel.TabIndex = 8;
            this.auctionRMLabel.Text = "auction: Contains data about each auction.";
            // 
            // recipeRMLabel
            // 
            this.recipeRMLabel.AutoSize = true;
            this.recipeRMLabel.Location = new System.Drawing.Point(21, 249);
            this.recipeRMLabel.Name = "recipeRMLabel";
            this.recipeRMLabel.Size = new System.Drawing.Size(264, 17);
            this.recipeRMLabel.TabIndex = 11;
            this.recipeRMLabel.Text = "recipe: Contains data about each recipe.";
            // 
            // playerRMLabel
            // 
            this.playerRMLabel.AutoSize = true;
            this.playerRMLabel.Location = new System.Drawing.Point(21, 227);
            this.playerRMLabel.Name = "playerRMLabel";
            this.playerRMLabel.Size = new System.Drawing.Size(264, 17);
            this.playerRMLabel.TabIndex = 12;
            this.playerRMLabel.Text = "player: Contains data about each player.";
            // 
            // itemRMLabel
            // 
            this.itemRMLabel.AutoSize = true;
            this.itemRMLabel.Location = new System.Drawing.Point(21, 208);
            this.itemRMLabel.Name = "itemRMLabel";
            this.itemRMLabel.Size = new System.Drawing.Size(238, 17);
            this.itemRMLabel.TabIndex = 13;
            this.itemRMLabel.Text = "item: Contains data about each item.";
            // 
            // serverRMLabel
            // 
            this.serverRMLabel.AutoSize = true;
            this.serverRMLabel.Location = new System.Drawing.Point(21, 335);
            this.serverRMLabel.Name = "serverRMLabel";
            this.serverRMLabel.Size = new System.Drawing.Size(266, 17);
            this.serverRMLabel.TabIndex = 14;
            this.serverRMLabel.Text = "server: Contains data about each server.";
            // 
            // professionRMLabel
            // 
            this.professionRMLabel.AutoSize = true;
            this.professionRMLabel.Location = new System.Drawing.Point(21, 314);
            this.professionRMLabel.Name = "professionRMLabel";
            this.professionRMLabel.Size = new System.Drawing.Size(318, 17);
            this.professionRMLabel.TabIndex = 15;
            this.professionRMLabel.Text = "profession: Contains data about each profession.";
            this.professionRMLabel.Click += new System.EventHandler(this.professionRMLabel_Click);
            // 
            // recipe_outRMLabel
            // 
            this.recipe_outRMLabel.AutoSize = true;
            this.recipe_outRMLabel.Location = new System.Drawing.Point(21, 292);
            this.recipe_outRMLabel.Name = "recipe_outRMLabel";
            this.recipe_outRMLabel.Size = new System.Drawing.Size(419, 17);
            this.recipe_outRMLabel.TabIndex = 16;
            this.recipe_outRMLabel.Text = "recipe_output: Contains data about each output item for a recipe.";
            // 
            // timeRMLabel
            // 
            this.timeRMLabel.AutoSize = true;
            this.timeRMLabel.Location = new System.Drawing.Point(21, 355);
            this.timeRMLabel.Name = "timeRMLabel";
            this.timeRMLabel.Size = new System.Drawing.Size(349, 17);
            this.timeRMLabel.TabIndex = 18;
            this.timeRMLabel.Text = "time: Contains data about the different lengths of time.";
            // 
            // ReadMeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 446);
            this.Controls.Add(this.timeRMLabel);
            this.Controls.Add(this.recipe_outRMLabel);
            this.Controls.Add(this.professionRMLabel);
            this.Controls.Add(this.serverRMLabel);
            this.Controls.Add(this.itemRMLabel);
            this.Controls.Add(this.playerRMLabel);
            this.Controls.Add(this.recipeRMLabel);
            this.Controls.Add(this.auctionRMLabel);
            this.Controls.Add(this.recipe_inRMLabel);
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
        private System.Windows.Forms.Label recipe_inRMLabel;
        private System.Windows.Forms.Label auctionRMLabel;
        private System.Windows.Forms.Label recipeRMLabel;
        private System.Windows.Forms.Label playerRMLabel;
        private System.Windows.Forms.Label itemRMLabel;
        private System.Windows.Forms.Label serverRMLabel;
        private System.Windows.Forms.Label professionRMLabel;
        private System.Windows.Forms.Label recipe_outRMLabel;
        private System.Windows.Forms.Label timeRMLabel;
    }
}