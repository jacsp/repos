using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Utility
    {
        public double GetValueOfBook(Book book)
        {
            return book.Price;
        }

        public double GetValueOfAmulet(Amulet amulet)
        {
            switch(amulet.Quality)
            {
                case Level.low:
                    return 12.5;
                    break;
                case Level.medium:
                    return 20.0;
                    break;
                case Level.high:
                    return 27.5;
                    break;
                default:
                    return 0;
            }
        }

        public double GetValueOfCourse(Course course)
        {
            int remainder;
            int startedHours = Math.DivRem(course.DurationInMinutes, 60, out remainder);

            if (remainder == 0)
            {
                return 875 * startedHours;
            }
            else
            {
                startedHours += 1;
                return 875 * startedHours;
            }
        }
    }
}
