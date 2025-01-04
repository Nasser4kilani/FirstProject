using FirstProject.Library_System.Data.Config;
using FirstProject.Library_System.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.Library_System.Data
{
    public class AppDBContext : DbContext
    {
        public DbSet<Book> ?Book { get; set; }
        public DbSet<Order> ?Orders { get; set; }
        public DbSet<OrderDetails> ?OrdersDetails { get; set; }
        public DbSet<Customer> ?Customer { get; set; }
        
    }
}
