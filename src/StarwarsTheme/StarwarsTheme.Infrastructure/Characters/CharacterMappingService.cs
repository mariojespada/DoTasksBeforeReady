using AutoMapper;
using StarwarsTheme.Application.Characters;
using StarwarsTheme.Domain.Characters;
using StarwarsTheme.Infrastructure.Characters.Models;
using System.Collections.Generic;
using System.Linq;

namespace StarwarsTheme.Infrastructure.Characters
{
    public class CharacterMappingService : ICharacterMappingService
    {
        private readonly IMapper mapper;

        public CharacterMappingService(IMapper mapper)
        {
            this.mapper = mapper;
        }
        public List<CharacterDTO> ToCharacterDTO(CharacterCollection characterCollection)
        {
            return characterCollection.AsEnumerable()
                .Select(ch => mapper.Map<CharacterDTO>(ch))
                .ToList();
        }
        public CharacterCollection ToCharaterCollection(StarwarsCharacterResponse characterResponse)
        {
            var charList = characterResponse.Results.Select(ch => new Character(ch.Name, ch.EyeColor));
            return new CharacterCollection(charList);
        }
    }
}
