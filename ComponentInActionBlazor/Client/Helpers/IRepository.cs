using ComponentInActionBlazor.Shared.Data;

namespace ComponentInActionBlazor.Client.Helpers;

public interface IRepository
{
    List<Movie> GetMovies();
}

