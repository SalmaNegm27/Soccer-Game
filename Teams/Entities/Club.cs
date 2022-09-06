namespace Teams.Entities
{
    using Players.Entities;

    public class Club :BaseEntity
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public DateTime FoundationDate { get; set; }
        public string Logo { get; set; }

        public Coach Coach { get; set; }

        public List<Player> Players { get; set; }

    }
}
