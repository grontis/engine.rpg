using System.Collections.Generic;
using GrontisIO.Engine.RPG.Characters.Abilities;

namespace GrontisIO.Engine.RPG.Characters
{
    using Storage;
    
    public abstract class Character
    {
        public Details Details;
        public Stats Stats;
        public Inventory Inventory;
        public List<IAbility> Abilities;
    }
}