using System;
using System.Collections.Generic;
using GrontisIO.engine.RPG.Turn.Interfaces;

namespace GrontisIO.engine.RPG.Turn
{
    public class TurnManager
    {
        private engine.RPG.Turn.Turn _currentTurn;
        
        public readonly TurnOrder Order;
        public engine.RPG.Turn.Turn CurrentTurn => _currentTurn;

        public TurnManager(List<ITurnEntity> entities)
        {
            Order = new TurnOrder(entities);
        }

        public void StartTurnSession()
        {
            _currentTurn = new engine.RPG.Turn.Turn(Order.CurrentElement);
        }

        public void NextTurn()
        {
            Order.Iterate();
            _currentTurn.Entity = Order.CurrentElement;
        }

        public void AddEntity(ITurnEntity entity)
        {
            throw new NotImplementedException();
        }        
        
        public void RemoveEntity(ITurnEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
