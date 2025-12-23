using Microsoft.EntityFrameworkCore;
using WebApp_building.DAL.Entities;

namespace WebApp_building.DAL.Context
{
    public class DataBaseContext: DbContext
    {
      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=192.168.11.127;Database=WebApp_buildingDB;User Id=sa;Password=q1w2e3!!!;TrustServerCertificate=True;");
        }

        public DbSet<Feature> Features { get; set; }
        public DbSet<Hakkimizda> Hakkimizdas { get; set; }
        public DbSet<Hizmetler> Hizmetlers { get; set; }
        public DbSet<NedenBiz> NedenBizs { get; set; }
        public DbSet<Referanslar> Referanslars { get; set; }
        public DbSet<Ask> Asks { get; set; }
        public DbSet<Login> Logins { get; set; }


    }
}
