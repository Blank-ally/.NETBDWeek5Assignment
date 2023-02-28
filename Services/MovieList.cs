using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationTemplate.Services
{
    internal class MovieList
    {
       List<Movie> movies = new List<Movie>();

        List<string> JsonMovies = new List<string>();

        List<String> title = new List<string>();
        List<Int64> Id = new List<Int64>();
        public void AddMovie(Movie movie, String json)
        {
            JsonMovies.Add(json);
          
            title.Add(movie.Title);
            Id.Add(movie.ID);
            movie = JsonConvert.DeserializeObject<Movie>(json);
            movies.Add(movie);
        }

        public void getMovies()
        
            {
                foreach (Movie movie in movies)
                {
                Console.WriteLine(movie.Display());
                
                }
            }

      

        public void getMovieTitles()
        {
            foreach (String title in title)
            {
                Console.WriteLine($"Title:{title}");
            }
        }
        public void getMovieIDs()
        {
            foreach (Int64 id in Id) {
                Console.WriteLine($"ID:{id}");

            }
        }


    }
}
