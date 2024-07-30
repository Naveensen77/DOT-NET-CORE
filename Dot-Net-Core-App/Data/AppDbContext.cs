using Dot_Net_Core_App.Models;
using Microsoft.EntityFrameworkCore;

namespace Dot_Net_Core_App.Data
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Product> Product {  get; set; }
    }
}
