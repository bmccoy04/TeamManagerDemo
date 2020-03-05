using System;
using Microsoft.EntityFrameworkCore;
using TeamManagerDemo.Core.Entities;

namespace TeamManagerDemo.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Season>();
            modelBuilder.Entity<Team>();
            modelBuilder.Entity<Player>();
            modelBuilder.Entity<League>();
            modelBuilder.Entity<Sport>();
            modelBuilder.Entity<ContactInfo>();
            
            base.OnModelCreating(modelBuilder);
        } 
    }
}
