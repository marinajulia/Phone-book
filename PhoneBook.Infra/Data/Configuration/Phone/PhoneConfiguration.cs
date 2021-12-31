using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PhoneBook.Domain.Services.Phone;

namespace PhoneBook.Infra.Data.Configuration.Phone
{
    public class PhoneConfiguration : IEntityTypeConfiguration<PhoneEntity>
    {
        public void Configure(EntityTypeBuilder<PhoneEntity> builder)
        {
            builder.ToTable("Phone");
            builder.HasKey(p => p.Id);
        }
    }
}