namespace Teams.Controllers
{
  
    [Route("api/[controller]")]
    [ApiController]
    public class NationalTeamsController : BaseController<NationalTeam, NationalTeamViewModel>

    {
        public NationalTeamsController(INationalTeamUnitOfWork nationalTeamUnitOfWork, IMapper mapper, IValidator<NationalTeamViewModel> validator) : base(nationalTeamUnitOfWork, mapper, validator)
        {
        }
    }
}
