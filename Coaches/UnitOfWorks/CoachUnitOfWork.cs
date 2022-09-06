namespace Coaches.UnitOfWorks
{


    public class CoachUnitOfWork : BaseUnitOfWork<Coach>, ICoachUnitOfWork
    {
        public CoachUnitOfWork(ICoachRepository  coachRepository) : base(coachRepository)
        {
        }
    }
}
