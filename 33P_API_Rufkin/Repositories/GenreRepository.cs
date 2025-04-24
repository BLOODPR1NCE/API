using _33P_API_Rufkin.Models;
using Microsoft.EntityFrameworkCore;

namespace _33P_API_Rufkin.Repositories
{
    public class GenreRepository: BaseRepository
    {
        public GenreRepository(RufkinContext testContext) : base(testContext) { }

        public async Task<List<Genre>> GetGenres() => await testContext.Genres.ToListAsync();
    }
}
