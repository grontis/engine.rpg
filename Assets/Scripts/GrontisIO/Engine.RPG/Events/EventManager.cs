using System;
using System.Collections.Generic;
using GrontisIO.Engine.RPG.Characters.Abilities;
using GrontisIO.Engine.RPG.Dialogue;
using GrontisIO.Engine.RPG.UI.Ability;
using UnityEngine;
using UnityEngine.Events;

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

        public event Action<DialogueDTO> OnDialogueTriggered;
        public void DialogueTriggered(DialogueDTO dialogue)
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

        public event Action<IAbility> OnAbilityUsed;
        public void AbilityUsed(IAbility ability)
        {
            OnAbilityUsed?.Invoke(ability);
        }
    }
}
