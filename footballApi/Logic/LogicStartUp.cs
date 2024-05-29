
using Logic.Footballer;
using Logic.Footballer.Interfaces;
using Logic.Team;
using Logic.Team.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;


namespace Logic
{
    public static class LogicStartUp
    {
        public static IServiceCollection TryAddLogic(this IServiceCollection serviceCollection)
        {
            serviceCollection.TryAddScoped<IFootballerLogicManager, FootballerLogicManager>();
            serviceCollection.TryAddScoped<ITeamLogicManager, TeamLogicManager>();


            return serviceCollection;
        }
    }
}
