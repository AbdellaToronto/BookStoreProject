using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookData
{
    public class Borrower:IPerson
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
        public string Address { get; set; }
        public string City { get; set; }
        public int PhoneNumber { get; set; }

        public Borrower(string fname, string lname, string address, string city, int pnum)
        {
            FirstName = fname;
            LastName = lname;
            Address = address;
            City = city;
            PhoneNumber = pnum;
        }
    }
}
