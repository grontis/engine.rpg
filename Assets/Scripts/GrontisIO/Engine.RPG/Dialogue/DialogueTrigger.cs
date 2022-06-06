using GrontisIO.Engine.RPG.Events.Interfaces;
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