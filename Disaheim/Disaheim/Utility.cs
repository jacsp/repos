using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public static class Utility
    {
        public static double LowQualityValue { get; set; } = 12.5;
        public static double MediumQualityValue { get; set; } = 20.0;
        public static double HighQualityValue { get; set; } = 27.5;
        public static double CourseHourValue { get; set; } = 875.0;

        //public static double GetValueOfBook(Book book)
        //{
        //    return book.Price;
        //}

        //public static double GetValueOfAmulet(Amulet amulet)
        //{
        //    switch(amulet.Quality)
        //    {
        //        case Level.low:
        //            return 12.5;
        //            break;
        //        case Level.medium:
        //            return 20.0;
        //            break;
        //        case Level.high:
        //            return 27.5;
        //            break;
        //        default:
        //            return 0;
        //    }
        //}

        public static double GetValueOfMerchandise(Merchandise merchandise)
        {
            if (merchandise.GetType() == typeof(Book))
            {
                Book book = (Book)merchandise;

                return book.Price;
            }
            else if (merchandise.GetType() == typeof(Amulet))
            {
                Amulet amulet = (Amulet)merchandise;

                switch (amulet.Quality)
                {
                    case Level.low:
                        return LowQualityValue;
                        break;
                    case Level.medium:
                        return MediumQualityValue;
                        break;
                    case Level.high:
                        return HighQualityValue;
                        break;
                    default:
                        return 0;
                }
            }
            else
            {
                return 0;
            }
        }

        public static double GetValueOfCourse(Course course)
        {
            int remainder;
            int startedHours = Math.DivRem(course.DurationInMinutes, 60, out remainder);

            if (remainder == 0)
            {
                return CourseHourValue * startedHours;
            }
            else
            {
                startedHours += 1;
                return CourseHourValue * startedHours;
            }
        }
    }
}
