using System;
using GrontisIO.Demo;
using GrontisIO.Engine.RPG.Events;
using GrontisIO.Engine.RPG.UI.Interfaces;
using TMPro;
using UnityEngine;

namespace GrontisIO.Engine.RPG.UI.Ability
{
    public class AbilityBtn : MonoBehaviour, IButton
    {
        public DemoAbility ability;
        
        private TextMeshProUGUI _text;
        
        private void Start()
        {
            ability.Name = "Fireball"; //TODO remove this development mock statement, should not be assigned this way
            
            _text = GetComponentInChildren<TextMeshProUGUI>();
            _text.text = ability.Name;
        }

        public void OnClick()
        {
            OnAbilityUsed();
        }

        protected virtual void OnAbilityUsed()
        {
            EventManager.Instance.AbilityUsed(ability);
        }
    }
}