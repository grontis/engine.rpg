using System.Collections.ObjectModel;
using GrontisIO.Engine.RPG.Characters;

namespace GrontisIO.Engine.RPG.Turn.Interfaces
{
    public interface ITurnOrder
    {
        int Count { get; }
        ICharacter CurrentElement { get; }
        int CurrentIndex { get; }

        void Iterate();
        ICharacter GetElementAt(int index);
        ReadOnlyCollection<ICharacter> GetAll();
        void Add(ICharacter entity);
        void Remove(ICharacter entity);
        void Sort(ICharacter entity);
    }
}
