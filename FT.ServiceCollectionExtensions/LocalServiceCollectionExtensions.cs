using FT.Data.Team;
using FT.DataOps;
using FT.Objects;
using Microsoft.Extensions.DependencyInjection;

namespace FT.ServiceCollectionExtensions
{
    public static class LocalServiceCollectionExtensions
    {
        public static IServiceCollection AddAllLocalServices(this IServiceCollection services, AppSettings config)
        {
            services
                .AddITeamData(config)
                .AddIDataOps(config)
            ;

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
                case ("Test"):
                    {
                        return services.AddSingleton<ITeamData, TestTeamData>();
                        break;
                    }
                case ("RealTeamData"):
                    {
                        return services.AddSingleton<ITeamData, RealTeamData>();
                        break;
                    }
                default:
                    {
                        return services.AddSingleton<ITeamData, TestTeamData>();
                        break;
                    }
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="services">The <see cref="IServiceCollection"/>.</param>
        /// <param name="config">The <see cref="IConfiguration"/>.</param>
        static IServiceCollection AddIDataOps(this IServiceCollection services, AppSettings config)
        {
            switch (config.ServiceProviders.DataTeam)
            {
                case ("Test"):
                    {
                        return services.AddSingleton<IDataOps, TestDataOps>();
                        break;
                    }
                default:
                    {
                        return services.AddSingleton<IDataOps, TestDataOps>();
                        break;
                    }
            }
        }

    }
}
