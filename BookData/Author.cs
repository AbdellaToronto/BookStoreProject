using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookData
{
    public class Author : IPerson
    {
        public string FirstName
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
        public string LastName
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
        public string Comments { get; set; }

        public Author(string Fname, string Lname, string comments)
        {
            FirstName = Fname;
            LastName = Lname;
            Comments = comments;
        }
    }
}
