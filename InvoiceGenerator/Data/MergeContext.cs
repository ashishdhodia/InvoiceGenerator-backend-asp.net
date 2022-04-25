using InvoiceGenerator.Models;
using Microsoft.EntityFrameworkCore;

namespace InvoiceGenerator.Data
{
    public class MergeContext : DbContext
    {
        public MergeContext(DbContextOptions<MergeContext> options) : base(options)
        {
        }

        public DbSet<Business>? Businesses { get; set; }
        public DbSet<Client>? Clients { get; set; }
        public DbSet<Invoice>? Invoices { get; set; }
        public DbSet<Fee>? Fees { get; set; }
        public DbSet<ItemList>? ItemLists { get; set; }

    }
}
