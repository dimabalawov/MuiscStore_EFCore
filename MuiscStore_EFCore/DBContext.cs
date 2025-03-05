using Microsoft.EntityFrameworkCore;
using MuiscStore_EFCore.Models;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace MuiscStore_EFCore
{
    public class MusicStoreContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Record> Records { get; set; }
        public DbSet<Promotion> Promotions { get; set; }
        public DbSet<Regular> Regulars { get; set; }
        public DbSet<DailyBest> DailyBests { get; set; }
        public DbSet<WeeklyBest>  WeeklyBests { get; set; }
        public DbSet<MonthlyBest> MonthlyBests { get; set; }
        public DbSet<YearlyBest> YearlyBests { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=MusicStore;Integrated Security=true;TrustServerCertificate=true");
        }
    }
}
