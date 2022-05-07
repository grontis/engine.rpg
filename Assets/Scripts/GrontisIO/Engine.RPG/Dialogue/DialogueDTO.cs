using GrontisIO.engine.RPG.Interfaces;
using UnityEngine;

namespace GrontisIO.engine.RPG.Dialogue
{
    [System.Serializable]
    public class DialogueDTO : IDataTransferObject
    {
        public string characterName;
        [TextArea(3, 10)]
        public string[] sentences;
    }
}