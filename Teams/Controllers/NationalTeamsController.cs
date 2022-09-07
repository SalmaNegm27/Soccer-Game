namespace Teams.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Soccer_Game.Jwtauthentication;

    [Route("api/[controller]")]
    [ApiController]
    public class NationalTeamsController : BaseController<NationalTeam, NationalTeamViewModel>

    {
        public NationalTeamsController(INationalTeamUnitOfWork nationalTeamUnitOfWork, IMapper mapper, IValidator<NationalTeamViewModel> validator) : base(nationalTeamUnitOfWork, mapper, validator)
        {
        }
        [Authorize(Roles = UserRoles.User)]
        [HttpGet]
        public override async Task<IActionResult> GetAll()
        {
            return await base.GetAll();

        }

        [Authorize(Roles = UserRoles.User)]
        [HttpGet("{id}")]
        public override async Task<IActionResult> Get(Guid id)
        {
            return await base.Get(id);

        }

        [Authorize(Roles = UserRoles.Admin)]
        [HttpPost]
        public override async Task<IActionResult> Post(NationalTeamViewModel nationalTeamViewModel)
        {
            return await base.Post(nationalTeamViewModel);
        }

        [Authorize(Roles = UserRoles.Admin)]
        [HttpPut]
        public override async Task<IActionResult> Put(NationalTeamViewModel nationalTeamViewModel)
        {
            return await base.Put(nationalTeamViewModel);
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
