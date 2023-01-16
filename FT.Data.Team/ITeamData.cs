using FT.Objects;

namespace FT.Data.Team
{
    public interface ITeamData
    {
        public Task<TeamResponse> CreateNewTeam();
    }
}