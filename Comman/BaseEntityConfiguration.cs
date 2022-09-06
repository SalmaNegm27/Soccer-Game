namespace ECommerce.Application
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class BaseEntityConfiguration<T> : IEntityTypeConfiguration<T> where T : BaseEntity
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasKey(x => x.Id);
          
            builder.Property(e => e.CreationData).HasDefaultValueSql("GETDATE()");
            builder.Property(e => e.ConcurrencyStamp).IsRowVersion();
         }
    }
}
