using _33P_API_Rufkin.Models;

namespace _33P_API_Rufkin.Repositories
{
    public class BaseRepository
    {
        readonly protected RufkinContext testContext;
        public BaseRepository(RufkinContext testContext) => this.testContext = testContext;
    }
}
