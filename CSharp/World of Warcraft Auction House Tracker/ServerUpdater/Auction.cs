using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerUpdater
{

    public class Realm
    {
        public string name { get; set; }
        public string slug { get; set; }
    }

    public class BonusList
    {
        public int bonusListId { get; set; }
    }

    public class Modifier
    {
        public int type { get; set; }
        public int value { get; set; }
    }

    public class Auction
    {
        public ulong auc { get; set; }
        public uint item { get; set; }
        public string owner { get; set; }
        public string ownerRealm { get; set; }
        public ulong bid { get; set; }
        public ulong buyout { get; set; }
        public uint quantity { get; set; }
        public string timeLeft { get; set; }
        public long rand { get; set; }
        public long seed { get; set; }
        public long context { get; set; }
        public List<BonusList> bonusLists { get; set; }
        public List<Modifier> modifiers { get; set; }
        public uint? petSpeciesId { get; set; }
        public uint? petBreedId { get; set; }
        public uint? petLevel { get; set; }
        public uint? petQualityId { get; set; }
    }

    public class Auctions
    {
        public List<Auction> auctions { get; set; }
    }

    public class RootObject
    {
        public Realm realm { get; set; }
        public Auctions auctions { get; set; }
    }


}
