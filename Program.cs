using Microsoft.EntityFrameworkCore;

namespace CarDatabaseCodefirst
{
    public class CarRentalContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=CarRental;Trusted_Connection=True;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Creating the Cars table
            modelBuilder.Entity<Car>()
                .Property(c => c.Id )
                .HasColumnName("CarId");

            modelBuilder.Entity<Car>()
                .HasKey(c => c.Id);

            modelBuilder.Entity<Car>()
                .Property(c => c.Name)
                .HasColumnType("nvarchar(100)")
                .IsRequired();

            modelBuilder.Entity<Car>()
                .Property(c => c.Brand)
                .HasColumnType("nvarchar(50)")
                .IsRequired();

            modelBuilder.Entity<Car>()
                .Property(c => c.ModelYear)
                .HasColumnType("date")
                .IsRequired();

            modelBuilder.Entity<Car>()
                .Property(c => c.Color)
                .HasColumnType("nvarchar(50)")
                .IsRequired();

            modelBuilder.Entity<Car>()
                .Property(c => c.Category)
                .HasColumnType("nvarchar(20)")
                .IsRequired();

            modelBuilder.Entity<Car>()
                .Property(c => c.SeatCount)
                .HasColumnType("int")
                .IsRequired();

            modelBuilder.Entity<Car>()
                .Property(c => c.PricePerDay)
                .HasColumnType("int")
                .IsRequired();

            modelBuilder.Entity<Car>()
                .Property(c => c.Images)
                .HasColumnType("nvarchar(200)")
                .IsRequired();

            modelBuilder.Entity<Car>()
                .Property(c => c.IsAutomatic)
                .HasDefaultValue(false)
                .IsRequired()
                .HasColumnType("bit");

            modelBuilder.Entity<Car>()
                .Property(c => c.HasAirCondition)
                .HasDefaultValue(true)
                .IsRequired()
                .HasColumnType("bit");

            // Creating the Users table
            modelBuilder.Entity<User>()
                .Property(u => u.Ssn)
                .HasColumnName("Ssn");
            modelBuilder.Entity<User>()
                .HasKey(u => u.Ssn);

            modelBuilder.Entity<User>()
                .Property(u => u.Name)
                .HasColumnType("nvarchar(100)")
                .IsRequired();

            modelBuilder.Entity<User>()
                .Property(u => u.Password)
                .HasColumnType("nvarchar(500)")
                .IsRequired();

            modelBuilder.Entity<User>()
                .Property(u => u.Email)
                .HasColumnType("nvarchar(150)")
                .IsRequired()
                .HasConversion(
                    v => v.ToLower(),
                    v => v);

            modelBuilder.Entity<User>()
                .HasIndex(u => u.Email)
                .IsUnique();

            modelBuilder.Entity<User>()
                .Property(u => u.PhoneNumber)
                .HasColumnType("nvarchar(20)")
                .IsRequired();

            modelBuilder.Entity<User>()
                .HasIndex(u => u.PhoneNumber)
                .IsUnique();

            modelBuilder.Entity<User>()
                .Property(u => u.Address)
                .HasColumnType("nvarchar(200)")
                .IsRequired();

            modelBuilder.Entity<User>()
                .Property(u => u.Image)
                .HasColumnType("nvarchar(200)")
                .IsRequired();

            modelBuilder.Entity<User>()
                .Property(u => u.IsAdmin)
                .HasDefaultValue(false)
                .HasColumnType("bit");

            // Creating the FavoriteCars table
            modelBuilder.Entity<FavoriteCars>()
                .HasKey(fc => new { fc.Ssn, fc.CarId });

            modelBuilder.Entity<FavoriteCars>()
                .Property(fc => fc.Ssn)
                .HasColumnName("UserSsn");

            //modelBuilder.Entity<FavoriteCars>()
            //    .HasOne(fc => fc.User)
            //    .WithMany(u => u.Cars)
            //    .HasForeignKey(u => u.Ssn);

            //modelBuilder.Entity<FavoriteCars>()
            //    .

        }

    }
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
