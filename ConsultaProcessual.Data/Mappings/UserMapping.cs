using ConsultaProcessual.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CompleteApi.Data.Mappings
{
    public class UserMapping : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Username).IsRequired();
            builder.Property(c => c.Password).IsRequired();
            builder.Property(c => c.Active).IsRequired();
            builder.Property(c => c.DateRegister).IsRequired();
        }
    }
}
