using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Letra.Models
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-RSDLUJ4; database=letra; integrated security=true; TrustServerCertificate=true;");
        }
        public DbSet<Admin> Admin { get; set; }
        public DbSet<Hakkimizda> Hakkimizda { get; set; }
        public DbSet<Oyunlarimiz> Oyunlarimiz { get; set; }
        public DbSet<Ekibimiz> Ekibimiz { get; set; }
        public DbSet<İletisim> İletisim { get; set; }
    }
}