using crud_netcore.Models;
using Microsoft.EntityFrameworkCore;

namespace crud_netcore.Utils
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<UserModel> Users { get; set; }
    }
}