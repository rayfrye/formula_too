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
        /// Creates a new Formula Too team
        /// </summary>
        /// <returns></returns>
        /// <param name="teamName"></param>
        /// <param name="description"></param>
        /// <param name="isManufacturer"></param>
        [ProducesResponseType(typeof(ITeamData), 200)]
        [ProducesResponseType(typeof(IActionResult), 400)]
        [ProducesResponseType(typeof(IActionResult), 404)]
        [HttpPost(Name = "PostNewTeam")]
        public async Task<IActionResult> Post(string teamName, string description, bool isManufacturer)
        {
            log.LogInformation($"New team request received, {teamName}");

            var newTeam = await teamData.CreateNewTeam();

            return Ok(newTeam.Team.Name);
        }
    }
}
