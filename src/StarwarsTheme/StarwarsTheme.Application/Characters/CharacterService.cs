using System.Collections.Generic;
using System.Linq;

namespace StarwarsTheme.Application.Characters
{
    public class CharacterService : ICharacterService
    {
        private readonly ICharacterRepository repository;
        private readonly ICharacterMappingService mappingService;

        public CharacterService(
            ICharacterRepository repository, 
            ICharacterMappingService mappingService)
        {
            this.repository = repository;
            this.mappingService = mappingService;
        }
        public List<CharacterDTO> GetAll()
        {
            var collection = repository.GetAll();
            return collection.AsEnumerable().Select(ch=>new CharacterDTO 
            { 
                Name = ch.Name,
                EyeColor = ch.EyeColor
            }).ToList();
        }
    }
}
