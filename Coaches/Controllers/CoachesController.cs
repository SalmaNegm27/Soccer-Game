namespace Players.Controllers
{
    using Coaches.ViewModels;
    using ECommerce.Application;
    using Microsoft.AspNetCore.Authorization;

    [Route("api/[controller]")]
    [ApiController]
    public class CoachesController : BaseController<Coach, CoachViewModel>

    {
        public CoachesController(ICoachUnitOfWork coachUnitOfWork, IMapper mapper, IValidator<CoachViewModel> validator) : base(coachUnitOfWork, mapper, validator)
        {
        }


    }
}
