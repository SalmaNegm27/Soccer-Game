namespace Teams.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class ClubsController : BaseController<Club,ClubViewModel>

    {
        public ClubsController(IClubUnitOfWork clubUnitOfWork, IMapper mapper, IValidator<ClubViewModel> validator) : base(clubUnitOfWork, mapper, validator)
        {
        }
    }
}
