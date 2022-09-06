namespace Players.Controllers
{
    using ECommerce.Application;

    [Route("api/[controller]")]
    [ApiController]
    public class CoachesController : BaseController<Coach,CoachViewModel>

    {
        public CoachesController(ICoachUnitOfWork coachUnitOfWork, IMapper mapper, IValidator<CoachViewModel> validator) : base(coachUnitOfWork, mapper, validator)
        {
        }
    }
}
