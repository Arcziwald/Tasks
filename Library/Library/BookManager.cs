using Library.Core;
using Library.Service;
using Library.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Library
{
    public static class BookManager
    {
        public static void AddBook(IBookService bookService)
        {
            Console.WriteLine("Wprowadź tytuł książki:");
            string title = Console.ReadLine() ?? string.Empty;
            Console.WriteLine("Wprowadź autora książki:");
            string author = Console.ReadLine() ?? string.Empty;
            Console.WriteLine("Wprowadź rok wydania książki:");

            if (!int.TryParse(Console.ReadLine(), out int year))
            {
                Console.WriteLine("Proszę wprowadzić poprawny rok.");
                return;
            }

            if (!string.IsNullOrWhiteSpace(title) && !string.IsNullOrWhiteSpace(author))
            {
                bookService.AddBook(new Book(title, author, year));
                Console.WriteLine("Książka dodana.");
            }
            else
            {
                Console.WriteLine("Tytuł i autor nie mogą być puste.");
            }
        }

        public static void RemoveBook(IBookService bookService)
        {
            var books = bookService.GetAllBooks();
            for (int i = 0; i < books.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {books[i]}");
            }

            Console.WriteLine("Wprowadź numer książki do usunięcia:");
            if (int.TryParse(Console.ReadLine(), out int index) && index >= 1 && index <= books.Count)
            {
                bookService.RemoveBook(index - 1);
                Console.WriteLine("Książka usunięta.");
            }
            else
            {
                Console.WriteLine("Nieprawidłowy numer książki.");
            }
        }

        public static void ViewBooks(IBookService bookService)
        {
            var books = bookService.GetAllBooks();
            if (books.Count == 0)
            {
                Console.WriteLine("Brak dostępnych książek.");
            }
            else
            {
                foreach (var book in books)
                {
                    Console.WriteLine(book);
                }
            }
        }

        public static void SearchBook(IBookService bookService)
        {
            Console.WriteLine("Wprowadź tytuł książki:");
            string title = Console.ReadLine() ?? string.Empty;
            var foundBook = bookService.SearchBook(title);
            if (foundBook != null)
            {
                Console.WriteLine($"Znaleziono książkę: {foundBook}");
            }
            else
            {
                Console.WriteLine("Książka nie została znaleziona.");
            }
        }
    }
}