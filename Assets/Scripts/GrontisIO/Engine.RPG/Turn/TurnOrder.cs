using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using GrontisIO.Engine.RPG.Turn.Interfaces;

namespace GrontisIO.Engine.RPG.Turn
{
    public class TurnOrder : ITurnOrder
    {
        private List<ITurnEntity> _entities;
        private int _position;

        public int Count => _entities.Count();
        public ITurnEntity CurrentElement => GetElementAt(_position);
        public int CurrentIndex => _position;

        public TurnOrder(List<ITurnEntity> entities)
        {
            _entities = entities;
            _position = 0;
            
            //TODO should the sorting be the responsibility of the order?
            //TODO accept a lambda function as a parameter to define what property to sort on?
        }
        
        public void Iterate()
        {
            throw new System.NotImplementedException();
        }

        public ITurnEntity GetElementAt(int index)
        {
            throw new System.NotImplementedException();
        }

        public ReadOnlyCollection<ITurnEntity> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public void Add(ITurnEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public void Remove(ITurnEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public void Sort(ITurnEntity entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
