using Microsoft.Extensions.DependencyInjection;

namespace StarwarsTheme.PriorToReadyTasks
{
    public static class PriorToReadyTasksExtensions
    {
        public static IServiceCollection AddPriorToReadyTasks(this IServiceCollection serviceCollection) 
        {
            serviceCollection.AddTransient<IStartupTask>(sp => new InMemoryRepositoriesDataFetchingTask(sp));
            return serviceCollection;
      }
    }
}
