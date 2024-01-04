using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace User.Models
{
    public class UserDbContext : DbContext 
    {
        public UserDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Users> User { get; set; } = null!;
        public DbSet<BankAccounts> BankAccount { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string conn = "server=192.168.30.15; database=User; user=root; password=password";

                optionsBuilder.UseMySql(conn, ServerVersion.AutoDetect(conn));
            }
        }

    }
}
