namespace Coaches.Entities.EntityConfiguration
{
   

    public class CoachConfiguration :BaseEntityConfiguration<Coach>
    {
        public override void Configure(EntityTypeBuilder<Coach> builder)
        {
            builder.ToTable("Coaches");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.FirstName).IsRequired().HasMaxLength(10);
            builder.Property(c => c.LastName).IsRequired().HasMaxLength(10);
            builder.Property(c => c.PhoneNumber).IsRequired().HasMaxLength(11);
        }
    }
}
