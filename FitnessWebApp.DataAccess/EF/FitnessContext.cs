using FitnessWebApp.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessWebApp.DataAccess.EF
{
    public class FitnessContext : DbContext
    {
        public DbSet<Exercise> Exercises => Set<Exercise>();
        public DbSet<Activity> Activities => Set<Activity>();
        public DbSet<Gender> Genders => Set<Gender>();
        public DbSet<User> Users => Set<User>();
        public DbSet<Vitamin> Vitamins => Set<Vitamin>();
        public DbSet<Food> Foods => Set<Food>();
        public DbSet<Eating> Eatings => Set<Eating>();
        public DbSet<FoodEating> FoodEatings => Set<FoodEating>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=FitnessApp;Trusted_Connection=True;MultipleActiveResultSets=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Food>()
                .HasMany(f => f.Eatings)
                .WithMany(e => e.Foods)
                .UsingEntity<FoodEating>(
                u => u
                .HasOne(fe => fe.Eating)
                .WithMany(e => e.FoodEatings)
                .HasForeignKey(fe => fe.EatingId),
                u => u
                .HasOne(fe => fe.Food)
                .WithMany(f => f.FoodEatings)
                .HasForeignKey(fe => fe.FoodId),
                u =>
                {
                    u.HasKey(k => new { k.EatingId, k.FoodId });
                    u.ToTable(nameof(FoodEating));
                });
        }
    }
}