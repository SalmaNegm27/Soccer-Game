namespace Coaches.ViewModels
{
    
    public class DomainProfile : Profile
    {

        public DomainProfile()
        {

            CreateMap<Coach,CoachViewModel>().ReverseMap();
        }

    }
}
