using FT.Data.Team;

namespace FT.Data
{
    public static class LocalServiceCollectionExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="services">The <see cref="IServiceCollection"/>.</param>
        /// <param name="config">The <see cref="IConfiguration"/>.</param>
        public static IServiceCollection AddITeamData(this IServiceCollection services, IConfiguration config)
        {
            switch (config.GetValue<string>("ServiceProviders:Data.Team"))
            {
                case ("TestTeamData"):
                    {
                        return services.AddSingleton<ITeamData, TestTeamData>();
                        break;
                    }
                default:
                    {
                        return services.AddSingleton<ITeamData, TestTeamData>();
                        break;
                    }
            }
        }
    }
}
