using System;
using System.Collections.Generic;
using GrontisIO.RPG.Items.Interfaces;

namespace GrontisIO.RPG.Character.Inventory
{
    public class InventoryContainer
    {
        private List<IItem> _items;
        private float _currency;

        public void Add(IItem item)
        {
            throw new NotImplementedException();
        }
        
        public void Remove(IItem item)
        {
            throw new NotImplementedException();
        }
        
        public void IncreaseCurrency(float amount)
        {
            throw new NotImplementedException();
        }
        
        public void DecreaseCurrency(float amount)
        {
            throw new NotImplementedException();
        }
    }
}
