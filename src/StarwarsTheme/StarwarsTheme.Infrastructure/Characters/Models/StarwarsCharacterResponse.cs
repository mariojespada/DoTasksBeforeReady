using Newtonsoft.Json;
using System.Collections.Generic;

namespace StarwarsTheme.Infrastructure.Characters.Models
{
    public class StarwarsCharacterResponse
    {
        [JsonProperty("results")]
        public List<StarwarsCharacter> Results { get; set; }
    }
}
