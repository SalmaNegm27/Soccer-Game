namespace Players.ViewModels
{
  
   
    public class PlayerViewModel :BaseViewModel
    {
        public String Name { get; set; }
        public String Nationality { get; set; }
        public DateTime BirthDate { get; set; }
        public string Image { get; set; }
        public Guid ClubId { get; set; }
        public Guid? NationalTeamId { get; set; }
    }
}
