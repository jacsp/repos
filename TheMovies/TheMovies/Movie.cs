using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMovies
{
    public class Movie
    {
        public string Title { get; set; }
        public int LengthInMinutes { get; set; }
        public string Genre { get; set; }

        public Movie(string title, int lengthInMinutes, string genre)
        {
            Title = title;
            LengthInMinutes = lengthInMinutes;
            Genre = genre;
        }
    }
}
