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
            this.serverBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readMeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.ServerListTab = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ItemsTab = new System.Windows.Forms.TabPage();
            this.ProfessionTab = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serverIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uRLNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subRegionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serverPopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wowahtPublicDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wowahtPublicDataSet = new World_of_Warcraft_Auction_House_Tracker.wowahtPublicDataSet();
            this.serverTableAdapter = new World_of_Warcraft_Auction_House_Tracker.wowahtPublicDataSetTableAdapters.serverTableAdapter();
            this.itemsTableAdapter1 = new World_of_Warcraft_Auction_House_Tracker.wowahtPublicDataSetTableAdapters.itemsTableAdapter();
            this.auctionsTableAdapter1 = new World_of_Warcraft_Auction_House_Tracker.wowahtPublicDataSetTableAdapters.auctionsTableAdapter();
            this.auctionsTableAdapter2 = new World_of_Warcraft_Auction_House_Tracker.wowahtPublicDataSetTableAdapters.auctionsTableAdapter();
            this.woWItemIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.professionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.professionTableAdapter = new World_of_Warcraft_Auction_House_Tracker.wowahtPublicDataSetTableAdapters.professionTableAdapter();
            this.professionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abbrevationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serverBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.ServerListTab.SuspendLayout();
            this.ItemsTab.SuspendLayout();
            this.ProfessionTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wowahtPublicDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wowahtPublicDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.professionBindingSource)).BeginInit();
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
            this.dataGridView1.Location = new System.Drawing.Point(0, 28);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(571, 549);
            this.dataGridView1.TabIndex = 0;
            // 
            // serverBindingSource
            // 
            this.serverBindingSource.DataMember = "server";
            this.serverBindingSource.DataSource = this.wowahtPublicDataSetBindingSource;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(610, 28);
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
            this.tabControl.Controls.Add(this.ItemsTab);
            this.tabControl.Controls.Add(this.ProfessionTab);
            this.tabControl.Location = new System.Drawing.Point(16, 35);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(579, 596);
            this.tabControl.TabIndex = 2;
            // 
            // ServerListTab
            // 
            this.ServerListTab.Controls.Add(this.textBox1);
            this.ServerListTab.Controls.Add(this.dataGridView1);
            this.ServerListTab.Location = new System.Drawing.Point(4, 25);
            this.ServerListTab.Margin = new System.Windows.Forms.Padding(4);
            this.ServerListTab.Name = "ServerListTab";
            this.ServerListTab.Padding = new System.Windows.Forms.Padding(4);
            this.ServerListTab.Size = new System.Drawing.Size(571, 567);
            this.ServerListTab.TabIndex = 0;
            this.ServerListTab.Text = "Servers";
            this.ServerListTab.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox1.Location = new System.Drawing.Point(7, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(399, 22);
            this.textBox1.TabIndex = 1;
            // 
            // ItemsTab
            // 
            this.ItemsTab.Controls.Add(this.dataGridView2);
            this.ItemsTab.Location = new System.Drawing.Point(4, 25);
            this.ItemsTab.Margin = new System.Windows.Forms.Padding(4);
            this.ItemsTab.Name = "ItemsTab";
            this.ItemsTab.Padding = new System.Windows.Forms.Padding(4);
            this.ItemsTab.Size = new System.Drawing.Size(571, 567);
            this.ItemsTab.TabIndex = 1;
            this.ItemsTab.Text = "Items";
            this.ItemsTab.UseVisualStyleBackColor = true;
            this.ItemsTab.Click += new System.EventHandler(this.ItemsTab_Click);
            // 
            // ProfessionTab
            // 
            this.ProfessionTab.Controls.Add(this.dataGridView3);
            this.ProfessionTab.Location = new System.Drawing.Point(4, 25);
            this.ProfessionTab.Margin = new System.Windows.Forms.Padding(4);
            this.ProfessionTab.Name = "ProfessionTab";
            this.ProfessionTab.Padding = new System.Windows.Forms.Padding(4);
            this.ProfessionTab.Size = new System.Drawing.Size(571, 567);
            this.ProfessionTab.TabIndex = 2;
            this.ProfessionTab.Text = "Professions";
            this.ProfessionTab.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.woWItemIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn1,
            this.itemTypeDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.itemsBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(4, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(563, 559);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "items";
            this.itemsBindingSource.DataSource = this.wowahtPublicDataSetBindingSource;
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
            // itemsTableAdapter1
            // 
            this.itemsTableAdapter1.ClearBeforeFill = true;
            // 
            // auctionsTableAdapter1
            // 
            this.auctionsTableAdapter1.ClearBeforeFill = true;
            // 
            // auctionsTableAdapter2
            // 
            this.auctionsTableAdapter2.ClearBeforeFill = true;
            // 
            // woWItemIDDataGridViewTextBoxColumn
            // 
            this.woWItemIDDataGridViewTextBoxColumn.DataPropertyName = "WoW_Item_ID";
            this.woWItemIDDataGridViewTextBoxColumn.HeaderText = "WoW_Item_ID";
            this.woWItemIDDataGridViewTextBoxColumn.Name = "woWItemIDDataGridViewTextBoxColumn";
            this.woWItemIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.woWItemIDDataGridViewTextBoxColumn.Width = 175;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn1.Width = 150;
            // 
            // itemTypeDataGridViewTextBoxColumn
            // 
            this.itemTypeDataGridViewTextBoxColumn.DataPropertyName = "Item_Type";
            this.itemTypeDataGridViewTextBoxColumn.HeaderText = "Item_Type";
            this.itemTypeDataGridViewTextBoxColumn.Name = "itemTypeDataGridViewTextBoxColumn";
            this.itemTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemTypeDataGridViewTextBoxColumn.Width = 175;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AllowUserToOrderColumns = true;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.professionIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn2,
            this.abbrevationDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.professionBindingSource;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(4, 4);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(563, 559);
            this.dataGridView3.TabIndex = 0;
            // 
            // professionBindingSource
            // 
            this.professionBindingSource.DataMember = "profession";
            this.professionBindingSource.DataSource = this.wowahtPublicDataSetBindingSource;
            // 
            // professionTableAdapter
            // 
            this.professionTableAdapter.ClearBeforeFill = true;
            // 
            // professionIDDataGridViewTextBoxColumn
            // 
            this.professionIDDataGridViewTextBoxColumn.DataPropertyName = "Profession_ID";
            this.professionIDDataGridViewTextBoxColumn.HeaderText = "Profession_ID";
            this.professionIDDataGridViewTextBoxColumn.Name = "professionIDDataGridViewTextBoxColumn";
            this.professionIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.professionIDDataGridViewTextBoxColumn.Width = 170;
            // 
            // nameDataGridViewTextBoxColumn2
            // 
            this.nameDataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn2.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn2.Name = "nameDataGridViewTextBoxColumn2";
            this.nameDataGridViewTextBoxColumn2.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn2.Width = 175;
            // 
            // abbrevationDataGridViewTextBoxColumn
            // 
            this.abbrevationDataGridViewTextBoxColumn.DataPropertyName = "Abbrevation";
            this.abbrevationDataGridViewTextBoxColumn.HeaderText = "Abbrevation";
            this.abbrevationDataGridViewTextBoxColumn.Name = "abbrevationDataGridViewTextBoxColumn";
            this.abbrevationDataGridViewTextBoxColumn.ReadOnly = true;
            this.abbrevationDataGridViewTextBoxColumn.Width = 175;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 644);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serverBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.ServerListTab.ResumeLayout(false);
            this.ServerListTab.PerformLayout();
            this.ItemsTab.ResumeLayout(false);
            this.ProfessionTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wowahtPublicDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wowahtPublicDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.professionBindingSource)).EndInit();
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
        private System.Windows.Forms.TabPage ItemsTab;
        private System.Windows.Forms.TabPage ProfessionTab;
        private System.Windows.Forms.TextBox textBox1;
        private wowahtPublicDataSetTableAdapters.itemsTableAdapter itemsTableAdapter1;
        private wowahtPublicDataSetTableAdapters.auctionsTableAdapter auctionsTableAdapter1;
        private wowahtPublicDataSetTableAdapters.auctionsTableAdapter auctionsTableAdapter2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn woWItemIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource professionBindingSource;
        private wowahtPublicDataSetTableAdapters.professionTableAdapter professionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn professionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn abbrevationDataGridViewTextBoxColumn;
    }
}

