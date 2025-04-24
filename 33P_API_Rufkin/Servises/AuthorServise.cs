using System.Data;
using _33P_API_Rufkin.Models;
using _33P_API_Rufkin.Repositories;
using Newtonsoft.Json;

namespace _33P_API_Rufkin.Servises
{
    public class AuthorServise
    {
        readonly AuthorRepository repository;
        public AuthorServise(AuthorRepository repository)
        {
            this.repository = repository;
        }
        public async Task<IResult> GetAuthors() => Results.Text(JsonConvert.SerializeObject(await repository.GetAuthors(), Formatting.Indented, new JsonSerializerSettings
        {
            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
        }));

        public async Task<IResult> GetAuthor(int id) => Results.Text(JsonConvert.SerializeObject(await repository.GetAuthor(id), Formatting.Indented, new JsonSerializerSettings
        {
            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
        }));
        public async Task CreateAuthor(Author author) => await repository.CreateAuthor(author);

        public async Task UpdateAuthor(Author author) => await repository.UpdateAuthor(author);
    }
}
