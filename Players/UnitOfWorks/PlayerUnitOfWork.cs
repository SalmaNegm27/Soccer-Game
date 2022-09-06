namespace Players.UnitOfWorks
{
    

    public class PlayerUnitOfWork : BaseUnitOfWork<Player>, IPlayerUnitOfWork
    {
        public PlayerUnitOfWork(IPlayerRepository playerRepository) : base(playerRepository)
        {
        }
    }
}
