using Microsoft.EntityFrameworkCore;

namespace BankTransaction.Models
{
    public class TransactionDbContext : DbContext
    {
        public TransactionDbContext(DbContextOptions<TransactionDbContext> options) : base()
        {

        }
        public DbSet<Transaction> Transactions { get; set; }
    }
}
