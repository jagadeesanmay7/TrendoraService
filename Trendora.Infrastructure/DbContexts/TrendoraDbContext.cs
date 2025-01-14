﻿using Microsoft.EntityFrameworkCore;
using Trendora.Domain.Models;

namespace Trendora.Infrastructure
{
    public class TrendoraDbContext : DbContext
    {
        public TrendoraDbContext(DbContextOptions<TrendoraDbContext> options) : base(options)
        {

        }
        public DbSet<Catagory> Catagory { get; set; }
        public DbSet<Brand> Brand { get; set; }
    }
}
