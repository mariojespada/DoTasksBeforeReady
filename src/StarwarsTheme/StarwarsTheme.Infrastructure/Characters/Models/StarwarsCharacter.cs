using Newtonsoft.Json;

namespace StarwarsTheme.Infrastructure.Characters.Models
{
    public class StarwarsCharacter
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("eye_color")]
        public string EyeColor { get; set; }
    }
}
