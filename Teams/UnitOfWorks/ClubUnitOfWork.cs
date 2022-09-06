namespace Teams.UnitOfWorks
{
    

    public class ClubUnitOfWork : BaseUnitOfWork<Club>, IClubUnitOfWork
    {
        public ClubUnitOfWork(IClubRepository clubRepository) : base(clubRepository)
        {
        }
    }
}
