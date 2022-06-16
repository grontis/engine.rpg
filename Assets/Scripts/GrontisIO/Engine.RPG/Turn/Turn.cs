using GrontisIO.Engine.RPG.Characters;
using GrontisIO.Engine.RPG.Turn.Interfaces;

namespace GrontisIO.Engine.RPG.Turn
{
    public class Turn
    {
        public ICharacter Character { get; set; }

        public Turn(ICharacter character)
        {
            Character = character;
        }
    }
}
