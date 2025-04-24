using System.Data;
using _33P_API_Rufkin.Models;
using _33P_API_Rufkin.Servises;

namespace _33P_API_Rufkin.EndPoints
{

    public static class AuthorEndPoint
    {
        public static IEndpointRouteBuilder MapAuthorEndPoints(this IEndpointRouteBuilder app)
        {
            app.MapGet("/authorlist", (AuthorServise authorServises) => authorServises.GetAuthors());

            app.MapGet("/authorlist/{id}", (AuthorServise authorServises, int id) => authorServises.GetAuthor(id));

            app.MapPost("/authorcreate", (AuthorServise authorServises, Author author) => authorServises.CreateAuthor(author));

            app.MapPut("/authorupdate", (AuthorServise authorServises, Author author) => authorServises.UpdateAuthor(author));

            return app;
        }
    }
}
