using GrontisIO.Engine.RPG.Events;
using GrontisIO.Engine.RPG.Turn.Interfaces;
using GrontisIO.Engine.RPG.UI.Interfaces;
using UnityEngine;

namespace GrontisIO.Engine.RPG.Demo
{
    public class DemoEndTurnBtn : MonoBehaviour, IButton, IEndTurnTrigger
    {
        public void OnClick()
        {
            EndTurn();
        }

        public void EndTurn()
        {
            EventManager.Instance.TurnEnded();
        }
    }
}
