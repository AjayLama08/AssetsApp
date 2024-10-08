using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

namespace AssetsApp.Data
{
    public class Asset
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Location Location { get; set; }
        public DateTime DateAcquired { get; set; }
        public bool InUse { get; set; }
        public double PurchasePrice { get; set; }

        public Asset()
        {
            Name = string.Empty;
        }

        public Asset(int id, string name,  Location location, DateTime dateAcquired, bool inUse, double purchasePrice)
        {
            Id = id;
            Name = name;
            Location = location;
            DateAcquired = dateAcquired;
            InUse = inUse;
            PurchasePrice = purchasePrice;
        }

        public override string ToString()
        {
            var str = Id + ": " + $"{Name} {Location} {"("}{DateAcquired.ToShortDateString()}{")"} { InUse} {"£"}{PurchasePrice} {"**"}";
            return str;
        }

    }
}


