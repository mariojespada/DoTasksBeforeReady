using StarwarsTheme.Domain.Characters;
using System.Collections.Generic;

namespace StarwarsTheme.Application.Characters
{
    public interface ICharacterMappingService
    {
        List<CharacterDTO> ToCharacterDTO(CharacterCollection characterCollection);
    }
}
