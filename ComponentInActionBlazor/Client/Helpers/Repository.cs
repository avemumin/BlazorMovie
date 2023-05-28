using ComponentInActionBlazor.Shared.Data;

namespace ComponentInActionBlazor.Client.Helpers;

public class Repository : IRepository
{
    public List<Movie> GetMovies()
    {
        var movies = new List<Movie>();
        if (!movies.Any())
        {
            movies.Add(new Movie() { Id = 1, Title = "Spider-Man: Far From Home",
                ReleaseDate = new DateTime(2019, 7, 2),
                Poster = "https://m.media-amazon.com/images/M/MV5BMGZlNTY1ZWUtYTMzNC00ZjUyLWE0MjQtMTMxN2E3ODYxMWVmXkEyXkFqcGdeQXVyMDM2NDM2MQ@@._V1_FMjpg_UY474_.jpg "
            });
            movies.Add(new Movie() { Id = 2, Title = "Moana",
                ReleaseDate = new DateTime(2016, 11, 23),
                Poster = "https://m.media-amazon.com/images/M/MV5BMjI4MzU5NTExNF5BMl5BanBnXkFtZTgwNzY1MTEwMDI@._V1_FMjpg_UY474_.jpg "
            });
            movies.Add(new Movie() { Id = 3, Title = "Inception",
                ReleaseDate = new DateTime(2010, 7, 16),
                Poster = "https://m.media-amazon.com/images/M/MV5BMjAxMzY3NjcxNF5BMl5BanBnXkFtZTcwNTI5OTM0Mw@@._V1_FMjpg_UY474_.jpg"
            });
        }
        return movies;
    }
}

