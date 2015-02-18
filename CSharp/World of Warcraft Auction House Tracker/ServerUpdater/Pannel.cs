using ServerUpdater.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerUpdater
{
    public partial class Pannel : Form
    {

        public Pannel()
        {
            InitializeComponent();

            this.Resize += resize_Event;
        }

        private void RecipeButton_Click(object sender, EventArgs e)
        {

        }

        private void StopStartUpdateButton_Click(object sender, EventArgs e)
        {
            if (this.updateTimer.Enabled)
            {
                this.updateTimer.Enabled = false;
                printToConsole("Auto Updates Stopped");
                StopStartUpdateButton.Text = "Resume Updates";
            }
            else
            {
                this.updateTimer.Enabled = true;
                printToConsole("Auto Updates Resumed");
                StopStartUpdateButton.Text = "Stop Updates";
            }
        }

        public void printToConsole(String message)
        {
            textBox.Text += message + "\r\n";
        }

        private void resize_Event(object sender, System.EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
                Hide();
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void updateTimer_Tick(object sender, EventArgs e)
        {
            updateAuctions();
        }

        public void updateAuctions()
        {
            foreach (String realm in Program.realmURLs.Keys)
            {
                printToConsole("Pulling Json Data for: " + realm);
                String data;
                var webRequest = WebRequest.Create(Program.realmURLs[realm]);

                using (var response = webRequest.GetResponse())
                using (var content = response.GetResponseStream())
                using (var reader = new StreamReader(content))
                {
                    data = reader.ReadToEnd();
                }
                RootObject root = Newtonsoft.Json.JsonConvert.DeserializeObject<RootObject>(data);

                printToConsole("Writing snapshot for: " + realm);
                String snapPath = Program.snapshotPath + "\\" + realm + ".csv";
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(snapPath))
                {
                    foreach (Auction a in root.auctions.auctions)
                    {
                        file.WriteLine(Resources.AuctionToCSVWithRealm(realm, a));
                    }
                }

                printToConsole("Sending data to database for: " + realm);
                uploadRawFile(snapPath);
            }
        }

        public static void uploadRawFile(String path)
        {
            if (Program.uploadConnection == null)
            {
                Program.uploadConnection = new MySql.Data.MySqlClient.MySqlConnection();
                Program.uploadConnection.ConnectionString = Settings.Default.wowahtConnectionString;
            }
            Program.uploadConnection.Open();
            String sqlPath = path.Replace(@"\", @"\\").Replace("'", "''");
            String query = "LOAD DATA LOCAL INFILE '" + sqlPath + @"' INTO TABLE auction_raw CHARACTER SET UTF8 FIELDS TERMINATED BY ',' ENCLOSED BY '''' ESCAPED BY '\\' LINES TERMINATED BY '\r\n';";
            MySql.Data.MySqlClient.MySqlCommand command = new MySql.Data.MySqlClient.MySqlCommand(query, Program.uploadConnection);

            command.ExecuteNonQuery();

            Program.uploadConnection.Close();
        }

        private void ItemButton_Click(object sender, EventArgs e)
        {
            wowahtAdminDataSetTableAdapters.itemNullStatsTableAdapter iTa = new wowahtAdminDataSetTableAdapters.itemNullStatsTableAdapter();
            wowahtAdminDataSet.itemNullStatsDataTable idt = iTa.GetData();

            foreach (wowahtAdminDataSet.itemNullStatsRow row in idt.Rows)
            {
                Item item = Item.getItem(row.WoW_Item_ID);
                if (item == null)
                    continue;
                iTa.UpdateQuery(item.sellPrice, item.buyPrice, item.name, item.isAuctionable, row.WoW_Item_ID);
            }
        }

        private void PlayerButton_Click(object sender, EventArgs e)
        {
            wowahtAdminDataSetTableAdapters.professionTableAdapter profTa = new wowahtAdminDataSetTableAdapters.professionTableAdapter();
            wowahtAdminDataSet.professionDataTable profdt = profTa.GetData();

            Dictionary<String, int> professions = new Dictionary<string, int>();

            foreach ( wowahtAdminDataSet.professionRow row in profdt.Rows)
            {
                professions.Add(row.Name.ToUpper(),row.Profession_ID);
            }

            wowahtAdminDataSetTableAdapters.playerNullProfTableAdapter pTa = new wowahtAdminDataSetTableAdapters.playerNullProfTableAdapter();
            wowahtAdminDataSet.playerNullProfDataTable pdt = pTa.GetData();

            foreach (wowahtAdminDataSet.playerNullProfRow row in pdt.Rows)
            {
                Player player = Player.getPlayer(row.URL_Name, row.Name);
                if (player == null)
                    continue;
                byte? p1 = null;
                byte? p2 = null;

                switch (player.professions.primary.Count)
                {
                    case 0:
                        continue;
                    case 2:
                        p1 = (byte) professions[player.professions.primary[0].name.ToUpper()];
                        //No Break continue to case1
                        goto default;
                    default:
                        p2 = (byte) professions[player.professions.primary[1].name.ToUpper()];
                        break;
                }

                pTa.UpdatePlayerProfQuery(p1, p2, row.Player_ID);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


    }
}
