using EntityFrameworkExample.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EntityFrameworkExample.Data
{
    public class PizzaContext : DbContext
    {
        public DbSet<Customer> Customers {  get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet <OrderDetail> OrderDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-TDK64FE;Persist Security Info=False;Database=foodorder;Trusted_Connection=True;TrustServerCertificate=True;Connection Timeout=600;");


        }

    }
}
