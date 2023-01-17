using FT.Data.Team;
using FT.Objects;
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
        private readonly AppSettings appSettings;

        public TeamController(ILogger<TeamController> _log, ITeamData _teamData, AppSettings _appSettings)
        {
            log = _log;
            teamData = _teamData;
            appSettings = _appSettings;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpPost(Name = "PostNewTeam")]
        public async Task<IActionResult> Post()
        {
            log.LogInformation("New Team Request Received");

            return Ok(newTeam.Team.Name);
        }
    }
}
