using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerUpdater
{
    public class BlizzardAPI
    {
        public class AuctionAPIFile
        {
            public string url { get; set; }
            public long lastModified { get; set; }
        }

        public class AuctionAPIRootObject
        {
            public List<AuctionAPIFile> files { get; set; }
        }
    }


}
