namespace Players.Repositories
{
 

    public class PlayerRepository : BaseRepositpry<Player>, IPlayerRepository
    {
        public PlayerRepository(DbContext context) : base(context)
        {
        }
    }
}
