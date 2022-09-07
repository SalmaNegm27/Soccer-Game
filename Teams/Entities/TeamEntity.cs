namespace Teams.Entities
{
  
    public abstract class TeamEntity : BaseEntity
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public DateTime FoundationDate { get; set; }
        public string Logo { get; set; }

        public Coach Coach { get; set; }
    }
}
