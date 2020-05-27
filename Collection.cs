using System;
using System.Collections.Generic;

namespace MovieCollection
{
    public class Collection
    {
        private List<Movie> _movies = new List<Movie>();
        public void AddMovie(Movie newMovie)
        {
            _movies.Add(newMovie);
        }

        public Movie GetMovie(int index)
        {
            return _movies[index];
        }

        public void PrintMovies()
        {
            Console.WriteLine();
            for (int i = 0; i < _movies.Count; i++)
            {
                Movie theMovie = _movies[i];
                Console.WriteLine($"{i} {theMovie.Title}");
            }
        }
    }
}