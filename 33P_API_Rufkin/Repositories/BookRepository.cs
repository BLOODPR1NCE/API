using System.Data;
using _33P_API_Rufkin.Models;
using Microsoft.EntityFrameworkCore;

namespace _33P_API_Rufkin.Repositories
{
    public class BookRepository: BaseRepository
    {
        public BookRepository(RufkinContext testContext) : base(testContext) { }

        public async Task<List<Book>> GetBooks() => await testContext.Books.Include(x => x.AuthorNavigation).ToListAsync();

        public async Task<Book> GetBook(int id)
        {
            return await testContext.Books.Include(x => x.AuthorNavigation).FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task DeleteBook(int id)
        {
            testContext.Remove(await testContext.Books.FirstOrDefaultAsync(x => x.Id == id));
            testContext.SaveChanges();
        }

        public async Task CreateBook(Book book)
        {
            testContext.Books.Add(book);
            testContext.SaveChanges();
        }

        public async Task UpdateBook(Book book)
        {
            testContext.Books.Update(book);
            testContext.SaveChanges();
        }
    }
}
