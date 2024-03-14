namespace WebApplication1.Models
{
    public interface IBowlerRepository
    {
        IEnumerable<BowlerTeam> GetBowlerTeams();
    }
}
