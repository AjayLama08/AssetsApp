using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetsApp.Data
{
    public class AssetsDbContext: DbContext
    {
        public string DbPath { get; }
        public AssetsDbContext()
        {
            var folder = Environment.SpecialFolder.MyDocuments;
            var path = Environment.GetFolderPath(folder);
            DbPath = Path.Join(path, "assets.db");
        }

        public DbSet<Asset> Assets => Set<Asset>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite($"Data Source = {DbPath}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Asset>().HasData(
                new Asset(1, "Office Chair", Location.NEW_YORK, DateTime.Parse("2020-05-21"), true, 120.50),
                new Asset(2, "Laptop Dell XPS", Location.LONDON, DateTime.Parse("2019-08-14"), true, 1500.00),
                new Asset(3, "Projector", Location.PARIS, DateTime.Parse("2021-03-10"), false, 650.00),
                new Asset(4, "Standing Desk", Location.NEW_YORK, DateTime.Parse("2021-11-05"), true, 450.75),
                new Asset(5, "Printer HP LaserJet", Location.LONDON, DateTime.Parse("2018-12-02"), true, 299.99),
                new Asset(6, "Desktop Monitor 24 inch", Location.KATHMANDU, DateTime.Parse("2020-06-15"), true, 220.00),
                new Asset(7, "Smart TV", Location.PARIS, DateTime.Parse("2020-02-19"), false, 800.00),
                new Asset(8, "Air Conditioner Unit", Location.LONDON, DateTime.Parse("2017-07-30"), true, 1200.00),
                new Asset(9, "Conference Table", Location.NEW_YORK, DateTime.Parse("2021-01-10"), true, 600.00),
                new Asset(10, "Ergonomic Mouse", Location.KATHMANDU, DateTime.Parse("2022-03-15"), true, 45.00),
                new Asset(11, "MacBook Pro", Location.LONDON, DateTime.Parse("2021-09-30"), true, 2400.00),
                new Asset(12, "Whiteboard", Location.PARIS, DateTime.Parse("2019-11-25"), false, 150.00),
                new Asset(13, "Server Rack", Location.KATHMANDU, DateTime.Parse("2020-10-20"), true, 5000.00),
                new Asset(14, "Desktop PC", Location.NEW_YORK, DateTime.Parse("2022-02-28"), true, 1200.00),
                new Asset(15, "3D Printer", Location.LONDON, DateTime.Parse("2021-05-17"), false, 3500.00),
                new Asset(16, "Sound System", Location.PARIS, DateTime.Parse("2018-08-13"), true, 900.00),
                new Asset(17, "Digital Camera", Location.KATHMANDU, DateTime.Parse("2021-04-08"), false, 1200.00),
                new Asset(18, "iPad Pro", Location.NEW_YORK, DateTime.Parse("2020-06-25"), true, 999.99),
                new Asset(19, "Network Switch", Location.PARIS, DateTime.Parse("2019-09-19"), true, 650.00),
                new Asset(20, "Coffee Machine", Location.LONDON, DateTime.Parse("2020-07-15"), true, 300.00)
                );
        }
    }
}
