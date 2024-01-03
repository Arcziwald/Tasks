using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Book(string title, string author, int yearOfPublication)
    {
        public string Title { get; set; } = title;
        public string Author { get; set; } = author;
        public int YearOfPublication { get; set; } = yearOfPublication;
        public bool Available { get; set; } = true;
                      
        public override string ToString()
        {
            return $"{Title} - {Author}, {YearOfPublication}";
        }
    }
}
