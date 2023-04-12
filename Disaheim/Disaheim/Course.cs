using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Course : IValuable
    {
        public string Name { get; set; }
        public int DurationInMinutes { get; set; }
        public static double CourseHourValue = 875.0;

        public Course(string name, int durationInMinutes)
        {
            Name = name;
            DurationInMinutes = durationInMinutes;
        }

        public Course(string name) : this(name, 0)
        {
            Name = name;
        }

        public double GetValue()
        {
            int remainder;
            int startedhours = Math.DivRem(DurationInMinutes, 60, out remainder);

            if (remainder == 0)
            {
                return CourseHourValue * startedhours;
            }
            else
            {
                startedhours += 1;
                return CourseHourValue * startedhours;
            }
        }

        public override string ToString()
        {
            return $"Name: {Name}, Duration in Minutes: {DurationInMinutes}, Value: {GetValue()}";
        }
    }
}
