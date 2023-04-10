using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Disaheim
{
    public class AmuletRepository
    {
        private List<Amulet> amulets = new List<Amulet>();

        public void AddAmulet(Amulet amulet)
        {
            amulets.Add(amulet);
        }

        public Amulet GetAmulet(string itemId)
        {
            return amulets.Find(i => i.ItemId == itemId);
        }

        public double GetTotalValue()
        {
            double total = 0;

            foreach (var amulet in amulets)
            {
                total += Utility.GetValueOfMerchandise(amulet);
            }

            return total;
        }
    }
}
