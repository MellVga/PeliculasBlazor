using BlazorPeliculas.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorPeliculas.Client.Repositories
{
    public class Repository : IRepository
    {
        public List<Movie> GetAllMovies()
        {
            return new List<Movie>()
            {
            new Movie(){ Title = "Titanic", Releasing = DateTime.Now},
            new Movie(){ Title = "SpiderMan", Releasing = DateTime.Now},
            new Movie(){ Title = "Moana", Releasing = DateTime.Now}
            };
        }
    }
}
