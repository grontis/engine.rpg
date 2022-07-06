using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using GrontisIO.Engine.RPG.Characters;
using GrontisIO.Engine.RPG.Turn.Interfaces;

namespace GrontisIO.Engine.RPG.Turn
{
    public class TurnOrder : ITurnOrder
    {
        private List<ICharacter> _characters;
        private int _position;

        public int Count => _characters.Count();
        public ICharacter CurrentElement => GetElementAt(_position);
        public int CurrentIndex => _position;

        public TurnOrder(List<ICharacter> characters)
        {
            _characters = characters;
            _position = 0;
            
            //TODO should the sorting be the responsibility of the order?
            //TODO accept a lambda function as a parameter to define what property to sort on?
        }
        
        public void Iterate()
        {
            
        }

        public ICharacter GetElementAt(int index)
        {
            return _characters.ElementAt(index);
        }

        public ReadOnlyCollection<ICharacter> GetAll()
        {
            return _characters.AsReadOnly();
        }

        public void Add(ICharacter character)
        {
            _characters.Add(character);
        }

        public void Remove(ICharacter character)
        {
            _characters.Remove(character);
        }

        public void Sort(ICharacter character)
        {
            //TODO take in a func as argument for sorting algorithm?
        }
    }
}
