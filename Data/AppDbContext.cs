using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Cars55.Models;
using Microsoft.EntityFrameworkCore;
using System.IO;

namespace Cars55.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Klient> Klients { get; set; }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Sale> Sales { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // сохраняем совместимость с существующей SQLite-базой,
            // где колонки были созданы по английским именам свойств.
            modelBuilder.Entity<Car>().Property(car => car.Марка).HasColumnName("Brand");
            modelBuilder.Entity<Car>().Property(car => car.Модель).HasColumnName("Model");
            modelBuilder.Entity<Car>().Property(car => car.Год).HasColumnName("Year");
            modelBuilder.Entity<Car>().Property(car => car.Цена).HasColumnName("Price");
            modelBuilder.Entity<Car>().Property(car => car.Цвет).HasColumnName("Color");
            modelBuilder.Entity<Car>().Property(car => car.Пробег).HasColumnName("Mileage");
            modelBuilder.Entity<Car>().Property(car => car.Статус).HasColumnName("Status");

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string databasePath = Path.Combine(AppContext.BaseDirectory, "autosalon.db"); // в этом поле пишется файл чтобы база может храниться не в этой папке, она гулял
            optionsBuilder.UseSqlite($"Data Source={databasePath}"); // для entity framework
        }
    }
}
