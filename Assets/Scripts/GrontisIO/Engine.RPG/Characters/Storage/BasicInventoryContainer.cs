using System.Collections.Generic;
using GrontisIO.Engine.RPG.Characters.Storage.Interfaces;
using GrontisIO.Engine.RPG.Items.Interfaces;

namespace GrontisIO.Engine.RPG.Characters.Storage
{
    public class BasicInventoryContainer : IInventoryContainer
    {
        private List<IItem> _items;

        public IReadOnlyCollection<IItem> Items => _items.AsReadOnly();
        public float Currency { get; private set; }

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
            Currency += amount;
        }
        
        public void DecreaseCurrency(float amount)
        {
            //TODO logic against currency falling below 0?
            Currency -= amount;
        }
    }

}
