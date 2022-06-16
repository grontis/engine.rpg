using System;
using GrontisIO.Engine.RPG.Events;
using GrontisIO.Engine.RPG.Events.Interfaces;
using GrontisIO.Engine.RPG.Turn;
using UnityEngine;

namespace GrontisIO.Engine.RPG.UI.Turn
{
    public class TurnUIManager : MonoBehaviour, IEventSubscriber
    {
        public TurnOrderPanel turnOrderPanel;
        
        private TurnOrder _turnOrder;
        
        void Start()
        {
            SubscribeEvents();
        }

        void Update()
        {
        }

        private void OnDestroy()
        {
            UnsubscribeEvents();
        }

        public void SubscribeEvents()
        {
            EventManager.Instance.OnTurnEnded += OnTurnEnded;
        }

        public void UnsubscribeEvents()
        {
            EventManager.Instance.OnTurnEnded -= OnTurnEnded;
        }

        private void OnTurnEnded()
        {
            _turnOrder.Iterate();
        }
    }
}
