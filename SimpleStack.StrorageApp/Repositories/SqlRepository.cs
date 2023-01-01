using System;
using SimpleStack.StrorageApp.Entities;
using System.Collections.Generic;
using System.Linq;

namespace SimpleStack.StrorageApp.Repositories
{
    public class SqlRepository<T, TKey>
       where T : class, IEntity
       where TKey : T
    {
        private readonly List<T> _items = new();


        public T? GetById(int id)
        {
            return _items.Single(item => item.Id == id);

        }

        public void Add(T item)
        {
            item.Id = _items.Count + 1;
            _items.Add(item);
        }
        public void Remove(T item)
        {
            _items.Remove(item);
        }

        public void Save()
        {
            foreach (var item in _items)
            {
                Console.WriteLine(item);
            }
        }

    }

}
