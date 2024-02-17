using Microsoft.EntityFrameworkCore;

namespace Mission06_Chew.Models
{
    public class MovieApplicationContext : DbContext
    {
        public MovieApplicationContext(DbContextOptions<MovieApplicationContext> options) : base (options) 
        {
        }

        public DbSet<Application> Application { get; set; }
    }
}
