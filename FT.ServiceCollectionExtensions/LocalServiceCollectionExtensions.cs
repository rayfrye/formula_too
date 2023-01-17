using FT.Data.Team;
using FT.Objects;
using Microsoft.Extensions.DependencyInjection;

namespace FT.ServiceCollectionExtensions
{
    public static class LocalServiceCollectionExtensions
    {
        public static IServiceCollection AddAllLocalServices(this IServiceCollection services, AppSettings config)
        {
            services.AddITeamData(config);

            return services;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="services">The <see cref="IServiceCollection"/>.</param>
        /// <param name="config">The <see cref="IConfiguration"/>.</param>
        static IServiceCollection AddITeamData(this IServiceCollection services, AppSettings config)
        {
            switch (config.ServiceProviders.DataTeam)
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
