using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ServerUpdater
{
    class Program
    {
        static void Main(string[] args)
        {
            String data;

            var webRequest = WebRequest.Create(@"http://us.battle.net/auction-data/5bc6c35600c6bc1c75581be4a68b82a4/auctions.json");

            using (var response = webRequest.GetResponse())
            using(var content = response.GetResponseStream())
            using(var reader = new StreamReader(content)){
                data = reader.ReadToEnd();
            }
            RootObject root = Newtonsoft.Json.JsonConvert.DeserializeObject<RootObject>(data);
            int max = 0;
            foreach (Auction a in root.auctions.auctions)
            {
                if (a.modifiers != null && a.modifiers.Count > 0)
                    if (a.modifiers.Count > max)
                        max = a.modifiers.Count;
            }

            Console.WriteLine(max);
            
        }
    }
}
