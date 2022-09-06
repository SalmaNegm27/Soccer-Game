namespace Teams.UnitOfWorks
{
   

    public class NationalTeamUnitOfWork : BaseUnitOfWork<NationalTeam>, INationalTeamUnitOfWork
    {
        public NationalTeamUnitOfWork(INationlTeamRepository nationlTeamRepository) : base(nationlTeamRepository)
        {
        }
    }
}
