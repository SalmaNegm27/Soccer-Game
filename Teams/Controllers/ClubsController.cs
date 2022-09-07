namespace Teams.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Soccer_Game.Jwtauthentication;

    [Route("api/[controller]")]
    [ApiController]
    public class ClubsController : BaseController<Club,ClubViewModel>

    {
        public ClubsController(IClubUnitOfWork clubUnitOfWork, IMapper mapper, IValidator<ClubViewModel> validator) : base(clubUnitOfWork, mapper, validator)
        {
        }
        [Authorize(Roles = UserRoles.User)]
        [HttpGet]
        public override async Task<IActionResult> GetAll()
        {
            await base.GetAll();
            return Ok();
        }

        [Authorize(Roles = UserRoles.User)]
        [HttpGet("{id}")]
        public override async Task<IActionResult> Get(Guid id)
        {
            await base.Get(id);
            return Ok();
        }

        [Authorize(Roles = UserRoles.Admin)]
        [HttpPost]
        public override async Task<IActionResult> Post(ClubViewModel clubViewModel)
        {
            await base.Post(clubViewModel);
            return Ok(clubViewModel);
        }

        [Authorize(Roles = UserRoles.Admin)]
        [HttpPut]
        public override async Task<IActionResult> Put(ClubViewModel clubViewModel)
        {
            await base.Put(clubViewModel);
            return Ok(clubViewModel);
        }
        [Authorize(Roles = UserRoles.Admin)]
        [HttpDelete]
        public override async Task<ActionResult> Delete(Guid id)
        {
            await base.Delete(id);
            return Ok();
        }
    }
}
