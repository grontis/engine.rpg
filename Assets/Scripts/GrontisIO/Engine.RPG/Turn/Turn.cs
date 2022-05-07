using GrontisIO.engine.RPG.Turn.Interfaces;

namespace GrontisIO.engine.RPG.Turn
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
