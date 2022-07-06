using System;
using GrontisIO.Engine.RPG.Characters.Abilities;
using GrontisIO.Engine.RPG.Dialogue;
using UnityEngine;

namespace GrontisIO.Engine.RPG.Events
{
    //TODO refactor into separate EventManagers based on system (for example, UIEventManager, {System}EventManger, etc.
    public class EventManager : MonoBehaviour
    {
        public static EventManager Instance { get; private set; }
        
        private void Awake()
        {
            if (Instance != null & Instance != this)
                Destroy(this);
            else
                Instance = this;
        }

        public event Action<DialogueDto> OnDialogueTriggered;
        public void DialogueTriggered(DialogueDto dialogue)
        {
            OnDialogueTriggered?.Invoke(dialogue);
        }

        public event Action OnNextSentenceTriggered;

        public void NextSentenceTriggered()
        {
            OnNextSentenceTriggered?.Invoke();
        }

        public event Action OnEndDialogueTriggered;
        public void EndDialogueTriggered()
        {
            OnEndDialogueTriggered?.Invoke();
        }
        
        public event Action OnTurnEnded;
        public void TurnEnded()
        {
            OnTurnEnded?.Invoke();
        }

        public event Action<IAbility> OnAbilityUsed;
        public void AbilityUsed(IAbility ability)
        {
            OnAbilityUsed?.Invoke(ability);
        }
    }
}
