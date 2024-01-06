namespace AlgoWorld
{
    public enum Race
    {
        Human,
        Elf,
        Dwarf,
        Drow,
        Gnome,
        Halfling,
        HalfElf,
        HalfTroll,
        Giant,
        Firbolg
    }

    public class Character
    {
        private string _name;
        private Race _race;
        private int _level;
        public Character(string name, Race race, int level)
        {
            this._name = name;
            this._race = race;
            this._level = level;
        }

        public string GetName()
        {
            return this._name;
        }

        public string GetRace()
        {
            return this._race.ToString();
        }

        public int GetLevel()
        {
            return this._level;
        }
    }
}