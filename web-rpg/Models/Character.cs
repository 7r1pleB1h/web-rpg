namespace web_rpg.Models;

public class Character
{
    public int Id { get; set; }
    public string Name { get; set; } = "Frodo";
    public int HitPoints { get; set; } = 100;
    public int Strenght { get; set; } = 10;
    public int Intelligence { get; set; } = 10;
    public CharacterTypes CharacterType { get; set; } = CharacterTypes.Knight;
}
