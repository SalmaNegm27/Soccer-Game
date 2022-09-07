namespace Teams.Entities
{
    using Players.Entities;

    public class Club :TeamEntity
    {
      

        public List<Player> Players { get; set; }

    }
}
