using Microsoft.EntityFrameworkCore;
using EFWinFormsTest.Models;

namespace EFWinFormsTest.Data
{
    public class CustomContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; } = null!;
        public DbSet<Phone> Phones { get; set; } = null!;
        public DbSet<Product> Products { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "EFWinFormsTest.db");
            optionsBuilder.UseSqlite($"Data Source={dbPath};");
        }
    }
}
