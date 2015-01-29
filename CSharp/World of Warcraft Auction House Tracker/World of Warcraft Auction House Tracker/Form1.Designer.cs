namespace World_of_Warcraft_Auction_House_Tracker
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.serverIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uRLNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subRegionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serverPopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serverBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wowahtPublicDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wowahtPublicDataSet = new World_of_Warcraft_Auction_House_Tracker.wowahtPublicDataSet();
            this.serverTableAdapter = new World_of_Warcraft_Auction_House_Tracker.wowahtPublicDataSetTableAdapters.serverTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readMeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.ServerListTab = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serverBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wowahtPublicDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wowahtPublicDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.ServerListTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serverIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.uRLNameDataGridViewTextBoxColumn,
            this.subRegionDataGridViewTextBoxColumn,
            this.regionDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.serverPopDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.serverBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(4, 4);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(569, 557);
            this.dataGridView1.TabIndex = 0;
            // 
            // serverIDDataGridViewTextBoxColumn
            // 
            this.serverIDDataGridViewTextBoxColumn.DataPropertyName = "Server_ID";
            this.serverIDDataGridViewTextBoxColumn.HeaderText = "Server_ID";
            this.serverIDDataGridViewTextBoxColumn.Name = "serverIDDataGridViewTextBoxColumn";
            this.serverIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.serverIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uRLNameDataGridViewTextBoxColumn
            // 
            this.uRLNameDataGridViewTextBoxColumn.DataPropertyName = "URL_Name";
            this.uRLNameDataGridViewTextBoxColumn.HeaderText = "URL_Name";
            this.uRLNameDataGridViewTextBoxColumn.Name = "uRLNameDataGridViewTextBoxColumn";
            this.uRLNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.uRLNameDataGridViewTextBoxColumn.Visible = false;
            // 
            // subRegionDataGridViewTextBoxColumn
            // 
            this.subRegionDataGridViewTextBoxColumn.DataPropertyName = "Sub_Region";
            this.subRegionDataGridViewTextBoxColumn.HeaderText = "Sub_Region";
            this.subRegionDataGridViewTextBoxColumn.Name = "subRegionDataGridViewTextBoxColumn";
            this.subRegionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // regionDataGridViewTextBoxColumn
            // 
            this.regionDataGridViewTextBoxColumn.DataPropertyName = "Region";
            this.regionDataGridViewTextBoxColumn.HeaderText = "Region";
            this.regionDataGridViewTextBoxColumn.Name = "regionDataGridViewTextBoxColumn";
            this.regionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // serverPopDataGridViewTextBoxColumn
            // 
            this.serverPopDataGridViewTextBoxColumn.DataPropertyName = "Server_Pop";
            this.serverPopDataGridViewTextBoxColumn.HeaderText = "Server_Pop";
            this.serverPopDataGridViewTextBoxColumn.Name = "serverPopDataGridViewTextBoxColumn";
            this.serverPopDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // serverBindingSource
            // 
            this.serverBindingSource.DataMember = "server";
            this.serverBindingSource.DataSource = this.wowahtPublicDataSetBindingSource;
            // 
            // wowahtPublicDataSetBindingSource
            // 
            this.wowahtPublicDataSetBindingSource.DataSource = this.wowahtPublicDataSet;
            this.wowahtPublicDataSetBindingSource.Position = 0;
            // 
            // wowahtPublicDataSet
            // 
            this.wowahtPublicDataSet.DataSetName = "wowahtPublicDataSet";
            this.wowahtPublicDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // serverTableAdapter
            // 
            this.serverTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(595, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "topMenuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.quitToolStripMenuItem.Text = "Quit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.readMeToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(133, 24);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // readMeToolStripMenuItem
            // 
            this.readMeToolStripMenuItem.Name = "readMeToolStripMenuItem";
            this.readMeToolStripMenuItem.Size = new System.Drawing.Size(133, 24);
            this.readMeToolStripMenuItem.Text = "ReadMe";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.ServerListTab);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Location = new System.Drawing.Point(16, 34);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(585, 594);
            this.tabControl.TabIndex = 2;
            // 
            // ServerListTab
            // 
            this.ServerListTab.Controls.Add(this.dataGridView1);
            this.ServerListTab.Location = new System.Drawing.Point(4, 25);
            this.ServerListTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ServerListTab.Name = "ServerListTab";
            this.ServerListTab.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ServerListTab.Size = new System.Drawing.Size(577, 565);
            this.ServerListTab.TabIndex = 0;
            this.ServerListTab.Text = "Servers";
            this.ServerListTab.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(1065, 565);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Size = new System.Drawing.Size(1065, 565);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 644);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serverBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wowahtPublicDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wowahtPublicDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.ServerListTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource wowahtPublicDataSetBindingSource;
        private wowahtPublicDataSet wowahtPublicDataSet;
        private System.Windows.Forms.BindingSource serverBindingSource;
        private wowahtPublicDataSetTableAdapters.serverTableAdapter serverTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn serverIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uRLNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subRegionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serverPopDataGridViewTextBoxColumn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readMeToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage ServerListTab;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
    }
}

