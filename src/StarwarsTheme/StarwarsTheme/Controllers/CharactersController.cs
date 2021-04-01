using Microsoft.AspNetCore.Mvc;
using StarwarsTheme.Application.Characters;
using System.Collections.Generic;

namespace StarwarsTheme.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharactersController : ControllerBase
    {
        private readonly ICharacterService characterService;

        public CharactersController(ICharacterService characterService)
        {
            this.characterService = characterService;
        }
        [HttpGet]
        public IEnumerable<CharacterDTO> List()
        {
            return characterService.GetAll();
        }
    }
}
