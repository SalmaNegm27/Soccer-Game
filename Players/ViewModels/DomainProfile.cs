namespace Players.ViewModels
{


    public class DomainProfile : Profile
    {

        public DomainProfile()
        {

            CreateMap<Player, PlayerViewModel>().ReverseMap();
        }

    }
}
