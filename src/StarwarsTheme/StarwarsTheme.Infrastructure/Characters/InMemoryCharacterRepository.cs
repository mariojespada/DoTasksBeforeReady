using AutoMapper;
using StarwarsTheme.Application.Characters;
using StarwarsTheme.Domain;
using StarwarsTheme.Domain.Characters;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace StarwarsTheme.Infrastructure.Characters
{

    public class InMemoryCharacterRepository : ICharacterRepository
    {
        public LastUpdated LastUpdated { get; private set; } = LastUpdated.Never;

        private CharacterCollection cache;
        private readonly IStarwarsCharactersGateway gateway;
        private readonly IMapper mapper;

        public InMemoryCharacterRepository(
            IStarwarsCharactersGateway gateway,
            IMapper mapper)
        {
            this.gateway = gateway;
            this.mapper = mapper;
            var list = new List<Character> { new Character("Luck", "Blue") };
            cache = new CharacterCollection(list);
        }

        

        public CharacterCollection GetAll()
        {
            return cache;
        }

        public async Task UpdateRepositoryAsync(CancellationToken cancellationToken)
        {
            var response = await gateway.GetAll(cancellationToken);
            var list = response.Results.Select(swCh => mapper.Map<Character>(swCh));
            cache = new CharacterCollection(list);
        }

    }
}
