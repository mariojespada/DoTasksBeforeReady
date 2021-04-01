using StarwarsTheme.Infrastructure.Characters.Models;
using System.Threading;
using System.Threading.Tasks;

namespace StarwarsTheme.Infrastructure.Characters
{
    public interface IStarwarsCharactersGateway
    {
        Task<StarwarsCharacterResponse> GetAll(CancellationToken cancellationToken);
    }
}