using _33P_API_Rufkin.EndPoints;
using _33P_API_Rufkin.Models;
using _33P_API_Rufkin.Repositories;
using _33P_API_Rufkin.Servises;
using Microsoft.EntityFrameworkCore;

namespace _33P_API_Rufkin
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddAuthorization();
            builder.Services.AddDbContext<RufkinContext>();
            builder.Services.AddScoped<AuthorRepository>();
            builder.Services.AddScoped<AuthorServise>();
            builder.Services.AddScoped<GenreRepository>();
            builder.Services.AddScoped<GenreServise>();
            builder.Services.AddScoped<BookRepository>();
            builder.Services.AddScoped<BookServise>();
            builder.Services.AddScoped<BookGenreRepository>();
            builder.Services.AddScoped<BookGenreServise>();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            var app = builder.Build();
            app.MapAuthorEndPoints();
            app.MapGenreEndPoints();
            app.MapBookEndPoints();
            app.MapBookGenreEndPoints();
            app.UseAuthorization();
            app.UseStaticFiles();
            app.MapGet("/", () => "Hello World!");
            app.UseSwagger();
            app.UseSwaggerUI();
            app.Run();
        }
    }
}
