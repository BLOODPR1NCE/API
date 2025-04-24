using _33P_API_Rufkin.Repositories;
using Newtonsoft.Json;

namespace _33P_API_Rufkin.Servises
{
    public class GenreServise
    {
        readonly GenreRepository repository;
        public GenreServise(GenreRepository repository)
        {
            this.repository = repository;
        }

        public async Task<IResult> GetGenres() => Results.Text(JsonConvert.SerializeObject(await repository.GetGenres(), Formatting.Indented, new JsonSerializerSettings
        {
            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
        }));
    }
}
