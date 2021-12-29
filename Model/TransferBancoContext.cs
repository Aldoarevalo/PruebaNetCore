using Microsoft.EntityFrameworkCore;
using PruebaNetCore.Model;

namespace PruebaNetCore.Models
{
    public class TransferBancoContext : DbContext
    {
        public TransferBancoContext(DbContextOptions<TransferBancoContext> options)
            : base(options)
        {
        }

        public DbSet<TransferBanco> Books { get; set; }
    }
}