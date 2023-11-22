using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class MyContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<MyDownloadBooster> MyDownloadBoosters { get; set; }
        //public MyContext()
        //{
        //    Database.EnsureDeleted();
        //    Database.EnsureCreated();
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=C;Initial Catalog=Database_Pbl4;Integrated Security=True;Trust Server Certificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(new User
            {
                UserId = 1,
                Email = "ruivalien@gmail.com",
                FullName = "Test Nguyen",
                Password = "1a9561f87a0ab36db53b21ba81f5c015298111c1240ebf16a4c00945b65c5f1a", //123456Pass
            });
        }
    }
}
