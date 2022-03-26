using Microsoft.EntityFrameworkCore;
using OEOCommon.Entities;

namespace OEOAdmin.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<AppUser> Users { get; set; }
    }
}
