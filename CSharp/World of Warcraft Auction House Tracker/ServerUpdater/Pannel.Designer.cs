namespace ServerUpdater
{
    partial class Pannel
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
            this.ItemButton = new System.Windows.Forms.Button();
            this.RecipeButton = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.StopStartUpdateButton = new System.Windows.Forms.Button();
            this.updateTimer = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // ItemButton
            // 
            this.ItemButton.Location = new System.Drawing.Point(13, 13);
            this.ItemButton.Name = "ItemButton";
            this.ItemButton.Size = new System.Drawing.Size(100, 30);
            this.ItemButton.TabIndex = 0;
            this.ItemButton.Text = "Item Names";
            this.ItemButton.UseVisualStyleBackColor = true;
            this.ItemButton.Click += new System.EventHandler(this.ItemButton_Click);
            // 
            // RecipeButton
            // 
            this.RecipeButton.Location = new System.Drawing.Point(12, 49);
            this.RecipeButton.Name = "RecipeButton";
            this.RecipeButton.Size = new System.Drawing.Size(100, 30);
            this.RecipeButton.TabIndex = 1;
            this.RecipeButton.Text = "Recipe Names";
            this.RecipeButton.UseVisualStyleBackColor = true;
            this.RecipeButton.Click += new System.EventHandler(this.RecipeButton_Click);
            // 
            // textBox
            // 
            this.textBox.AcceptsReturn = true;
            this.textBox.AcceptsTab = true;
            this.textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox.Location = new System.Drawing.Point(126, 12);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox.Size = new System.Drawing.Size(678, 348);
            this.textBox.TabIndex = 2;
            // 
            // StopStartUpdateButton
            // 
            this.StopStartUpdateButton.Location = new System.Drawing.Point(12, 85);
            this.StopStartUpdateButton.Name = "StopStartUpdateButton";
            this.StopStartUpdateButton.Size = new System.Drawing.Size(100, 30);
            this.StopStartUpdateButton.TabIndex = 3;
            this.StopStartUpdateButton.Text = "Stop Updates";
            this.StopStartUpdateButton.UseVisualStyleBackColor = true;
            this.StopStartUpdateButton.Click += new System.EventHandler(this.StopStartUpdateButton_Click);
            // 
            // updateTimer
            // 
            this.updateTimer.Enabled = true;
            this.updateTimer.Interval = 900000;
            this.updateTimer.Tick += new System.EventHandler(this.updateTimer_Tick);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Text = "notifyIcon";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // Pannel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 372);
            this.Controls.Add(this.StopStartUpdateButton);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.RecipeButton);
            this.Controls.Add(this.ItemButton);
            this.Name = "Pannel";
            this.Text = "Pannel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ItemButton;
        private System.Windows.Forms.Button RecipeButton;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button StopStartUpdateButton;
        private System.Windows.Forms.Timer updateTimer;
        private System.Windows.Forms.NotifyIcon notifyIcon;
    }
}