using StarwarsTheme.Application.Characters;
using StarwarsTheme.Domain.Characters;
using System.Collections.Generic;

namespace StarwarsTheme.Infrastructure.Characters
{

    public class InMemoryCharacterRepository : ICharacterRepository
    {
        private readonly CharacterCollection cache;
        public InMemoryCharacterRepository()
        {
            var list = new List<Character> { new Character("Luck", "Blue") };
            cache = new CharacterCollection(list);
        }
        public CharacterCollection GetAll()
        {
            return cache;
        }
    }
}
