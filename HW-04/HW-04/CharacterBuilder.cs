public class CharacterBuilder
{
    private Character _character = new();

    public CharacterBuilder SetStrength(int value) { _character.Strength = value; return this; }
    public CharacterBuilder SetAgility(int value) { _character.Agility = value; return this; }
    public CharacterBuilder SetIntelligence(int value) { _character.Intelligence = value; return this; }

    public Character Build() => _character;
}
