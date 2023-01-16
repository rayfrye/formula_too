using FT.Data.Team;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace FT.Data.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TeamController : Controller
    {
        private readonly ILogger<TeamController> log;
        private readonly ITeamData teamData;

        public TeamController(ILogger<TeamController> _log, ITeamData _teamData)
        {
            log = _log;
            teamData = _teamData;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpPost(Name = "PostNewTeam")]
        public async Task<IActionResult> Post()
        {
            log.LogInformation("New Team Request Received");

            var newTeam = await teamData.CreateNewTeam();

            return Ok(newTeam.Team.Name);
        }
    }
}
