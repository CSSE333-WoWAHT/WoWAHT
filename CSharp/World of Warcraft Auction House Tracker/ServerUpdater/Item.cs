using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ServerUpdater
{
    public class BonusStat
    {
        public int stat { get; set; }
        public int amount { get; set; }
    }

    public class Damage
    {
        public int min { get; set; }
        public int max { get; set; }
        public double exactMin { get; set; }
        public double exactMax { get; set; }
    }

    public class WeaponInfo
    {
        public Damage damage { get; set; }
        public double weaponSpeed { get; set; }
        public double dps { get; set; }
    }

    public class ItemSource
    {
        public int sourceId { get; set; }
        public string sourceType { get; set; }
    }

    public class BonusSummary
    {
        public List<object> defaultBonusLists { get; set; }
        public List<object> chanceBonusLists { get; set; }
        public List<object> bonusChances { get; set; }
    }

    public class Item
    {
        public uint id { get; set; }
        public int disenchantingSkillRank { get; set; }
        public string description { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public int stackable { get; set; }
        public int itemBind { get; set; }
        public List<BonusStat> bonusStats { get; set; }
        public List<object> itemSpells { get; set; }
        public long buyPrice { get; set; }
        public int itemClass { get; set; }
        public int itemSubClass { get; set; }
        public int containerSlots { get; set; }
        public WeaponInfo weaponInfo { get; set; }
        public int inventoryType { get; set; }
        public bool equippable { get; set; }
        public int itemLevel { get; set; }
        public int maxCount { get; set; }
        public int maxDurability { get; set; }
        public int minFactionId { get; set; }
        public int minReputation { get; set; }
        public int quality { get; set; }
        public long sellPrice { get; set; }
        public int requiredSkill { get; set; }
        public int requiredLevel { get; set; }
        public int requiredSkillRank { get; set; }
        public ItemSource itemSource { get; set; }
        public int baseArmor { get; set; }
        public bool hasSockets { get; set; }
        public bool isAuctionable { get; set; }
        public int armor { get; set; }
        public int displayInfoId { get; set; }
        public string nameDescription { get; set; }
        public string nameDescriptionColor { get; set; }
        public bool upgradable { get; set; }
        public bool heroicTooltip { get; set; }
        public string context { get; set; }
        public List<object> bonusLists { get; set; }
        public List<string> availableContexts { get; set; }
        public BonusSummary bonusSummary { get; set; }


        public static Item getItem(uint id)
        {
            var webRequest = WebRequest.Create(@"http://us.battle.net/api/wow/item/" + id);

            try
            {
                String data;
                using (var response = webRequest.GetResponse())
                using (var content = response.GetResponseStream())
                using (var reader = new StreamReader(content))
                {
                    data = reader.ReadToEnd();
                }
                return Newtonsoft.Json.JsonConvert.DeserializeObject<Item>(data);
            }
            catch (WebException)
            {
                return null;
            }
        }
    }
}
