using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class MerchandiseRepository
    {
        private List<Merchandise> merchandises= new List<Merchandise>();

        public void AddMerchandise(Merchandise merchandise)
        {
            merchandises.Add(merchandise);
        }

        public Merchandise GetMerchandise(string itemId)
        {
            return merchandises.Find(i => i.ItemId == itemId);
        }

        public double GetTotalValue()
        {
            double total = 0;

            foreach (var merchandise in merchandises)
            {
                total += Utility.GetValueOfMerchandise(merchandise);
            }

            return total;
        }
    }
}
