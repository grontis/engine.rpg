using GrontisIO.Engine.RPG.UI.Turn;
using TMPro;
using UnityEngine;

namespace GrontisIO.Demo
{
    public class DemoTurnOrderPanel : TurnOrderPanel
    {
        public TextMeshProUGUI characters;
        
        void Start()
        {
        
        }

        void Update()
        {
        
        }

        public override void NextTurn()
        {
            //TODO how to connect the TurnOrder data with this component?
            //Contains a member reference?
            //Event based
        }
    }
}
