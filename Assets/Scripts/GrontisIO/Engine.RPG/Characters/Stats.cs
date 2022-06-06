namespace GrontisIO.Engine.RPG.Characters
{
    public abstract class Stats
    {
        //TODO how to create an extensible Stats class that doesnt lock into specific stat names?

        public int Strength;
        public int Dexterity;
        public int Constitution;
        public int Intelligence;
        public int Wisdom;
        public int Charisma;

        public abstract void LevelUp();
    }
}
