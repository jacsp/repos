using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class CourseRepository
    {
        private List<Course> courses = new List<Course>();

        public void AddCourse(Course course)
        {
            courses.Add(course);
        }

        public Course GetCourse(string name)
        {
            return courses.Find(i => i.Name == name);
        }

        public double GetTotalValue()
        {
            double total = 0;

            foreach (var course in courses)
            {
                total += Utility.GetValueOfCourse(course);
            }

            return total;
        }
    }
}
