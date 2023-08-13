using dynamics_are_bad.Models;
using System.Dynamic;

namespace dynamics_are_bad.Infrastructure
{
    public class MovieRepository : IMovieRepository
    {
        public dynamic GetMoviesAsDynamic()
        {
            List<ExpandoObject> movies = new List<ExpandoObject>();

            dynamic movie = new ExpandoObject();
            movie.Name = "Titanic";
            movie.Description = "A seventeen-year-old aristocrat falls in love with a kind but poor artist aboard the luxurious, ill-fated R.M.S. Titanic.";

            movies.Add(movie);

            return movies;
        }

        public List<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie
                {
                    Name = "Titanic",
                    Description = "A seventeen-year-old aristocrat falls in love with a kind but poor artist aboard the luxurious, ill-fated R.M.S. Titanic."
                }
            };
        }
    }
}
