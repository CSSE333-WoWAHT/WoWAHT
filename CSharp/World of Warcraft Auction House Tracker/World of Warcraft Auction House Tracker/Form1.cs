using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using World_of_Warcraft_Auction_House_Tracker.Properties;

namespace World_of_Warcraft_Auction_House_Tracker
{
    public partial class Form1 : Form
    {
        public static MySql.Data.MySqlClient.MySqlConnection connection;
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
            if (connection == null)
            {
                connection = new MySql.Data.MySqlClient.MySqlConnection();
                connection.ConnectionString = Settings.Default.wowahtPublicConnectionString;
            }
            MySql.Data.MySqlClient.MySqlCommand command = new MySql.Data.MySqlClient.MySqlCommand("GetStatisticsForItemFromAuction", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("GetItemID", ItemStatisticsID.Text));
            command.Connection.Open();
            MySql.Data.MySqlClient.MySqlDataReader reader;
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                GlobalMedianDisplay.Text = reader["Median"].ToString();
                GlobalMeanDisplay.Text = reader["Mean"].ToString();
                GlobalModeDisplay.Text = reader["Mode"].ToString();
            }
            else
             {
                GlobalMedianDisplay.Text = "Invalid ID";
                GlobalMeanDisplay.Text = "Invalid ID";
                GlobalModeDisplay.Text = "Invalid ID";
             }
            reader.Close();
            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void tab_ServerStats_Click(object sender, EventArgs e)
        {

        }

        private void ServerStatsButton_Click(object sender, EventArgs e)
        {
            if (connection == null)
            {
                connection = new MySql.Data.MySqlClient.MySqlConnection();
                connection.ConnectionString = Settings.Default.wowahtPublicConnectionString;
            }
            MySql.Data.MySqlClient.MySqlCommand command = new MySql.Data.MySqlClient.MySqlCommand("GetStatisticsForServer", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("GetServerID", ServerStatsTextBox.Text));
            command.Connection.Open();
            MySql.Data.MySqlClient.MySqlDataReader reader;
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                AuctionsTodayLabel.Text = reader["NoOfAuctionsToday"].ToString();
                AuctionsTwoWeeksLabel.Text = reader["NoOfAuctionsInLastTwoWeeks"].ToString();
                AuctionsAllTimeLabel.Text = reader["NoOfAuctionsEver"].ToString();
            }
            else
            {
                AuctionsTodayLabel.Text = "Invalid ID";
                AuctionsTwoWeeksLabel.Text = "Invalid ID";
                AuctionsAllTimeLabel.Text = "Invalid ID";
            }
            reader.Close();
            connection.Close();

        }
    }
}
