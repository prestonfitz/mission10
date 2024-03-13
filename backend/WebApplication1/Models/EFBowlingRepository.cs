namespace WebApplication1.Models
{
    public class EFBowlingRepository : IBowlingRepository
    {
        // create the variable
        private BowlingLeagueContext _context;
        // Set up the repo
        public EFBowlingRepository(BowlingLeagueContext temp)
        {
            _context = temp;
        }

        public IEnumerable<Bowler> Bowlers => _context.Bowlers;
    }
}
