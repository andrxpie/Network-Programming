using Microsoft.EntityFrameworkCore;

namespace Car_license_plate__CLP__DB
{
    public class CLP : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CLP;Integrated Security=True;Connect Timeout=30");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new CarsCfgs());
            modelBuilder.ApplyConfiguration(new BrandsCfgs());
            modelBuilder.ApplyConfiguration(new ColorsCfgs());
            modelBuilder.ApplyConfiguration(new CountriesCfgs());
            modelBuilder.ApplyConfiguration(new DrivesCfgs());
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Drive> Drives { get; set; }
    }
}