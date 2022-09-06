namespace Teams.ViewModels
{
    

    public class ClubViewModel :BaseViewModel
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public DateTime FoundationDate { get; set; }
        public string Logo { get; set; }
        public List<Player> Players { get; set; }
    }
}

