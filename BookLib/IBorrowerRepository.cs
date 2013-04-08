using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BookData;

namespace BookLib
{
    interface IBorrowerRepository:IPersonRepository<Borrower>
    {
        void GetBorrowerByName();
    }
}
