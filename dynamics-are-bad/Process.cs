using dynamics_are_bad.Domain;
using dynamics_are_bad.Models;

namespace dynamics_are_bad
{
    public static class Process
    {
        public static void Run(int numberOfLoops, int numberOfThreads)
        {
            List<Task> tasks = GenerateTaskThreads(numberOfLoops, numberOfThreads);

            Task.WaitAll(tasks.ToArray());
        }

        private static List<Task> GenerateTaskThreads(int numberOfLoops, int numberOfThreads)
        {
            List<Task> tasks = new List<Task>();

            for (int i = 0; i < numberOfThreads; i++)
            {
                tasks.Add(
                    Task.Factory.StartNew(() => PerformActionWithDynamics(numberOfLoops))
                );
            }

            return tasks;
        }

        private static void PerformActionWithDynamics(int numberOfLoops)
        {
            MovieService movieService = new MovieService();

            for (int i = 0; i < numberOfLoops; i++)
            {
                dynamic movies = movieService.GetMoviesAsDynamic();

                foreach (dynamic movie in movies)
                {
                    Console.WriteLine(movie.Name);
                    Console.WriteLine(movie.Description);
                }
            }
        }

        private static void PerformActionWithConcreteClasses(int numberOfLoops)
        {
            MovieService movieService = new MovieService();

            for (int i = 0; i < numberOfLoops; i++)
            {
                List<Movie> movies = movieService.GetMovies();

                foreach (Movie movie in movies)
                {
                    Console.WriteLine(movie.Name);
                    Console.WriteLine(movie.Description);
                }
            }
        }
    }
}
