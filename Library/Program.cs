using Library.Core; // Dla klas Book, User
using Library.Service; // Dla IBookService, IUserService
using System;
using System.Linq;

namespace Library
{
    public class Program 
    {
        private static void Main(string[] args)
        {
            IBookService bookService = new BookService();
            IUserService userService = new UserService();

            while (true)
            {
                Console.WriteLine("\n1. Dodaj książkę");
                Console.WriteLine("2. Usuń książkę");
                Console.WriteLine("3. Dodaj użytkownika");
                Console.WriteLine("4. Wyświetl dostępne książki");
                Console.WriteLine("5. Wyszukaj książkę po tytule");
                Console.WriteLine("6. Wyjdź z programu");
                Console.WriteLine("7. Wypożycz książkę");
                Console.WriteLine("Wybierz opcję:");

                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Proszę wprowadzić liczbę.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        AddBook(bookService);
                        break;

                    case 2:
                        RemoveBook(bookService);
                        break;

                    case 3:
                        AddUser(userService);
                        break;

                    case 4:
                        ViewBooks(bookService);
                        break;

                    case 5:
                        SearchBook(bookService);
                        break;

                    case 6:
                        Environment.Exit(0);
                        break;

                    case 7:
                        BorrowBook(bookService, userService);
                        break;

                    default:
                        Console.WriteLine("Nieprawidłowa opcja.");
                        break;
                }
            }
        }

        private static void AddBook(IBookService bookService)
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

            if (title != null && author != null) // Zmiana: sprawdzenie, czy tytuł i autor nie są null
            {
                bookService.AddBook(new Book(title, author, year));
                Console.WriteLine("Książka dodana.");
            }
            else
            {
                Console.WriteLine("Tytuł i autor nie mogą być puste.");
            }
        }

        private static void RemoveBook(IBookService bookService)
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

        private static void AddUser(IUserService userService)
        {
            Console.WriteLine("Wprowadź imię i nazwisko użytkownika:");
            string name = Console.ReadLine() ?? string.Empty; // Dodano sprawdzenie null
            Console.WriteLine("Wprowadź email użytkownika:");
            string email = Console.ReadLine() ?? string.Empty; // Dodano sprawdzenie null

            int newId = userService.GetNextUserId();
            userService.AddUser(new User(newId, name, email));
            Console.WriteLine("Użytkownik dodany. Przyznano ID: " + newId);
        }

        private static void ViewBooks(IBookService bookService)
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

        private static void SearchBook(IBookService bookService)
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

        private static void BorrowBook(IBookService bookService, IUserService userService)
        {
            // Wyświetlenie dostępnych książek
            var availableBooks = bookService.GetAllBooks().Where(b => b.Available).ToList();
            if (availableBooks.Count == 0)
            {
                Console.WriteLine("Brak dostępnych książek do wypożyczenia.");
                return;
            }

            Console.WriteLine("Dostępne książki:");
            foreach (var book in availableBooks)
            {
                Console.WriteLine($"{book.Id}. {book.Title} - {book.Author}");
            }

            // Wybór książki do wypożyczenia
            Console.WriteLine("Podaj ID książki do wypożyczenia:");
            if (!int.TryParse(Console.ReadLine(), out int bookId))
            {
                Console.WriteLine("Nieprawidłowy ID książki.");
                return;
            }

            // Wyświetlenie listy użytkowników
            var users = userService.GetAllUsers();
            if (users.Count() == 0)
            {
                Console.WriteLine("Brak zarejestrowanych użytkowników.");
                return;
            }

            Console.WriteLine("Zarejestrowani użytkownicy:");
            foreach (var user in users)
            {
                Console.WriteLine($"{user.Id}. {user.Name}");
            }

            // Wybór użytkownika, który wypożycza książkę
            Console.WriteLine("Podaj ID użytkownika wypożyczającego książkę:");
            if (!int.TryParse(Console.ReadLine(), out int userId) || !users.Any(u => u.Id == userId))
            {
                Console.WriteLine("Nieprawidłowy ID użytkownika.");
                return;
            }

            // Wypożyczenie książki
            bookService.BorrowBook(bookId, userId);
            Console.WriteLine("Książka została wypożyczona.");
        }
    }
}