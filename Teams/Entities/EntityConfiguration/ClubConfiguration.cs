namespace Teams.Entities.EntityConfiguration
{
    public class ClubConfiguration :BaseEntityConfiguration<Club>
    {
        public override void Configure(EntityTypeBuilder<Club> builder)
        {
            builder.ToTable("Clubs");
            builder.HasKey(cl => cl.Id);
            builder.Property(cl => cl.Name).IsRequired();
            builder.Property(cl => cl.Country).IsRequired();
            builder.HasMany(c => c.Players).WithOne().HasForeignKey(c => c.ClubId);

        }
    }
}
