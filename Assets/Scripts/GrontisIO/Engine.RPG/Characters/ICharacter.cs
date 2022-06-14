using System.Collections.Generic;
using GrontisIO.Engine.RPG.Characters.Abilities;
using GrontisIO.Engine.RPG.Characters.Storage;

namespace GrontisIO.Engine.RPG.Characters
{
    public interface ICharacter
    {
        Details Details { get; set; }
        Stats Stats { get; set; }
        Inventory Inventory { get; set; }
        List<IAbility> Abilities { get; set; }
    }
}
