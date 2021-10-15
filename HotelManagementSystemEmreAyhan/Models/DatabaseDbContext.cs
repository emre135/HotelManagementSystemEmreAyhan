using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Design;

namespace HotelManagementSystemEmreAyhan.Models
{
    class DatabaseDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Room> Rooms { get; set; }

        public DbSet<Booking> Bookings { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\LocalDbEmre;Integrated Security=true;;
            Database=HotelManagementDb;Trusted_Connection=True;");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    RoomId = 1,
                    RoomName = "Plaza Hotel Single Bed",
                    Size = "Small",
                    Price = 700,
                    Rating = 3.5
                },

                new Room
                {
                    RoomId = 2,
                    RoomName = "Titanic Resort Suite",
                    Size = "Large",
                    Price = 3400,
                    Rating = 5
                },

                new Room
                {
                    RoomId = 3,
                    RoomName = "Ringen Double Bed",
                    Size = "Medium",
                    Price = 1100,
                    Rating = 4
                }

            );
        }



    }
}
