using GrontisIO.Engine.RPG.Events.Interfaces;
using GrontisIO.Engine.RPG.Interfaces;
using UnityEngine;

namespace GrontisIO.Engine.RPG.Dialogue
{
    public class DialogueTrigger : MonoBehaviour, IEventTrigger<DialogueDTO>
    {
        public void Trigger(DialogueDTO data)
        {
            //TODO event to start dialogue UI
        }
    }
}