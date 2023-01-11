using CQRS_İstanbulEğitimAkademi.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace CQRS_İstanbulEğitimAkademi.DAL.Contextt
{
    public class ProductContext:DbContext
    {
        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
           optionsBuilder.UseSqlServer("server=MELEK;initial catalog=ZCQRSDb;integrated security=true");
        }
        public DbSet<Product> Products { get; set; }

    }
}
