using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ServerUpdater
{
    public class Spell
    {
        public uint id { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public string description { get; set; }
        public string range { get; set; }
        public string powerCost { get; set; }
        public string castTime { get; set; }
        public string cooldown { get; set; }

        public static Spell getSpell(uint id)
        {
            var webRequest = WebRequest.Create(@"http://us.battle.net/api/wow/spell/" + id);

            String data;
            try
            {
                using (var response = webRequest.GetResponse())
                using (var content = response.GetResponseStream())
                using (var reader = new StreamReader(content))
                {
                    data = reader.ReadToEnd();
                }
                return Newtonsoft.Json.JsonConvert.DeserializeObject<Spell>(data);
            }
            catch (WebException)
            {
                return null;
            }
        }
    }

}
