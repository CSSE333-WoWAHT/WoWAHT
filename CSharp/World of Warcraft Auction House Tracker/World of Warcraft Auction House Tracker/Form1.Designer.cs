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
            this.wowahtPublicDataSet = new World_of_Warcraft_Auction_House_Tracker.wowahtPublicDataSet();
            this.wowahtPublicDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serverBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serverTableAdapter = new World_of_Warcraft_Auction_House_Tracker.wowahtPublicDataSetTableAdapters.serverTableAdapter();
            this.serverIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uRLNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subRegionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serverPopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wowahtPublicDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wowahtPublicDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serverBindingSource)).BeginInit();
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
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(804, 498);
            this.dataGridView1.TabIndex = 0;
            // 
            // wowahtPublicDataSet
            // 
            this.wowahtPublicDataSet.DataSetName = "wowahtPublicDataSet";
            this.wowahtPublicDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // wowahtPublicDataSetBindingSource
            // 
            this.wowahtPublicDataSetBindingSource.DataSource = this.wowahtPublicDataSet;
            this.wowahtPublicDataSetBindingSource.Position = 0;
            // 
            // serverBindingSource
            // 
            this.serverBindingSource.DataMember = "server";
            this.serverBindingSource.DataSource = this.wowahtPublicDataSetBindingSource;
            // 
            // serverTableAdapter
            // 
            this.serverTableAdapter.ClearBeforeFill = true;
            // 
            // serverIDDataGridViewTextBoxColumn
            // 
            this.serverIDDataGridViewTextBoxColumn.DataPropertyName = "Server_ID";
            this.serverIDDataGridViewTextBoxColumn.HeaderText = "Server_ID";
            this.serverIDDataGridViewTextBoxColumn.Name = "serverIDDataGridViewTextBoxColumn";
            this.serverIDDataGridViewTextBoxColumn.ReadOnly = true;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 523);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wowahtPublicDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wowahtPublicDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serverBindingSource)).EndInit();
            this.ResumeLayout(false);

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
    }
}

