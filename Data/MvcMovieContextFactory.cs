
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Infrastructure;
//using MvcMovie.Models;

//namespace MyProject
//{
//    public class MvcMovieContextFactory : IDbContextFactory<MvcMovieContext>
//    {
//        public MvcMovieContext Create()
//        {
//            var optionsBuilder = new DbContextOptionsBuilder<MvcMovieContext>();
//            optionsBuilder.UseSqlite("Data Source=blog.db");

//            return new MvcMovieContext(optionsBuilder.Options);
//        }
//    }
//}