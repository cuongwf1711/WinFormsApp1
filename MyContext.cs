using Microsoft.EntityFrameworkCore;

namespace WinFormsApp1
{
    public class MyContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<MyDownloadBooster> MyDownloadBoosters { get; set; }
        public MyContext()
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=C;Initial Catalog=Database_Pbl4;Integrated Security=True;Trust Server Certificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(new User
            {
                UserId = 1,
                Email = "admine123@gmail.com",
                FullName = "Test Nguyen",
                Password = StaticFunc.ComputeSha256Hash("123456Pass")
            });
        }
    }
}
