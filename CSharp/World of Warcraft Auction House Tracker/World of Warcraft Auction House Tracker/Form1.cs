using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace World_of_Warcraft_Auction_House_Tracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'wowahtPublicDataSet.profession' table. You can move, or remove it, as needed.
            this.professionTableAdapter.Fill(this.wowahtPublicDataSet.profession);
            // TODO: This line of code loads data into the 'wowahtPublicDataSet.server' table. You can move, or remove it, as needed.
            this.serverTableAdapter.Fill(this.wowahtPublicDataSet.server);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.itemsTableAdapter1.FillBy(this.wowahtPublicDataSet.items);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void getAllFromItemsToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.itemsTableAdapter1.GetAllFromItems(this.wowahtPublicDataSet.items);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void ItemsTab_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ServerSearch_TextChanged(object sender, EventArgs e)
        {
            (Servers_DataGrid.DataSource as BindingSource).Filter = string.Format("Name Like '{0}*'", ServerSearchTextBox.Text.Replace("'", "''"));
        }

        private void Servers_DataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Servers_SearchLabel_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            wowahtPublicDataSetTableAdapters.auctionTableAdapter ta = new wowahtPublicDataSetTableAdapters.auctionTableAdapter();
            wowahtPublicDataSet.auctionDataTable dt = ta.GetData();
        }
    }
}
