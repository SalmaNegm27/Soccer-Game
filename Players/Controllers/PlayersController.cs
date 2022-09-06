namespace Players.Controllers
{
 
    [Route("api/[controller]")]
    [ApiController]
    public class PlayersController : BaseController<Player, PlayerViewModel>

    {
        public PlayersController(IPlayerUnitOfWork playerUnitOfWork, IMapper mapper, IValidator<PlayerViewModel> validator) : base(playerUnitOfWork, mapper, validator)
        {
        }
    }
}
