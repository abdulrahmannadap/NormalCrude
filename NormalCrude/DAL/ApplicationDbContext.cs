using Microsoft.EntityFrameworkCore;
using NormalCrude.Models;

namespace NormalCrude.DAL
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Membarship> Membarships { get; set; }
        public DbSet<BaseModel> baseModels { get; set; }
    }
}
