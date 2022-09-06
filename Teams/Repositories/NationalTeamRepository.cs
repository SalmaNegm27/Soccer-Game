namespace Teams.Repositories
{
 

    public class NationalTeamRepository : BaseRepositpry<NationalTeam>, INationlTeamRepository
    {
        public NationalTeamRepository(DbContext context) : base(context)
        {
        }
    }
}
