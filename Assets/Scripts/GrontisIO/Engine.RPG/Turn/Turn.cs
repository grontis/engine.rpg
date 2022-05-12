using GrontisIO.Engine.RPG.Turn.Interfaces;

namespace GrontisIO.Engine.RPG.Turn
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
