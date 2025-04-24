using _33P_API_Rufkin.Repositories;
using Newtonsoft.Json;

namespace _33P_API_Rufkin.Servises
{
    public class BookGenreServise
    {
        readonly BookGenreRepository repository;
        public BookGenreServise(BookGenreRepository repository)
        {
            this.repository = repository;
        }

        public async Task<IResult> GetBookGenres() => Results.Text(JsonConvert.SerializeObject(await repository.GetBookGenres(), Formatting.Indented, new JsonSerializerSettings
        {
            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
        }));
    }
}
