using ServerUpdater.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Timers;

namespace ServerUpdater
{
    class Program
    {
        public static Dictionary<String, String> realmURLs;
        public static Timer timer;
        public static String snapshotPath;

        public static MySql.Data.MySqlClient.MySqlConnection uploadConnection;

        static void Main(string[] args)
        {
            realmURLs = new Dictionary<String, String>();
            setupRealmURLs();

            setupTempFolder();

            timer = new Timer();
            timer.Interval = 60 * 1000 * 15;
            timer.Elapsed += updateAuctions;
            timer.AutoReset = true;
            timer.Start();

            while (!Console.ReadLine().Equals("Exit"))
            {

            }
        }

        public static void setupRealmURLs()
        {
            wowahtAdminDataSetTableAdapters.GetActiveServersForAPITableAdapter ta = new wowahtAdminDataSetTableAdapters.GetActiveServersForAPITableAdapter();
            wowahtAdminDataSet.GetActiveServersForAPIDataTable table = ta.GetData();

            foreach (wowahtAdminDataSet.GetActiveServersForAPIRow row in table.Rows)
            {
                String data;
                var webRequest = WebRequest.Create(@"http://us.battle.net/api/wow/auction/data/" + row.URL_Name);

                using (var response = webRequest.GetResponse())
                using (var content = response.GetResponseStream())
                using (var reader = new StreamReader(content))
                {
                    data = reader.ReadToEnd();
                }
                BlizzardAPI.AuctionAPIRootObject root = Newtonsoft.Json.JsonConvert.DeserializeObject<BlizzardAPI.AuctionAPIRootObject>(data);

                realmURLs.Add(row.Name, root.files[0].url);
            }
        }

        public static void setupTempFolder()
        {
            String path = Directory.GetCurrentDirectory() + "\\" + Settings.Default.snapshotFolder;
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            snapshotPath = path;
        }

        public static void updateAuctions(Object source, ElapsedEventArgs even)
        {
            foreach (String realm in realmURLs.Keys)
            {
                Console.WriteLine("Pulling Json Data for: " + realm);
                String data;
                var webRequest = WebRequest.Create(realmURLs[realm]);

                using (var response = webRequest.GetResponse())
                using (var content = response.GetResponseStream())
                using (var reader = new StreamReader(content))
                {
                    data = reader.ReadToEnd();
                }
                RootObject root = Newtonsoft.Json.JsonConvert.DeserializeObject<RootObject>(data);

                Console.WriteLine("Writing snapshot for: " + realm);
                String snapPath = snapshotPath + "\\" + realm + ".csv";
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(snapPath))
                {
                    foreach (Auction a in root.auctions.auctions)
                    {
                        file.WriteLine(Resources.AuctionToCSVWithRealm(realm, a));
                    }
                }

                Console.WriteLine("Sending data to database for: " + realm);
                uploadRawFile(snapPath);
            }
        }

        public static void uploadRawFile(String path)
        {
            if (uploadConnection == null)
            {
                uploadConnection = new MySql.Data.MySqlClient.MySqlConnection();
                uploadConnection.ConnectionString = Settings.Default.wowahtConnectionString;
            }
            uploadConnection.Open();
            String sqlPath = path.Replace("\\", "\\\\").Replace("'", "''");
            String query = "LOAD DATA LOCAL INFILE '" + sqlPath + @"' INTO TABLE auction_raw CHARACTER SET UTF8 FIELDS TERMINATED BY ',' ENCLOSED BY '''' ESCAPED BY '\\' LINES TERMINATED BY '\r\n';";
            MySql.Data.MySqlClient.MySqlCommand command = new MySql.Data.MySqlClient.MySqlCommand(query, uploadConnection);

            command.ExecuteNonQuery();

            uploadConnection.Close();
        }

        public static void testRun()
        {
            foreach (String realm in realmURLs.Keys)
            {
                Console.WriteLine("Pulling Json Data for: " + realm);
                String data;
                var webRequest = WebRequest.Create(realmURLs[realm]);

                using (var response = webRequest.GetResponse())
                using (var content = response.GetResponseStream())
                using (var reader = new StreamReader(content))
                {
                    data = reader.ReadToEnd();
                }
                RootObject root = Newtonsoft.Json.JsonConvert.DeserializeObject<RootObject>(data);

                Console.WriteLine("Writing snapshot for: " + realm);
                String snapPath = snapshotPath + "\\" + realm + ".csv";
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(snapPath))
                {
                    foreach (Auction a in root.auctions.auctions)
                    {
                        file.WriteLine(Resources.AuctionToCSVWithRealm(realm, a));
                    }
                }

                Console.WriteLine("Sending data to database for: " + realm);
                uploadRawFile(snapPath);
            }
        }
    }
}
