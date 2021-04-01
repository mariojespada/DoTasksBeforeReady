using AutoMapper;
using StarwarsTheme.Application.Characters;
using StarwarsTheme.Domain.Characters;
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
    }
}
