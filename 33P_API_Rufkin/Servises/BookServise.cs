using System.Data;
using _33P_API_Rufkin.Models;
using _33P_API_Rufkin.Repositories;
using Newtonsoft.Json;

namespace _33P_API_Rufkin.Servises
{
    public class BookServise
    {
        readonly BookRepository repository;
        public BookServise(BookRepository repository)
        {
            this.repository = repository;
        }

        public async Task<IResult> GetBooks() => Results.Text(JsonConvert.SerializeObject(await repository.GetBooks(), Formatting.Indented, new JsonSerializerSettings
        {
            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
        }));

        public async Task<IResult> GetBook(int id) => Results.Text(JsonConvert.SerializeObject(await repository.GetBook(id), Formatting.Indented, new JsonSerializerSettings
        {
            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
        }));


        public async Task DeleteBook(int id) => await repository.DeleteBook(id);

        public async Task CreateBook(Book book) => await repository.CreateBook(book);

        public async Task UpdateBook(Book book) => await repository.UpdateBook(book);
    }
}
