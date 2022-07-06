using GrontisIO.Engine.RPG.Dialogue;
using GrontisIO.Engine.RPG.Dialogue.Interfaces;
using GrontisIO.Engine.RPG.Events;
using GrontisIO.Engine.RPG.UI.Interfaces;
using UnityEngine;

namespace GrontisIO.Engine.RPG.Demo
{
    public class DemoDialogueTrigger : MonoBehaviour, IDialogueTrigger, IButton
    {
        public string characterName;
        public string[] sentences;

        public void OnClick()
        {
             TriggerDialogue(new DialogueDto {characterName = characterName, sentences = sentences});
        }

        public void TriggerDialogue(DialogueDto dialogue)
        {
            EventManager.Instance.DialogueTriggered(dialogue);
        }
    }
}
