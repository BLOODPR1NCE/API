using _33P_API_Rufkin.Servises;

namespace _33P_API_Rufkin.EndPoints
{
    public static class GenreEndPoint
    {
        public static IEndpointRouteBuilder MapGenreEndPoints(this IEndpointRouteBuilder app)
        {
            app.MapGet("/genrelist", (GenreServise genreServises) => genreServises.GetGenres());
            return app;
        }
    }
}
