using System;
using GrontisIO.Engine.RPG.Characters.Abilities;
using UnityEngine;

namespace GrontisIO.Engine.RPG.Demo
{
    //TODO serialize this class so that it can be edited in Editor without being attached to a gameobject
    [Serializable]
    public class DemoAbility : MonoBehaviour, IAbility
    {
        public string Name { get; set; }
        public float Cost { get; set; }
        public void Use()
        {
            throw new System.NotImplementedException();
        }
    }
}
