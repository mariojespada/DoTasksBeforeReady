namespace StarwarsTheme.Domain.Characters
{
    public record Character
    {
        public string Name { get; }
        public string EyeColor { get; }
        public Character(string name, string eyeColor) => (Name, EyeColor) = (name, eyeColor);
    }
}
