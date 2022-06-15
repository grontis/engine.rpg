using System;
using GrontisIO.Engine.RPG.Characters;

namespace GrontisIO.Engine.RPG.Dialogue
{
    [Serializable]
    public class DialogueDTO
    {
        public string[] sentences;
        public string characterName;
    }
}
