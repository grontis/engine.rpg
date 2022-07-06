using System;
using System.Collections.Generic;
using GrontisIO.Engine.RPG.Characters;
using GrontisIO.Engine.RPG.Events;
using GrontisIO.Engine.RPG.Events.Interfaces;
using GrontisIO.Engine.RPG.Turn.Interfaces;
using UnityEngine;

namespace GrontisIO.Engine.RPG.Turn
{
    public class TurnManager : MonoBehaviour, IEventSubscriber
    {
        private Turn _currentTurn;
        private TurnOrder _turnOrder;
        public Turn CurrentTurn => _currentTurn;

        private void Start()
        {
            SubscribeEvents();
        }

        private void OnDestroy()
        {
            UnsubscribeEvents();
        }
        
        public void SubscribeEvents()
        {
            EventManager.Instance.OnTurnEnded += NextTurn;
        }

        public void UnsubscribeEvents()
        {
            EventManager.Instance.OnTurnEnded -= NextTurn;
        }

        public void InitializeNewTurnOrder(List<ICharacter> characters)
        {
            //TODO start turn order event to subscribe to
            _turnOrder = new TurnOrder(characters);
        }

        private void NextTurn()
        {
            _turnOrder.Iterate();
            _currentTurn = new Turn(_turnOrder.CurrentElement);
        }

        public void AddEntity(ICharacter character)
        {
            //TODO event for adding to turn order
            _turnOrder.Add(character);
        }        
        
        public void RemoveEntity(ICharacter character)
        {
            //TODO event for triggering removal from turn order
            _turnOrder.Remove(character);
        }
    }
}
