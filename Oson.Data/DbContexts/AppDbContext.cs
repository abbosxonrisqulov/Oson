using Microsoft.EntityFrameworkCore;
using Oson.Domain.Entities;

namespace Oson.Data.DbContexts;

public class AppDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string path = "Host=localhost;Port=5432;User Id=postgres;Database=OsonDb;Password=1234";
        optionsBuilder.UseNpgsql(path);
    }

    public DbSet<Customer> Customers { get; set; }
    public DbSet<Account> Accounts { get; set; }
    public DbSet<AccountType> AccountTypes { get; set; }
    public DbSet<Currency> Currencies { get; set; }
    public DbSet<Transfer> Transfers { get; set; }
    public DbSet<Transaction> Transactions { get; set; }
    public DbSet<TransactionType> TransactionTypes { get; set; }
    public DbSet<Card> Cards { get; set; }
    public DbSet<CardTransaction> CardTransactions { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}   
