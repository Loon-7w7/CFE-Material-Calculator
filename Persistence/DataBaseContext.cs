using Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace Persistence
{
    public class DataBaseContext : DbContext
    {
        private readonly string _connectionString;

        public DbSet<Device> devices { get; set; }
        public DbSet<Material> materials { get; set; }
        public DbSet<Consultation> consultations { get; set; }

        public DataBaseContext (DbContextOptions<DataBaseContext> options ): base (options)
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("", ServerVersion.AutoDetect(_connectionString));
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Device>();
            modelBuilder.Entity<Material>();
            modelBuilder.Entity<Consultation>();
        }


        }
    }
