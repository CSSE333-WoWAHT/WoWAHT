using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerUpdater
{
    class Resources
    {
        public static String AuctionToCSVWithRealm(String Realm, Auction a)
        {
            return Realm + "," + AuctionToCSV(a);
        }

        public static String AuctionToCSV(Auction a)
        {
            return a.auc + "," + a.item + "," + a.owner + "," + a.ownerRealm + "," + a.bid + "," + a.buyout + "," + a.quantity + "," + a.timeLeft + "," + a.rand + "," + a.seed + "," + a.context + "," + replaceNull(a.petSpeciesId) + "," + replaceNull(a.petBreedId) + "," + replaceNull(a.petLevel) + "," + replaceNull(a.petQualityId);
        }

        public static String replaceNull(Object o)
        {
            if (o == null)
            {
                return "NULL";
            }
            else
                return o.ToString();
        }
    }
}
