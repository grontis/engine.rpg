using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using GrontisIO.Engine.RPG.Characters;
using GrontisIO.Engine.RPG.Turn.Interfaces;

namespace GrontisIO.Engine.RPG.Turn
{
    public class TurnOrder : ITurnOrder
    {
        private List<ICharacter> _entities;
        private int _position;

        public int Count => _entities.Count();
        public ICharacter CurrentElement => GetElementAt(_position);
        public int CurrentIndex => _position;

        public TurnOrder(List<ICharacter> entities)
        {
            _entities = entities;
            _position = 0;
            
            //TODO should the sorting be the responsibility of the order?
            //TODO accept a lambda function as a parameter to define what property to sort on?
        }
        
        public void Iterate()
        {
            
        }

        public ICharacter GetElementAt(int index)
        {
            throw new System.NotImplementedException();
        }

        public ReadOnlyCollection<ICharacter> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public void Add(ICharacter entity)
        {
            throw new System.NotImplementedException();
        }

        public void Remove(ICharacter entity)
        {
            throw new System.NotImplementedException();
        }

        public void Sort(ICharacter entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
