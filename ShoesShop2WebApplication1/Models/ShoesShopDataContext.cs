using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ShoesShop2WebApplication1.Models
{
    public partial class ShoesShopDataContext : DbContext
    {
        public ShoesShopDataContext()
            : base("name=ShoesShopDataContext")
        {
        }
        DbSet <ElegantShoes> elegantShoes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
