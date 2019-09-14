using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCity.Models
{
    class AppDbContext : DbContext
    {
        public AppDbContext() : base("DefaultConnection")
        {

        }
        public DbSet<Building> Buildings { get; set; }
        public DbSet<Government> Governments { get; set; }
        public DbSet<Hospitals> Hospitals { get; set; }
        public DbSet<Idea> Ideas { get; set; }
        public DbSet<Important> Importants { get; set; }
        public DbSet<Infrastructure> Infrastructures { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<PublicTransport> PublicTransports { get; set; }
        public DbSet<Road> Roads { get; set; }
        public DbSet<Security> Securities { get; set; }
        public DbSet<Trade_Advertising> Trade_Advertisings { get; set; }
        public DbSet<Yard> Yards { get; set; }
    }
}
