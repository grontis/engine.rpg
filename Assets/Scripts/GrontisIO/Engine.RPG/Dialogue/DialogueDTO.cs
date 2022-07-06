using System;
using GrontisIO.Engine.RPG.Characters;

namespace GrontisIO.Engine.RPG.Dialogue
{
    [Serializable]
    public class DialogueDto
    {
        public string[] sentences;
        public string characterName;
    }
}
