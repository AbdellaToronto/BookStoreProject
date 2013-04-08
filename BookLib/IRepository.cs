using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BookData;

namespace BookLib
{
    interface IRepository<T>
        where T : class
    {
        void Add(T item);
        void Remove(T item);
        T GetByID(int bID);
    }
}
