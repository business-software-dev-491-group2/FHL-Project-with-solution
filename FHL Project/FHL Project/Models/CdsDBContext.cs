using Microsoft.EntityFrameworkCore;

namespace FHLProject.Models
{
    public class CDsDBContext : DbContext
    {
        public DbSet<CDs> CDs { get; set; }
        public CDsDBContext(DbContextOptions<CDsDBContext> options) : base(options)
        { }

    }
}