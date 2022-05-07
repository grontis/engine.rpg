using GrontisIO.RPG.Turn.Interfaces;

namespace GrontisIO.RPG.Turn
{
    public class Turn
    {
        public ITurnEntity Entity { get; set; }

        public Turn(ITurnEntity entity)
        {
            Entity = entity;
        }
    }
}
