using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookData
{
    public class Book:IBook
    {

        public int ISBN { get; set; }
        public string Title{get;set;}
        public string Publisher{get;set;}
        public int Rating{get;set;}
        public string Genre{get;set;}
        public string Location{get;set;}
        public string Comments { get; set;}

        Author author;
        Borrower borrower;

        public Book(int isbn, string title, string publisher, int rating, string genre,string location, string comments)
        {
            ISBN = isbn;
            Title = title;
            Publisher = publisher;
            Rating = rating;
            Genre = genre;
            Location = location;
            Comments = comments;
        }



    }
}
