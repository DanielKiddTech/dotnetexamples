using dynamics_are_bad.Infrastructure;
using dynamics_are_bad.Models;

namespace dynamics_are_bad.Domain
{
    public class MovieService
    {
        private readonly IMovieRepository _movieRepository;

        public MovieService()
        {
            // This would usually be passed in via DI
            _movieRepository = new MovieRepository();
        }

        public dynamic GetMoviesAsDynamic()
        {
            return _movieRepository.GetMoviesAsDynamic();
        }

        public List<Movie> GetMovies()
        {
            return _movieRepository.GetMovies();
        }
    }
}
