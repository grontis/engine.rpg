using GrontisIO.Engine.RPG.Events.Interfaces;
using UnityEngine;

namespace GrontisIO.Engine.RPG.Dialogue
{
    [System.Serializable]
    public class DialogueDTO : IDataTransferObject
    {
        public string characterName;
        [TextArea(3, 10)]
        public string[] sentences;
    }
}