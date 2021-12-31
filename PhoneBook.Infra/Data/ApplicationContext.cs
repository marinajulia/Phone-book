using Microsoft.EntityFrameworkCore;
using PhoneBook.Domain.Services.Contact;
using PhoneBook.Domain.Services.Phone;

namespace PhoneBook.Infra.Data
{
    public class ApplicationContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-SN81A5J\SQLEXPRESS;Initial Catalog=PhoneBook;Integrated Security=True");
        }

        public DbSet<PhoneEntity> Phone { get; set; }
        public DbSet<ContactEntity> Contact { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.CreateMap();
            base.OnModelCreating(modelBuilder);
        }
    }
}