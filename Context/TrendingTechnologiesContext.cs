using Microsoft.EntityFrameworkCore;
using ms_studentTendency.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ms_studentTendency.Context
{
    public class TrendingTechnologiesContext : DbContext
    {
        public TrendingTechnologiesContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Technology> Technologies { get; set; }
        public DbSet<UserResponse> UserResponses { get; set; }
        


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<Category>().ToTable("Category");
            modelBuilder.Entity<Technology>().ToTable("Technology");
            modelBuilder.Entity<UserResponse>().ToTable("UserResponse");
           


            modelBuilder.Entity<Category>()
                .HasMany<Technology>(s => s.Technologies)
                .WithMany(c => c.Categories)
                .UsingEntity(join => join.ToTable("TechnologyCategory"));

            modelBuilder.Entity<User>()
                .HasIndex(u => u.userEmail)
                .IsUnique();


        }
    }
}
