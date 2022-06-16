using System;
using System.Collections.Generic;
using System.Linq;
using GrontisIO.Engine.RPG.Dialogue;
using GrontisIO.Engine.RPG.Events;
using GrontisIO.Engine.RPG.Events.Interfaces;
using UnityEngine;

namespace GrontisIO.Engine.RPG.UI.Dialogue
{
    public class DialogueUIManager : MonoBehaviour , IEventSubscriber
    {
        public DialoguePanel dialoguePanel;
        private Queue<string> _sentences;

        private void Start()
        {
            SubscribeEvents();
            
            _sentences = new Queue<string>(); 
        }

        private void OnDestroy()
        {
            UnsubscribeEvents();
        }

        public void SubscribeEvents()
        {
            EventManager.Instance.OnDialogueTriggered += StartDialogue;
            EventManager.Instance.OnNextSentenceTriggered += DisplayNextSentence;
            EventManager.Instance.OnEndDialogueTriggered += EndDialogue;
        }

        public void UnsubscribeEvents()
        {
            EventManager.Instance.OnDialogueTriggered -= StartDialogue;
            EventManager.Instance.OnNextSentenceTriggered -= DisplayNextSentence;
            EventManager.Instance.OnEndDialogueTriggered -= EndDialogue;
        }

        private void StartDialogue(DialogueDTO dialogueDto)
        {
            _sentences = new Queue<string>();
            foreach (var sentence in dialogueDto.sentences)
            {
                _sentences.Enqueue(sentence);
            }
            
            /*TODO
                abstract this below panel logic into the panel so that this class doesnt depend too much
                on what the panel is made up of.
                dialoguePanel.Init()?
            */
            dialoguePanel.continueBtn.gameObject.SetActive(true);
            dialoguePanel.endBtn.gameObject.SetActive(false);
            dialoguePanel.characterName.text = dialogueDto.characterName;
            dialoguePanel.gameObject.SetActive(true);
            DisplayNextSentence();
        }
        
        private void DisplayNextSentence()
        {
            var sentence = _sentences.Dequeue();
            dialoguePanel.dialogue.text = sentence;

            if (_sentences.Any()) return;
            
            dialoguePanel.continueBtn.gameObject.SetActive(false);
            dialoguePanel.endBtn.gameObject.SetActive(true);
        }

        private void EndDialogue()
        {
            dialoguePanel.gameObject.SetActive(false);
            _sentences.Clear();
        }
    }
}