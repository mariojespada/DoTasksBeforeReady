using StarwarsTheme.Domain;
using StarwarsTheme.Domain.Characters;
using System.Threading;
using System.Threading.Tasks;

namespace StarwarsTheme.Application.Characters
{
    public interface ICharacterRepository
    {
        LastUpdated LastUpdated { get; }
        Task UpdateRepositoryAsync(CancellationToken cancellationToken);
        CharacterCollection GetAll();
    }
}
