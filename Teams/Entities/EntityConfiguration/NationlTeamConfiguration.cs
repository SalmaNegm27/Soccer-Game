namespace Teams.Entities.EntityConfiguration
{
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class NationlTeamConfiguration :BaseEntityConfiguration<NationalTeam>
    {
        public override void Configure(EntityTypeBuilder<NationalTeam> builder)
        {
            builder.ToTable("nationalteams");
            builder.HasKey(n => n.Id);
            builder.Property(n => n.Name).IsRequired();
            builder.Property(n=> n.Country).IsRequired();
            builder.HasMany(n => n.Players).WithOne().HasForeignKey(n => n.NationalTeamId);
        }
    }
}
