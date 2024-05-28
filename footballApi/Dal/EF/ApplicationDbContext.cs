using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Dal.EF
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<RestaurantDal> Restaurants{ get; set; }
        public DbSet<CategoryDal> Categories { get; set; }
        public DbSet<DishItemDal> DishItems { get; set; }
        public DbSet<MenuDal> Menus { get; set; }
        public DbSet<PhotoDal> Photos { get; set; }
        public DbSet<UserDal> Users { get; set; }
        public DbSet<RoleDal> Roles { get; set; }
        public DbSet<BookingDal> Bookings { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookingDal>()
                .HasOne(e => e.Restaurant)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict); // <--

            modelBuilder.Entity<BookingDal>()
                .HasOne(e => e.User)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
