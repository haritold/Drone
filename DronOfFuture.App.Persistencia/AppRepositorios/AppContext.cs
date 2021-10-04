using Microsoft.EntityFrameworkCore;
using DronOfFuture.App.Dominio;

namespace DronOfFuture.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Clientes> Clientes{get;set;}
        public DbSet<Empresa> Empresa{get;set;}
        public DbSet<Encargados> Encargado{get;set;}
        public DbSet<Estados> Estados{get;set;}
        public DbSet<Pedidos> Pedidos{get;set;}  
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data source = (localdb)\\MSSQLLocalDB; Initial Catalog = DronOfFutureData;");
            }
        }

    }
}