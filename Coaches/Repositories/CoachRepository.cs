namespace Coaches.Repositories
{
    

    public class CoachRepository : BaseRepositpry<Coach>, ICoachRepository
    {
        public CoachRepository(DbContext context) : base(context)
        {
        }
    }
}
