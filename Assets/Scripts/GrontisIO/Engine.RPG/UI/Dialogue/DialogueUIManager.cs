using System.Collections.Generic;
using System.Linq;
using GrontisIO.Engine.RPG.Dialogue;
using GrontisIO.Engine.RPG.Interfaces;
using UnityEngine;

namespace GrontisIO.Engine.RPG.UI.Dialogue
{
    public class DialogueUIManager : MonoBehaviour, IManager 
    {
        public DialogueFrame dialogueFrame;
        private Queue<string> _sentences;

        private void Start()
        {
            _sentences = new Queue<string>(); 
        }

        public void StartDialogue(DialogueDTO dialogueDto)
        {
            dialogueFrame.continueBtn.gameObject.SetActive(true);
            dialogueFrame.endBtn.gameObject.SetActive(false);
            dialogueFrame.characterName.text = dialogueDto.characterName;
        
            foreach (string sentence in dialogueDto.sentences)
            {
                _sentences.Enqueue(sentence);
            }
        
            dialogueFrame.gameObject.SetActive(true);
            DisplayNextSentence();
        }
        
        //TODO eventing for next/end btns?
        public void DisplayNextSentence()
        {
            string sentence = _sentences.Dequeue();
            dialogueFrame.dialogue.text = sentence;
        
            if (!_sentences.Any())
            {
                dialogueFrame.continueBtn.gameObject.SetActive(false);
                dialogueFrame.endBtn.gameObject.SetActive(true);
            }
        }
        
        public void EndDialogue()
        {
            dialogueFrame.gameObject.SetActive(false);
            _sentences.Clear();
        }
    }
}