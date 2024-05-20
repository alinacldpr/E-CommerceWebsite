using Microsoft.EntityFrameworkCore;
using TechTrove.DAL.Entities;

namespace TechTrove.DAL
{
    public class TechTroveContext : DbContext
    {
        public TechTroveContext(DbContextOptions<TechTroveContext> options) : base(options)
        {

        }

        public DbSet<TechTroveUser> TechTroveUsers { get; set; }
        public DbSet<TechTroveOrder> TechTroveOrders { get; set; }
        public DbSet<TechTroveCart> TechTroveCarts { get; set; }
        public DbSet<TechTroveCartItem> TechTroveCartItems { get; set; }
        public DbSet<TechTroveProduct> TechTroveProducts { get; set; }
        public DbSet<TechTroveCategory> TechTroveCategories { get; set; }
    }
}
