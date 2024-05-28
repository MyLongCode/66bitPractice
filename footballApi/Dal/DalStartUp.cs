using Dal.Footballer;
using Dal.Footballer.Interfaces;
using Dal.Team;
using Dal.Team.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Dal
{
    public static class DalStartUp
    {
        public static IServiceCollection TryAddDal(this IServiceCollection serviceCollection)
        {
            serviceCollection.TryAddScoped<IFootballerRepository, FootballerRepository>();
            serviceCollection.TryAddScoped<ITeamRepository, TeamRepository>();

            return serviceCollection;
        }
    }
}
