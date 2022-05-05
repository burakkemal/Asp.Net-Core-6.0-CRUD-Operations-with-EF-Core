using Microsoft.EntityFrameworkCore;

namespace BankTransaction.Models
{
    public class TransactionDbContext : DbContext
    {
        public TransactionDbContext(DbContextOptions<TransactionDbContext> options) : base()
        {

        }
        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
    => options.UseNpgsql("User ID=postgres;Password=12345;Server=localhost;Port=5432;Database=myDataBase;Pooling=true;");
    }
}
