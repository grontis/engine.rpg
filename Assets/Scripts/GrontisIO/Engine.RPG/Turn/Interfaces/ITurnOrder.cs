using System.Collections.ObjectModel;

namespace GrontisIO.engine.RPG.Turn.Interfaces
{
    public interface ITurnOrder
    {
        int Count { get; }
        ITurnEntity CurrentElement { get; }
        int CurrentIndex { get; }

        void Iterate();
        ITurnEntity GetElementAt(int index);
        ReadOnlyCollection<ITurnEntity> GetAll();
        void Add(ITurnEntity entity);
        void Remove(ITurnEntity entity);
        void Sort(ITurnEntity entity);
    }
}
