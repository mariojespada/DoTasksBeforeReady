using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using StarwarsTheme.Infrastructure.Characters.Models;
using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace StarwarsTheme.Infrastructure.Characters
{
    public class StarwarsCharactersGateway : IStarwarsCharactersGateway
    {
        private readonly HttpClient httpClient;
        private readonly StarwarsCharactersSettings settings;

        public StarwarsCharactersGateway(HttpClient httpClient, IOptions<StarwarsCharactersSettings> options)
        {
            settings = options.Value;
            this.httpClient = httpClient;
            this.httpClient.BaseAddress = new Uri(settings.BaseAddress);
        }
        public async Task<StarwarsCharacterResponse> GetAll(CancellationToken cancellationToken)
        {
            var response = await httpClient.GetAsync(settings.CharactersEndpoint, cancellationToken);
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<StarwarsCharacterResponse>(json);
        }
    }
}
