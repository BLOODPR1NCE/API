using System.Data;
using _33P_API_Rufkin.Models;
using _33P_API_Rufkin.Servises;

namespace _33P_API_Rufkin.EndPoints
{
    public static class BookEndPoint
    {
        public static IEndpointRouteBuilder MapBookEndPoints(this IEndpointRouteBuilder app)
        {
            app.MapGet("/booklist", (BookServise bookServises) => bookServises.GetBooks());

            app.MapGet("/booklist/{id}", (BookServise bookServises, int id) => bookServises.GetBook(id));

            app.MapDelete("/bookdelete/{id}", (BookServise bookServises, int id) => bookServises.DeleteBook(id));

            app.MapPost("/bookcreate", (BookServise bookServises, Book book) => bookServises.CreateBook(book));

            app.MapPut("/bookupdate", (BookServise bookServises, Book book) => bookServises.UpdateBook(book));

            return app;
        }

    }
}
