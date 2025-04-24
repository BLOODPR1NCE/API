using _33P_API_Rufkin.Models;
using System.Data;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace _33P_API_Rufkin.Repositories
{
    public class AuthorRepository : BaseRepository
    {
        public AuthorRepository(RufkinContext testContext) : base(testContext) { }
        public async Task<List<Author>> GetAuthors() => await testContext.Authors.ToListAsync();

        public async Task<Author> GetAuthor(int id)
        {
            return await testContext.Authors.FirstOrDefaultAsync(x => x.Id == id);
        }
        public async Task CreateAuthor(Author author)
        {
            testContext.Authors.Add(author);
            testContext.SaveChanges();
        }

        public async Task UpdateAuthor(Author author)
        {
            testContext.Authors.Update(author);
            testContext.SaveChanges();
        }

    }
}
