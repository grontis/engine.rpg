using System;
using GrontisIO.Engine.RPG.UI.Interfaces;
using TMPro;
using UnityEngine;

namespace GrontisIO.Engine.RPG.UI.Ability
{
    public class AbilityBtn : MonoBehaviour, IButton
    {
        public string skillName;
        public int damage;
        //TODO instead of these properties, use an ability object
        //public Ability ability;
        
        private TextMeshProUGUI _text;

        public delegate void AbilityUsedEventHandler(object source, EventArgs args);
        public event AbilityUsedEventHandler AbilityUsed;
        
        private void Start()
        {
            _text = GetComponentInChildren<TextMeshProUGUI>();
            _text.text = skillName;
        }

        public void OnClick()
        {
            OnAbilityUsed();
        }

        protected virtual void OnAbilityUsed()
        {
            AbilityUsed?.Invoke(this, EventArgs.Empty);
        }
    }
}