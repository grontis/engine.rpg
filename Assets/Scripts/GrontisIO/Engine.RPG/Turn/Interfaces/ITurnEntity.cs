using GrontisIO.Engine.RPG.Characters;

namespace GrontisIO.Engine.RPG.Turn.Interfaces
{
    public interface ITurnEntity
    {
        public ICharacter Character { get; set; }
    }
}
