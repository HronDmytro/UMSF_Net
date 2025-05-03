public class Character
{
    public int Strength { get; set; }
    public int Agility { get; set; }
    public int Intelligence { get; set; }

    public override string ToString() => $"STR: {Strength}, AGI: {Agility}, INT: {Intelligence}";
}
