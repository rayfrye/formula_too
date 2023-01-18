﻿using FT.Objects;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FT.Data.Team
{
    public  class RealTeamData : ITeamData
    {
        private readonly ILogger log;
        public RealTeamData(ILogger<TestTeamData> _log)
        {
            log = _log;
        }

        public async Task<TeamResponse> CreateNewTeam()
        {
            log.LogInformation("REAL TEAM - Received new team creation request");

            TeamResponse response = new TeamResponse()
            {
                @Team = new Objects.Team()
                {
                    Name = "Definitely not ferrari"
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
