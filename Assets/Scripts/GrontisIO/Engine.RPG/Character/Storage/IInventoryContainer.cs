using GrontisIO.Engine.RPG.Items.Interfaces;

namespace GrontisIO.Engine.RPG.Character.Storage
{
    public interface IInventoryContainer
    {
        void Add(IItem item);

        void Remove(IItem item);

        void IncreaseCurrency(float amount);

        void DecreaseCurrency(float amount);
    }
}