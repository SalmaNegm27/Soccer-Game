namespace Players.Entities.EntityConfiguration
{
   

    public class PlayerConfiguration :BaseEntityConfiguration<Player>
    {
        public override void Configure(EntityTypeBuilder<Player> builder)
        {
            builder.ToTable("Players");
            builder.HasKey(p=> p.Id);
            builder.Property(p => p.Name).IsRequired().HasMaxLength(20);
            builder.Property(p=>p.Nationality).IsRequired().HasMaxLength(20);
           
         
        }
    }
}
