using GrontisIO.Engine.RPG.Events;
using GrontisIO.Engine.RPG.Events.Interfaces;
using GrontisIO.Engine.RPG.Turn;
using GrontisIO.Engine.RPG.UI.Turn;
using TMPro;

namespace GrontisIO.Engine.RPG.Demo
{
    public class DemoTurnOrderPanel : TurnOrderPanel, IEventSubscriber
    {
        public TextMeshProUGUI characters;
        private TurnOrder _turnOrder;

        private void Start()
        {
            SubscribeEvents();
        }

        private void Update()
        {
        
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

        public override void NextTurn()
        {
            _turnOrder.Iterate();
        }
    }
}
