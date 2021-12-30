using Microsoft.EntityFrameworkCore;
using PhoneBook.Domain.Services.Phone;

namespace PhoneBook.Infra.Data
{
    public static class BaseMap
    {
        public static ModelBuilder CreateMap(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PhoneEntity>()
               .HasOne(x => x.Contact)
               .WithMany(x => x.Phones)
               .HasForeignKey(x => x.IdContact);
            return modelBuilder;
        }
    }
}
