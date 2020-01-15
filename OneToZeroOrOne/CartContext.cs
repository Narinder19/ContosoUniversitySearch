using OneToZeroOrOne.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToZeroOrOne
{
    public class CartContext : DbContext
    {
        public CartContext(): base("Connection1") 
        {
                
        }

        public DbSet<Cart> Students { get; set; }
        public DbSet<CartPrecinct> StudentAddresses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
