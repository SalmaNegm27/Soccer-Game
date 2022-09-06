namespace Teams.Repositories
{
 

    public class ClubRepository : BaseRepositpry<Club>, IClubRepository
    {
        public ClubRepository(DbContext context) : base(context)
        {
        }
    }
}
