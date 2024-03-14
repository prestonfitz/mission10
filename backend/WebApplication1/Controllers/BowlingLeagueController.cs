using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using System.Linq;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BowlingLeagueController : ControllerBase
    {
        private readonly IBowlerRepository _bowlerRepository;

        public BowlingLeagueController(IBowlerRepository bowlerRepository)
        {
            _bowlerRepository = bowlerRepository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<BowlerTeam>> GetBowlerTeams()
        {
            var bowlerTeams = _bowlerRepository.GetBowlerTeams();
            return Ok(bowlerTeams);
        }

    }
}
