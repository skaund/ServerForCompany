using AppDiplomVasilenkoTepaykim.Models;
using Microsoft.EntityFrameworkCore;

namespace AppDiplomVasilenkoTepaykim.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options)
          : base(options) { 

        }
        public DbSet<Category> Categorys { get; set; }


        public DbSet<Customer> Customers { get; set; }

        public DbSet<LocationCompany> LocationCompanys { get; set; }

        public DbSet<LocationDelivery> LocationDeliverys { get; set; }

        public DbSet<Order> Order { get; set; }

        public DbSet<OrderDetails> OrderDetails { get; set; }

        public DbSet<Product> Product { get; set; }


        public DbSet<RequisitesCompany> RequisitesCompanys { get; set; }

        public DbSet<RequisitesClient> RequisitesCompany { get; set; }

        public DbSet<Staff> Staffs { get; set; }

        public DbSet<Supplier> Suppliers { get; set; }

        public DbSet<Unit> Units { get; set; }
    }


}
