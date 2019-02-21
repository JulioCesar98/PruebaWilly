using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ProductoEjmplo.Models.ProductoViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ProductoEjmplo.Models
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json");

            var configuration = builder.Build();
            optionsBuilder.UseMySql(configuration["ConnectionStrings:DefaultConnection"]);


        }

        public DbSet<Producto> Productos { get; set; }
        
            
    }
}
