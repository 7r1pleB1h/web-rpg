namespace web_rpg.Services.CharacterServices;

public class CharacterService : ICharacterService
{

    private static List<Character> characters = new List<Character>
    {
        new Character(),
        new Character {Id = 1, Name = "Sam" }
    };

    public async Task<List<Character>> AddCharacter(Character character)
    {
        characters.Add(character);
        return characters;
    }

    public async Task<List<Character>> GetAllCharacters()
    {
        return characters;
    }

    public async Task<Character> GetCharacterById(int id)
    {
        var character = characters.FirstOrDefault(c => c.Id == id);

        if (character is not null) {
            return character;
        }
        else
        {
            throw new Exception("Character not found.");
        }
    }
}
