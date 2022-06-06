using System.Collections.Generic;

namespace GrontisIO.Engine.RPG.Characters
{
    public abstract class Stats
    {
        public abstract Stat GetStat(string name);
        public abstract void LevelUp();
    }
}
