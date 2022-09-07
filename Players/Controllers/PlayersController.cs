namespace Players.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Soccer_Game.Jwtauthentication;

    [Route("api/[controller]")]
    [ApiController]
    public class PlayersController : BaseController<Player, PlayerViewModel> 

    {
        public PlayersController(IPlayerUnitOfWork playerUnitOfWork, IMapper mapper, IValidator<PlayerViewModel> validator) : base(playerUnitOfWork, mapper, validator)
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
        public override async Task<IActionResult> Post(PlayerViewModel playerViewModel)
        {
            return await base.Post(playerViewModel);
        }

        [Authorize(Roles = UserRoles.Admin)]
        [HttpPut]
        public override async Task<IActionResult> Put(PlayerViewModel playerViewModel)
        {
            return await base.Put(playerViewModel);
        }
            [Authorize(Roles = UserRoles.Admin)]
        [HttpDelete]
        public override async Task<ActionResult> Delete(Guid id)
        {
            await base.Delete(id);
            return Ok  ();
        }
    }


}

