using Microsoft.EntityFrameworkCore;
using Practice_Project___ASP.NET_Core_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice_Project___ASP.NET_Core_MVC.Data
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext(DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; }
    }
}
/*In Entity Framework terminology, an entity set typically corresponds to a database table. An entity corresponds to a row in the table.*/
