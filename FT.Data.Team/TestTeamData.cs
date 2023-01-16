using FT.Objects;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FT.Data.Team
{
    public  class TestTeamData : ITeamData
    {
        private readonly ILogger log;
        public TestTeamData(ILogger<TestTeamData> _log)
        {
            log = _log;
        }

        public async Task<TeamResponse> CreateNewTeam()
        {
            log.LogInformation("Received new team creation request");

            TeamResponse response = new TeamResponse()
            {
                @Team = new Objects.Team()
                {
                    Name = "H2WOAH WHAT A GOOD TEAM"
                }
                , Response = new HttpResponseMessage()
                {
                    StatusCode = System.Net.HttpStatusCode.Accepted
                }
            };

            return response;
        }
    }
}
