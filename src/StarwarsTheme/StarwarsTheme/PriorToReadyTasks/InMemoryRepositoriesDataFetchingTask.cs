using Microsoft.Extensions.DependencyInjection;
using Microsoft.FeatureManagement;
using StarwarsTheme.Application.Characters;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace StarwarsTheme.PriorToReadyTasks
{
    public class InMemoryRepositoriesDataFetchingTask : IStartupTask
    {
        private readonly IServiceProvider serviceProvider;

        public InMemoryRepositoriesDataFetchingTask(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }
        public async Task ExecuteAsync(CancellationToken cancellationToken = default)
        {
            var featureManager = serviceProvider.GetRequiredService<IFeatureManager>();
            if (await featureManager.IsEnabledAsync("PriorToReadyDataFetchingFeature"))
            {
                var repo = serviceProvider.GetRequiredService<ICharacterRepository>();
                await repo.UpdateRepositoryAsync(cancellationToken);
            }
            
        }
    }
}
