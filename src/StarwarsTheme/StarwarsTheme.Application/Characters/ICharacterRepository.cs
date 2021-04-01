using StarwarsTheme.Domain.Characters;

namespace StarwarsTheme.Application.Characters
{
    public interface ICharacterRepository
    {
        CharacterCollection GetAll();
    }
}
