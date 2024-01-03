using System;
using System.Collections.Generic;

namespace Library
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Book> library = new List<Book>()
        {
            new ("Władca Pierścieni", "J.R.R. Tolkien", 1954),
            new ("1984", "George Orwell", 1949),
            new ("Harry Potter", "J.K. Rowling", 1997)
        };

            List<User> users = new List<User>
        {
            new (1,"Jan Kowalski", "jan@kowalski.com"),
            new (2, "Anna Nowak", "anna@nowak.com")
        };

            // Menu dla bibliotekarza
            while (true)
            {
                Console.WriteLine("\n1. Dodaj książkę");
                Console.WriteLine("2. Usuń książkę");
                Console.WriteLine("3. Dodaj użytkownika");
                Console.WriteLine("4. Wyświetl dostępne książki");
                Console.WriteLine("5. Wyszukaj książkę po tytule");
                Console.WriteLine("Wybierz opcję:");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddBook(library);
                        break;
                    case 2:
                        RemoveBook(library);
                        break;
                    case 3:
                        AddUser(users);
                        break;
                    case 4:
                        ViewBooks(library);
                        break;
                    case 5:
                        SearchBook(library);
                        break;
                    default:
                        Console.WriteLine("Nieprawidłowa opcja.");
                        break;
                }
            }
        }

        static void AddBook(List<Book> library)
        {
            Console.WriteLine("Wprowadź tytuł książki:");
            string title = Console.ReadLine();
            Console.WriteLine("Wprowadź autora książki:");
            string author = Console.ReadLine();
            Console.WriteLine("Wprowadź rok wydania książki:");
            int year = Convert.ToInt32(Console.ReadLine());

            library.Add(new Book(title, author, year));
            Console.WriteLine("Książka dodana.");
        }

        static void RemoveBook(List<Book> library)
        {
            ViewBooks(library);
            Console.WriteLine("Wprowadź numer książki do usunięcia:");
            int index = Convert.ToInt32(Console.ReadLine()) - 1;
            if (index >= 0 && index < library.Count)
            {
                library.RemoveAt(index);
                Console.WriteLine("Książka usunięta.");
            }
            else
            {
                Console.WriteLine("Nieprawidłowy numer książki.");
            }
        }

        static void AddUser(List<User> users)
        {
            Console.WriteLine("Wprowadź imię i nazwisko użytkownika:");
            string name = Console.ReadLine();
            Console.WriteLine("Wprowadź email użytkownika:");
            string email = Console.ReadLine();

            int newId = users.Count + 1;
            users.Add(new User(newId, name, email));
            Console.WriteLine("Użytkownik dodany. Przyznano ID: " + newId);
        }

        static void ViewBooks(List<Book> library)
        {
            Console.WriteLine("Dostępne książki:");
            for (int i = 0; i < library.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {library[i]}");
            }
        }

        static void SearchBook(List<Book> library)
        {
            Console.WriteLine("Wprowadź tytuł książki:");
            string title = Console.ReadLine();

            Book foundBook = library.FirstOrDefault(book => book.Title.ToLower().Contains(title.ToLower()));
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
