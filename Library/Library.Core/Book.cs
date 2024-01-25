using Library.Core;
using Library.Service;
using System;
using System.Linq;
using System.Collections.Generic;

namespace Library.Core
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string? Genre { get; set; }
        public int YearOfPublication { get; set; }
        public int Id { get; set; }
        public int? BorrowedById { get; set; }
        public bool Available { get; set; } = true;

        public Book(string title, string author, int yearOfPublication)
        {
            Title = title;
            Author = author;
            Genre = null; // Domyślnie ustawiamy na null, może być ustalone później
            YearOfPublication = yearOfPublication;
            BorrowedById = null; // Domyślnie książka nie jest wypożyczona
            Available = true; // Domyślnie książka jest dostępna
        }

        public override string ToString()
        {
            return $"{Title} - {Author}, {YearOfPublication}";
        }
    }
}