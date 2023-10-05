using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMovies
{
    public class MovieRepository
    {
        private List<Movie> _movies;

        public void AddMovie(Movie movie)
        {
            _movies.Add(movie);
        }
    }
}
