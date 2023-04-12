using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class ValuableRepository
    {
        private List<IValuable> valuables = new List<IValuable>();

        public void AddValuable(IValuable valuable)
        {
            valuables.Add(valuable);
        }

        public IValuable GetValuable(string id)
        {
            IValuable valuable;

            for (int i = 0; i < valuables.Count; i++)
            {
                if (valuables[i].GetType() == typeof(Book))
                {
                    Book temp = (Book)valuables[i];

                    if (temp.ItemId == id)
                    {
                        return valuables[i];
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (valuables[i].GetType() == typeof(Amulet))
                {
                    Amulet temp = (Amulet)valuables[i];

                    if (temp.ItemId == id)
                    {
                        return valuables[i];
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (valuables[i].GetType() == typeof(Course))
                {
                    Course temp = (Course)valuables[i];

                    if (temp.Name == id)
                    {
                        return valuables[i];
                    }
                    else
                    {
                        continue;
                    }
                }
                else
                {
                    return null;
                }
            }

            return null;
        }

        public double GetTotalValue()
        {
            double total = 0;

            for (int i = 0; i < valuables.Count; i++)
            {
                total += valuables[i].GetValue();
            }

            return total;
        }

        public int Count()
        {
            return valuables.Count;
        }

    }
}
