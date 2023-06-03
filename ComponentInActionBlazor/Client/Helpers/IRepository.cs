using ComponentInActionBlazor.Shared.Data;

namespace ComponentInActionBlazor.Client.Helpers;

public interface IRepository
{
    Task<List<Movie>> GetMovies();
}

