using Microsoft.EntityFrameworkCore;

namespace Task_XML
{
    internal class ApplicationContext : DbContext
    {

        public DbSet<Customer> Customer { get; set; } = null!;

        public DbSet<Product> Product { get; set; } = null!;

        public DbSet<Purchase> Purchase { get; set; } = null!;

        public DbSet<ProdInPurchase> Prod_In_Purchase { get; set; } = null!;


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(@"Server=(DESKTOP-23D4Q7F)\mssqllocaldb;Database=shop;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProdInPurchase>()
                .HasKey(p => new { p.Purchase_id, p.Product_id });
        }
    }
}


