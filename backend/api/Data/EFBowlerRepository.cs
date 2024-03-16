using Microsoft.EntityFrameworkCore;
namespace api.Data
{
    public class EFBowlerRepository : IBowlerRepository
    {
        private BowlerContext _bowlerContext;
        
        public EFBowlerRepository(BowlerContext temp)
        {
            _bowlerContext = temp;
        }

        public IEnumerable<Bowler> Bowlers => _bowlerContext.Bowlers.Include(x => x.Team);

        public IEnumerable<Team> Teams => _bowlerContext.Teams;

    }
}
