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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readMeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ItemsTab = new System.Windows.Forms.TabPage();
            this.itemSearch = new System.Windows.Forms.TextBox();
            this.Items_Datagrid = new System.Windows.Forms.DataGridView();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ServerListTab = new System.Windows.Forms.TabPage();
            this.ServerSearch = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.ProfessionTab = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.professionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abbrevationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.professionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.serverTableAdapter = new World_of_Warcraft_Auction_House_Tracker.wowahtPublicDataSetTableAdapters.serverTableAdapter();
            this.itemsTableAdapter1 = new World_of_Warcraft_Auction_House_Tracker.wowahtPublicDataSetTableAdapters.itemsTableAdapter();
            this.auctionsTableAdapter1 = new World_of_Warcraft_Auction_House_Tracker.wowahtPublicDataSetTableAdapters.auctionsTableAdapter();
            this.auctionsTableAdapter2 = new World_of_Warcraft_Auction_House_Tracker.wowahtPublicDataSetTableAdapters.auctionsTableAdapter();
            this.professionTableAdapter = new World_of_Warcraft_Auction_House_Tracker.wowahtPublicDataSetTableAdapters.professionTableAdapter();
            this.Items_tabSelect = new System.Windows.Forms.TabControl();
            this.Items_SearchTab = new System.Windows.Forms.TabPage();
            this.Items_StatsTab = new System.Windows.Forms.TabPage();
            this.woWItemIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.itemTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serverBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wowahtPublicDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wowahtPublicDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.ItemsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Items_Datagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            this.ServerListTab.SuspendLayout();
            this.ProfessionTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.professionBindingSource)).BeginInit();
            this.Items_tabSelect.SuspendLayout();
            this.Items_SearchTab.SuspendLayout();
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
            this.dataGridView1.Size = new System.Drawing.Size(564, 549);
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
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
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
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.ItemsTab);
            this.tabControl.Controls.Add(this.ServerListTab);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.ProfessionTab);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Controls.Add(this.tabPage5);
            this.tabControl.Location = new System.Drawing.Point(18, 35);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(579, 596);
            this.tabControl.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(571, 567);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(571, 567);
            this.tabPage2.TabIndex = 4;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ItemsTab
            // 
            this.ItemsTab.Controls.Add(this.Items_tabSelect);
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
            // itemSearch
            // 
            this.itemSearch.Location = new System.Drawing.Point(3, 6);
            this.itemSearch.Name = "itemSearch";
            this.itemSearch.Size = new System.Drawing.Size(549, 22);
            this.itemSearch.TabIndex = 1;
            // 
            // Items_Datagrid
            // 
            this.Items_Datagrid.AllowUserToAddRows = false;
            this.Items_Datagrid.AllowUserToDeleteRows = false;
            this.Items_Datagrid.AllowUserToOrderColumns = true;
            this.Items_Datagrid.AutoGenerateColumns = false;
            this.Items_Datagrid.BackgroundColor = System.Drawing.Color.Black;
            this.Items_Datagrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.Items_Datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Items_Datagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.woWItemIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn1,
            this.itemTypeDataGridViewTextBoxColumn});
            this.Items_Datagrid.DataSource = this.itemsBindingSource;
            this.Items_Datagrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Items_Datagrid.Location = new System.Drawing.Point(3, 34);
            this.Items_Datagrid.Name = "Items_Datagrid";
            this.Items_Datagrid.ReadOnly = true;
            this.Items_Datagrid.RowHeadersVisible = false;
            this.Items_Datagrid.RowTemplate.Height = 24;
            this.Items_Datagrid.Size = new System.Drawing.Size(549, 493);
            this.Items_Datagrid.TabIndex = 0;
            this.Items_Datagrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "items";
            this.itemsBindingSource.DataSource = this.wowahtPublicDataSetBindingSource;
            // 
            // ServerListTab
            // 
            this.ServerListTab.Controls.Add(this.ServerSearch);
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
            // ServerSearch
            // 
            this.ServerSearch.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ServerSearch.Location = new System.Drawing.Point(7, 3);
            this.ServerSearch.Name = "ServerSearch";
            this.ServerSearch.Size = new System.Drawing.Size(548, 22);
            this.ServerSearch.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(571, 567);
            this.tabPage3.TabIndex = 5;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
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
            // professionBindingSource
            // 
            this.professionBindingSource.DataMember = "profession";
            this.professionBindingSource.DataSource = this.wowahtPublicDataSetBindingSource;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(571, 567);
            this.tabPage4.TabIndex = 6;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(571, 567);
            this.tabPage5.TabIndex = 7;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
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
            // professionTableAdapter
            // 
            this.professionTableAdapter.ClearBeforeFill = true;
            // 
            // Items_tabSelect
            // 
            this.Items_tabSelect.Controls.Add(this.Items_SearchTab);
            this.Items_tabSelect.Controls.Add(this.Items_StatsTab);
            this.Items_tabSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Items_tabSelect.Location = new System.Drawing.Point(4, 4);
            this.Items_tabSelect.Name = "Items_tabSelect";
            this.Items_tabSelect.SelectedIndex = 0;
            this.Items_tabSelect.Size = new System.Drawing.Size(563, 559);
            this.Items_tabSelect.TabIndex = 2;
            // 
            // Items_SearchTab
            // 
            this.Items_SearchTab.Controls.Add(this.Items_Datagrid);
            this.Items_SearchTab.Controls.Add(this.itemSearch);
            this.Items_SearchTab.Location = new System.Drawing.Point(4, 25);
            this.Items_SearchTab.Name = "Items_SearchTab";
            this.Items_SearchTab.Padding = new System.Windows.Forms.Padding(3);
            this.Items_SearchTab.Size = new System.Drawing.Size(555, 530);
            this.Items_SearchTab.TabIndex = 0;
            this.Items_SearchTab.Text = "Search";
            this.Items_SearchTab.UseVisualStyleBackColor = true;
            // 
            // Items_StatsTab
            // 
            this.Items_StatsTab.Location = new System.Drawing.Point(4, 25);
            this.Items_StatsTab.Name = "Items_StatsTab";
            this.Items_StatsTab.Padding = new System.Windows.Forms.Padding(3);
            this.Items_StatsTab.Size = new System.Drawing.Size(555, 530);
            this.Items_StatsTab.TabIndex = 1;
            this.Items_StatsTab.Text = "Statistics";
            this.Items_StatsTab.UseVisualStyleBackColor = true;
            // 
            // woWItemIDDataGridViewTextBoxColumn
            // 
            this.woWItemIDDataGridViewTextBoxColumn.DataPropertyName = "WoW_Item_ID";
            this.woWItemIDDataGridViewTextBoxColumn.HeaderText = "Item ID";
            this.woWItemIDDataGridViewTextBoxColumn.Name = "woWItemIDDataGridViewTextBoxColumn";
            this.woWItemIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.woWItemIDDataGridViewTextBoxColumn.Width = 175;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.nameDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // itemTypeDataGridViewTextBoxColumn
            // 
            this.itemTypeDataGridViewTextBoxColumn.DataPropertyName = "Item_Type";
            this.itemTypeDataGridViewTextBoxColumn.HeaderText = "Item Type";
            this.itemTypeDataGridViewTextBoxColumn.Name = "itemTypeDataGridViewTextBoxColumn";
            this.itemTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemTypeDataGridViewTextBoxColumn.Width = 175;
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
            ((System.ComponentModel.ISupportInitialize)(this.wowahtPublicDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wowahtPublicDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.ItemsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Items_Datagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            this.ServerListTab.ResumeLayout(false);
            this.ServerListTab.PerformLayout();
            this.ProfessionTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.professionBindingSource)).EndInit();
            this.Items_tabSelect.ResumeLayout(false);
            this.Items_SearchTab.ResumeLayout(false);
            this.Items_SearchTab.PerformLayout();
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
        private System.Windows.Forms.TextBox ServerSearch;
        private wowahtPublicDataSetTableAdapters.itemsTableAdapter itemsTableAdapter1;
        private wowahtPublicDataSetTableAdapters.auctionsTableAdapter auctionsTableAdapter1;
        private wowahtPublicDataSetTableAdapters.auctionsTableAdapter auctionsTableAdapter2;
        private System.Windows.Forms.DataGridView Items_Datagrid;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource professionBindingSource;
        private wowahtPublicDataSetTableAdapters.professionTableAdapter professionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn professionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn abbrevationDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TextBox itemSearch;
        private System.Windows.Forms.TabControl Items_tabSelect;
        private System.Windows.Forms.TabPage Items_SearchTab;
        private System.Windows.Forms.TabPage Items_StatsTab;
        private System.Windows.Forms.DataGridViewTextBoxColumn woWItemIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemTypeDataGridViewTextBoxColumn;
    }
}

