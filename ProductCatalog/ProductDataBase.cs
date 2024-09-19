using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProductCatalog
{
    internal class ProductDataBase : DbContext
    {
        internal DbSet<Product> products { get; set; }
        internal DbSet<User> users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = C:\\Users\\sakir\\source\\repos\\ProductCatalog\\ProductCatalog\\ProductDataBase.db");
        }
    }
}
