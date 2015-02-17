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
    public partial class WoWAHTMainWindow : Form
    {
        public static MySql.Data.MySqlClient.MySqlConnection connection;
        public WoWAHTMainWindow()
        {
            InitializeComponent();
            wowahtPublicDataSetTableAdapters.itemsTableAdapter ita = new wowahtPublicDataSetTableAdapters.itemsTableAdapter();
            wowahtPublicDataSetTableAdapters.auctionsTableAdapter ata = new wowahtPublicDataSetTableAdapters.auctionsTableAdapter();
            Items_Datagrid.DataSource = ita.GetData();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'wowahtPublicDataSet1.playerDataAll' table. You can move, or remove it, as needed.
            this.playerDataAllTableAdapter.Fill(this.wowahtPublicDataSet.playerDataAll);
            // TODO: This line of code loads data into the 'wowahtPublicDataSet.players' table. You can move, or remove it, as needed.
            this.playersTableAdapter.Fill(this.wowahtPublicDataSet.players);
            // TODO: This line of code loads data into the 'wowahtDataSet.player' table. You can move, or remove it, as needed.
            this.playerTableAdapter.Fill(this.wowahtDataSet.player);
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

        private void ServerSearch_TextChanged(object sender, EventArgs e)
        {
            (Servers_DataGrid.DataSource as BindingSource).Filter = string.Format("Name Like '{0}*'", ServerSearchTextBox.Text.Replace("'", "''"));
        }

        private void PlayersServerSearch_TextChanged(object sender, EventArgs e)
        {
            (PlayersDataGridView.DataSource as BindingSource).Filter = string.Format("Name1 Like '{0}*' AND Name Like '{1}*'", PlayersServerSearch.Text.Replace("'", "''"), PlayerNameSearch.Text.Replace("'", "''"));
        }

        private void itemSearch_TextChanged(object sender, EventArgs e)
        {
            var idg = Items_Datagrid.DataSource;
            var temp = idg as DataTable;
            temp.DefaultView.RowFilter = string.Format("Name Like '{0}*'", itemSearch.Text.Replace("'", "''"));
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
                GlobalStDevDisplay.Text = reader["Std. Deviation"].ToString();
                MerchantBuyLabel.Text = reader["Buy_Price"].ToString();
                if (MerchantBuyLabel.Text == "0")
                    MerchantBuyLabel.Text = "Unavailable";
                MerchantSellLabel.Text = reader["Sell_Price"].ToString();
            }
            else
             {
                GlobalMedianDisplay.Text = "Invalid ID";
                GlobalMeanDisplay.Text = "Invalid ID";
                GlobalModeDisplay.Text = "Invalid ID";
                GlobalStDevDisplay.Text = "Invalid ID";
                MerchantBuyLabel.Text = "Invalid ID";
                MerchantSellLabel.Text = "Invalid ID";
             }
            reader.Close();
            MySql.Data.MySqlClient.MySqlCommand command2 = new MySql.Data.MySqlClient.MySqlCommand("GetRecipesForItem", connection);
            command2.CommandType = CommandType.StoredProcedure;
            command2.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("GetItemID", ItemStatisticsID.Text));
            DataTable dt = new DataTable();
            dt.Load(command2.ExecuteReader(), LoadOption.OverwriteChanges);
            ItemRecipesGrid.DataSource = dt;
            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Servers_DataGrid_CellContentClick (object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                //TODO - Button Clicked - Execute Code Here
                tabControl1.SelectedTab = tab_ServerStats;
                ServerStatsTextBox.Text = Servers_DataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                ServerStatsButton_Click(null, null);
            }
        }

        private void Items_Datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                //TODO - Button Clicked - Execute Code Here
                Items_tabSelect.SelectedTab = Items_StatsTab;
                ItemStatisticsID.Text = Items_Datagrid.Rows[e.RowIndex].Cells["woWItemIDDataGridViewTextBoxColumn"].Value.ToString();
                button2_Click(null, null);
            }
        }

        private void PlayersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                //TODO - Button Clicked - Execute Code Here
                PlayersTabs.SelectedTab = PlayerStatsTab;
                UsernameSearchBox.Text = PlayersDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                PlayerStatsServer.Text = PlayersDataGridView.Rows[e.RowIndex].Cells["Server_ID"].Value.ToString();
                UsernameSearchButton_Click(null, null);
            }
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
            command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("GetServerName", ServerStatsTextBox.Text));
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

        private void ItemsServerIDButton_Click(object sender, EventArgs e)
        {
            if (connection == null)
            {
                connection = new MySql.Data.MySqlClient.MySqlConnection();
                connection.ConnectionString = Settings.Default.wowahtPublicConnectionString;
            }
            MySql.Data.MySqlClient.MySqlCommand command = new MySql.Data.MySqlClient.MySqlCommand("GetStatisticsForItemForServer", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("GetItemID", ItemStatisticsID.Text));
            command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("GetServerName", ItemStatsServerBox.Text));
            command.Connection.Open();
            MySql.Data.MySqlClient.MySqlDataReader reader;
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                ServerMedianDisplay.Text = reader["Median"].ToString();
                ServerMeanDisplay.Text = reader["Mean"].ToString();
                ServerModeDisplay.Text = reader["Mode"].ToString();
                ServerStDevDisplay.Text = reader["Std. Deviation"].ToString();
            }
            else
            {
                ServerMedianDisplay.Text = "Invalid ID";
                ServerMeanDisplay.Text = "Invalid ID";
                ServerModeDisplay.Text = "Invalid ID";
                ServerStDevDisplay.Text = "Invalid ID";
            }
            reader.Close();
            connection.Close();

        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UsernameSearchButton_Click(object sender, EventArgs e)
        {
            if (connection == null)
            {
                connection = new MySql.Data.MySqlClient.MySqlConnection();
                connection.ConnectionString = Settings.Default.wowahtPublicConnectionString;
            }
            MySql.Data.MySqlClient.MySqlCommand command = new MySql.Data.MySqlClient.MySqlCommand("GetStatisticsForPlayer", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("GetPlayerName", UsernameSearchBox.Text));
            command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("GetServerID", PlayerStatsServer.Text));
            command.Connection.Open();
            MySql.Data.MySqlClient.MySqlDataReader reader;
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                PlayerAuctionsTodayLabel.Text = reader["NoOfAuctionsToday"].ToString();
                PlayerAuctionsTwoWeeksLabel.Text = reader["NoOfAuctionsInLastTwoWeeks"].ToString();
                PlayerAuctionsAllTimeLabel.Text = reader["NoOfAuctionsEver"].ToString();
            }
            else
            {
                PlayerAuctionsTodayLabel.Text = "Invalid ID";
                PlayerAuctionsTwoWeeksLabel.Text = "Invalid ID";
                PlayerAuctionsAllTimeLabel.Text = "Invalid ID";
            }
            reader.Close();
            connection.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection == null)
                {
                    connection = new MySql.Data.MySqlClient.MySqlConnection();
                    connection.ConnectionString = Settings.Default.wowahtPublicConnectionString;
                }
                MySql.Data.MySqlClient.MySqlCommand command = new MySql.Data.MySqlClient.MySqlCommand(QueryBox.Text, connection);
                command.CommandType = CommandType.Text;
                command.Connection.Open();
                DataTable dt = new DataTable();
                dt.Load(command.ExecuteReader(), LoadOption.OverwriteChanges);
                ResultsDataGrid.DataSource = dt;
                SearchRawTabs.SelectedTab = ResultsTab;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(),"SQL Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void dataSourceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ConnectionWindow().Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutWindow().Show();
        }

        private void readMeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ReadMeWindow().Show(); 
        }

    }
}
