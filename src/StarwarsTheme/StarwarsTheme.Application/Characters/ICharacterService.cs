using System.Collections.Generic;

namespace StarwarsTheme.Application.Characters
{
    public interface ICharacterService
    {
        List<CharacterDTO> GetAll();
    }
}