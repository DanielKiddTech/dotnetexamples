using dynamics_are_bad.Models;

namespace dynamics_are_bad.Infrastructure
{
    public interface IMovieRepository
    {
        dynamic GetMoviesAsDynamic();
        List<Movie> GetMovies();
    }
}
