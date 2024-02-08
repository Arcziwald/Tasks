using Library.Core;
using Library.Service;
using Library.Service.Interfaces;
using System;
using System.Linq;

namespace Library
{
    public class Program
    {
        private static IBookService bookService;
        private static IUserService userService;

        public static void Main(string[] args)
        {
            bookService = new BookService();
            userService = new UserService();

            Menu();
        }

        private static void Menu()
        {
            while (true)
            {
                Console.WriteLine("\n1. Zarządzaj książkami");
                Console.WriteLine("2. Zarządzaj użytkownikami");
                Console.WriteLine("3. Wyjdź z programu");
                Console.WriteLine("Wybierz opcję:");

                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Proszę wprowadzić liczbę.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        BookManagerMenu();
                        break;

                    case 2:
                        UserManagerMenu();
                        break;

                    case 3:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Nieprawidłowa opcja.");
                        break;
                }
            }
        }

        private static void BookManagerMenu()
        {
            while (true)
            {
                Console.WriteLine("\n1. Dodaj książkę");
                Console.WriteLine("2. Usuń książkę");
                Console.WriteLine("3. Wyświetl dostępne książki");
                Console.WriteLine("4. Wyszukaj książkę po tytule");
                Console.WriteLine("5. Powrót do poprzedniego menu");
                Console.WriteLine("Wybierz opcję:");

                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Proszę wprowadzić liczbę.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        BookManager.AddBook(bookService);
                        break;

                    case 2:
                        BookManager.RemoveBook(bookService);
                        break;

                    case 3:
                        BookManager.ViewBooks(bookService);
                        break;

                    case 4:
                        BookManager.SearchBook(bookService);
                        break;

                    case 5:
                        return;

                    default:
                        Console.WriteLine("Nieprawidłowa opcja.");
                        break;
                }
            }
        }

        private static void UserManagerMenu()
        {
            while (true)
            {
                Console.WriteLine("\n1. Dodaj użytkownika");
                Console.WriteLine("2. Wyświetl użytkowników");
                Console.WriteLine("3. Powrót do poprzedniego menu");
                Console.WriteLine("Wybierz opcję:");

                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Proszę wprowadzić liczbę.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        UserManager.AddUser(userService);
                        break;

                    case 2:
                        UserManager.ViewUsers(userService);
                        break;

                    case 3:
                        return;

                    default:
                        Console.WriteLine("Nieprawidłowa opcja.");
                        break;
                }
            }
        }
    }
}