using System.Collections.Generic;
using GrontisIO.Engine.RPG.Items.Interfaces;

namespace GrontisIO.Engine.RPG.Character.Storage
{
    public class BasicInventoryContainer : IInventoryContainer
    {
        private List<IItem> _items;
        private float _currency;

        public void Add(IItem item)
        {
            _items.Add(item);
        }
        
        public void Remove(IItem item)
        {
            _items.Remove(item);
        }
        
        public void IncreaseCurrency(float amount)
        {
            _currency += amount;
        }
        
        public void DecreaseCurrency(float amount)
        {
            //TODO logic against currency falling below 0?
            _currency -= amount;
        }
    }

}
