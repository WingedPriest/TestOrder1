using Microsoft.EntityFrameworkCore;
namespace TestOrder1.Models
{
    class DBContext : DbContext
    {
        public DBContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-BOBS0F0;Database=Users;Trusted_Connection=True;");//перенести строку подключения в конфиги
        }

        public DbSet<User> User { get; set; }
    }
}
