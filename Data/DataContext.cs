using AonAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace AonAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
               
        }
        public DbSet<StocksUSAColumnar> StocksUSAColumnar { get; set; }
       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {       
            modelBuilder.Entity<StocksUSAColumnar>(entity =>
            {
                entity.ToTable("StocksUSAColumnar");   
                
            });
            base.OnModelCreating(modelBuilder);
        }
    }   

}
