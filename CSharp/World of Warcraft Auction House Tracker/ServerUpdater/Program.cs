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
        public static String snapshotPath;

        public static MySql.Data.MySqlClient.MySqlConnection uploadConnection;

        static void Main(string[] args)
        {
            realmURLs = new Dictionary<String, String>();
            setupRealmURLs();

            setupTempFolder();

            var pannel = new Pannel().ShowDialog();
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
    }
}
