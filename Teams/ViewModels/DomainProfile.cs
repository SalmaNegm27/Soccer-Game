namespace Teams.ViewModels
{
  
    public class DomainProfile :Profile
    {
        public DomainProfile()
        {
            CreateMap<Club, ClubViewModel>().ReverseMap();
            CreateMap<NationalTeam, NationalTeamViewModel>().ReverseMap();
        }
    }
}
