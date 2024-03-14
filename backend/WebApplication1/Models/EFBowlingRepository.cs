using WebApplication1.Models;

public class BowlerRepository : IBowlerRepository
{
    private readonly BowlingLeagueContext _context;

    public BowlerRepository(BowlingLeagueContext context)
    {
        _context = context;
    }
    // function joining the tables together
    public IEnumerable<BowlerTeam> GetBowlerTeams()
    {
        var bowlerTeams = from bowler in _context.Bowlers
                          join team in _context.Teams on bowler.TeamId equals team.TeamId
                          select new BowlerTeam
                          {
                              BowlerId = bowler.BowlerId,
                              BowlerFirstName = bowler.BowlerFirstName,
                              BowlerMiddleInit = bowler.BowlerMiddleInit,
                              BowlerLastName = bowler.BowlerLastName,
                              BowlerAddress = bowler.BowlerAddress,
                              BowlerCity = bowler.BowlerCity,
                              BowlerState = bowler.BowlerState,
                              BowlerZip = bowler.BowlerZip,
                              BowlerPhoneNumber = bowler.BowlerPhoneNumber,
                              TeamId = team.TeamId,
                              TeamName = team.TeamName
                          };

        return bowlerTeams.ToList();
    }

}
