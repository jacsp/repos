using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class ValuableRepository : IPersistable
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

        public void Save(string fileName = "ValuableRepository")
        {
            using (StreamWriter sw = new StreamWriter(fileName))
            {
                foreach (var valuable in valuables)
                {
                    if (typeof(Course) == valuable.GetType())
                    {
                        Course course = (Course)valuable;
                        sw.WriteLine($"COURSE;{course.Name};{course.DurationInMinutes}");
                    }
                    else if (typeof(Book) == valuable.GetType())
                    {
                        Book book = (Book)valuable;
                        sw.WriteLine($"BOOK;{book.ItemId};{book.Title};{book.Price}");
                    }
                    else if (typeof(Amulet) == valuable.GetType())
                    {
                        Amulet amulet = (Amulet)valuable;
                        sw.WriteLine($"AMULET;{amulet.ItemId};{amulet.Quality};{amulet.Design}");
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
            }
        }

        public void Load(string fileName = "ValuableRepository")
        {
            string line;
            string[] values;

            using (StreamReader sr = new StreamReader(fileName))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    values = line.Split(";");

                    if (values[0] == "COURSE")
                    {
                        Course course = new(values[1], int.Parse(values[2]));
                        valuables.Add(course);
                    }
                    else if (values[0] == "BOOK")
                    {
                        Book book = new(values[1], values[2], double.Parse(values[3]));
                        valuables.Add(book);
                    }
                    else if (values[0] == "AMULET")
                    {
                        Amulet amulet = new(values[1], (Level)Enum.Parse(typeof(Level), values[2]), values[3]);
                        valuables.Add(amulet);
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        }
    }
}
