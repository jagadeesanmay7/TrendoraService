using Microsoft.EntityFrameworkCore;
using Trendora.Domain.Models;

namespace Trendora.Infrastructure.DbContexts
{
    public class TrendoraDbContext : DbContext
    {
        public TrendoraDbContext(DbContextOptions<TrendoraDbContext> options) : base(options)
        {

        }
        public DbSet<Category> Category { get; set; }
    }
}
