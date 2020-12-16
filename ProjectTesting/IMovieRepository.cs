using ProjectTesting.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectTesting
{
    public interface IMovieRepository
    {
        public IEnumerable<MovieModel> GetMovies(string userInput);
    }
}
