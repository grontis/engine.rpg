using GrontisIO.RPG.Interfaces;
using UnityEngine;

namespace GrontisIO.RPG.Dialogue
{
    public class DialogueTrigger : MonoBehaviour, IEventTrigger<DialogueDTO>
    {
        public void Trigger(DialogueDTO data)
        {
            //TODO event to start dialogue UI
        }
    }
}