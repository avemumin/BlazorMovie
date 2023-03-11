using ComponentInActionBlazor.Shared.Data;

namespace ComponentInActionBlazor.Client.Helpers;

public class Repository : IRepository
{
    public List<Movie> GetMovies()
    {
        var movies = new List<Movie>();
        if (!movies.Any())
        {
            movies.Add(new Movie() { Id = 1, Title = "Spider-Man: Far From Home", ReleaseDate = new DateTime(2019, 7, 2) });
            movies.Add(new Movie() { Id = 2, Title = "Mohana", ReleaseDate = new DateTime(2016, 11, 23) });
            movies.Add(new Movie() { Id = 3, Title = "Inception", ReleaseDate = new DateTime(2010, 7, 16) });
        }
        return movies;
    }
}

