using System;
using System.Collections.Generic;
using GrontisIO.Engine.RPG.Characters;
using GrontisIO.Engine.RPG.Turn.Interfaces;

namespace GrontisIO.Engine.RPG.Turn
{
    public class TurnManager
    {
        private Turn _currentTurn;
        
        public readonly TurnOrder Order;
        public Turn CurrentTurn => _currentTurn;

        public TurnManager(List<ICharacter> entities)
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
            _currentTurn.Character = Order.CurrentElement;
        }

        public void AddEntity(ICharacter entity)
        {
            throw new NotImplementedException();
        }        
        
        public void RemoveEntity(ICharacter entity)
        {
            throw new NotImplementedException();
        }
    }
}
