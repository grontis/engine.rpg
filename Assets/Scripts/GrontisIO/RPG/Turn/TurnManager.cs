using System;
using System.Collections.Generic;
using GrontisIO.RPG.Turn.Interfaces;

namespace GrontisIO.RPG.Turn
{
    public class TurnManager
    {
        private Turn _currentTurn;
        
        public readonly TurnOrder Order;
        public Turn CurrentTurn => _currentTurn;

        public TurnManager(List<ITurnEntity> entities)
        {
            Order = new TurnOrder(entities);
        }

        public void StartTurnSession()
        {
            _currentTurn = new Turn(Order.CurrentElement);
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
