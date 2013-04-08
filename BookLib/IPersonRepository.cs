using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BookData;

namespace BookLib
{
    interface IPersonRepository<T>
        where T : class, IPerson
    {
        void GetAllPersons();
        
    }
}
