using BlogAPI.Models;
using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Asn1.Mozilla;

namespace UserAPI.Models
{
    public class BlogDBContext : DbContext
    {
        public BlogDBContext() { }

        public BlogDBContext(DbContextOptions opitions) : base(opitions)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string conn = "server=localhost; database=users; user=root; password=";

                optionsBuilder.UseMySQL(conn);
            }
        }

        public DbSet<User> NewUsers { get; set; } = null!;
    }
}