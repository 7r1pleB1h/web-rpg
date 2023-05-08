using Microsoft.AspNetCore.Mvc;
using web_rpg.Services.CharacterServices;

namespace web_rpg.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CharacterController: ControllerBase
{
    private static List<Character> characters = new List<Character>
    {
        new Character(),
        new Character {Id = 1, Name = "Sam" }
    };

    private readonly ICharacterService _characterService;

    public CharacterController(ICharacterService characterService)
    {
        this._characterService = characterService;
    }

    [HttpGet("GetAll")]
    public async Task<ActionResult<List<Character>>> Get()
    {
        return Ok(await _characterService.GetAllCharacters());
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Character>> GetSingle(int id)
    {
        return Ok(await _characterService.GetCharacterById(id));
    }

    [HttpPost]
    public async Task<ActionResult<Character>> AddCharacter(Character character) {
        return Ok(await _characterService.AddCharacter(character));
    }
}