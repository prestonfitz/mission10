using WebApplication1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BowlingLeagueController : ControllerBase
    {
        private IBowlingRepository _bowlingRepository { get; set; }
        public BowlingLeagueController(IBowlingRepository temp)
        {
            _bowlingRepository = temp;
        }

        [HttpGet]
        public IEnumerable<Bowler> Get()
        {
            var bowlingData = _bowlingRepository.Bowlers.ToArray();

            return bowlingData;
        }
    }
}
