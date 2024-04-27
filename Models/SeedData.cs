using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Data;


namespace RazorPagesMovie.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {

            using (var context = new RazorPagesMovieContext(
                serviceProvider.GetRequiredService<DbContextOptions<RazorPagesMovieContext>>()))
            {
                if (context == null || context.Movie == null) 
                {
                    throw new ArgumentNullException("Null RazorPagesMovieContext");
                }

                //looks for movies
                if (context.Movie.Any()) 
                {
                    return; 
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "Toyota",
                        ReleaseDate = DateTime.Parse("2007-1-1"),
                        Genre = "Tacoma",
                        Price = 7.99M,
                        Rating = "TRDOR"
                    },

                    new Movie
                    {
                        Title = "Nissan",
                        ReleaseDate = DateTime.Parse("2013-1-1"),
                        Genre = "370Z",
                        Price = 8.99M,
                        Rating = "Sport"
                    },

                    new Movie
                    {
                        Title = "Honda",
                        ReleaseDate = DateTime.Parse("2003-1-1"),
                        Genre = "Civic",
                        Price = 9.99M,
                        Rating = "DX"
                    },

                    new Movie
                    {
                        Title = "Volvo",
                        ReleaseDate = DateTime.Parse("2007-1-1"),
                        Genre = "S60",
                        Price = 3.99M,
                        Rating = "R"
                    }



                    );
                    context.SaveChanges();
            }
                
        }








    }
}
