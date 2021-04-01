using System.Collections.Generic;
using System.Linq;

namespace StarwarsTheme.Domain.Characters
{
    public class CharacterCollection
    {
        private readonly Dictionary<string, Character> characterDictionary = new Dictionary<string, Character>();
        public Character this[string id]
        {
            get => characterDictionary[id];
        }
        public CharacterCollection(IEnumerable<Character> characters)
        {
            characterDictionary = characters.ToDictionary(k => k.Name, v => v);
        }
        public IEnumerable<Character> AsEnumerable() =>
            characterDictionary.Values;
    }
}
