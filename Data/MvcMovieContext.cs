using Microsoft.EntityFrameworkCore;

namespace MvcMovie.Models
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext (DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
        }

        //public MvcMovieContext()
        //{
        //}

        public DbSet<MvcMovie.Models.Movie> Movie { get; set; }
    }
}
