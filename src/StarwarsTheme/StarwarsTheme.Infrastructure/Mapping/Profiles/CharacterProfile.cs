using AutoMapper;
using StarwarsTheme.Application.Characters;
using StarwarsTheme.Domain.Characters;

namespace StarwarsTheme.Infrastructure.Mapping.Profiles
{
    public class CharacterProfile:Profile
    {
        public CharacterProfile()
        {
            CreateMap<Character, CharacterDTO>();
        }
        
    }
}
