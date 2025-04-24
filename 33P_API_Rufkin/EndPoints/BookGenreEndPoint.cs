using _33P_API_Rufkin.Servises;

namespace _33P_API_Rufkin.EndPoints
{
    public static class BookGenreEndPoint
    {
        public static IEndpointRouteBuilder MapBookGenreEndPoints(this IEndpointRouteBuilder app)
        {
            app.MapGet("/bookgenrelist", (BookGenreServise bookgenreServises) => bookgenreServises.GetBookGenres());
            return app;
        }
    }
}
