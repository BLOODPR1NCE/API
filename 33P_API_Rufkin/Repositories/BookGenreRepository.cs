using _33P_API_Rufkin.Models;
using Microsoft.EntityFrameworkCore;

namespace _33P_API_Rufkin.Repositories
{
    public class BookGenreRepository: BaseRepository
    {
        public BookGenreRepository(RufkinContext testContext): base(testContext) { }

        public async Task<List<BooksGenre>> GetBookGenres() => await testContext.BooksGenres.Include(x => x.BookNavigation).Include(x => x.GenreNavigation).ToListAsync();
    }
}
