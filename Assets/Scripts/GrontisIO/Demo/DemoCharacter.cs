using System;
using System.Collections.Generic;
using GrontisIO.Engine.RPG.Characters;
using GrontisIO.Engine.RPG.Characters.Abilities;
using GrontisIO.Engine.RPG.Characters.Storage;
using GrontisIO.Engine.RPG.UI.Ability;
using UnityEngine;

namespace GrontisIO.Demo
{
    public class DemoCharacter : MonoBehaviour, ICharacter
    {
        public Details Details { get; set; }
        public Stats Stats { get; set; }
        public Inventory Inventory { get; set; }
        public List<IAbility> Abilities { get; set; }

        private void Start()
        {
            
        }

        private void Update()
        {
        
        }

        public void OnAbilityUsed(object source, EventArgs e)
        {
            Debug.Log("Ability used");
        }
    }
}
