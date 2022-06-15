using System;
using System.Collections.Generic;
using GrontisIO.Engine.RPG.Characters;
using GrontisIO.Engine.RPG.Characters.Abilities;
using GrontisIO.Engine.RPG.Characters.Storage;
using GrontisIO.Engine.RPG.Events;
using GrontisIO.Engine.RPG.Events.Interfaces;
using GrontisIO.Engine.RPG.UI.Ability;
using UnityEngine;

namespace GrontisIO.Demo
{
    public class DemoCharacter : MonoBehaviour, ICharacter, IEventSubscriber
    {
        public Details Details { get; set; }
        public Stats Stats { get; set; }
        public Inventory Inventory { get; set; }
        public List<IAbility> Abilities { get; set; }

        private void Start()
        {
            SubscribeEvents();
        }

        private void Update()
        {
        
        }

        private void OnDestroy()
        {
            UnsubscribeEvents();
        }

        public void SubscribeEvents()
        {
            EventManager.Instance.OnAbilityUsed += OnAbilityUsed;
        }

        public void UnsubscribeEvents()
        {
            EventManager.Instance.OnAbilityUsed -= OnAbilityUsed;
        }

        public void OnAbilityUsed(IAbility ability)
        {
            Debug.Log($"{ability.Name} used");
        }

        
    }
}
