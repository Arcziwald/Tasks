using Library.Core;
using Library.Service;
using Library.Service.Interfaces;
using System;
using System.Linq;

namespace Library
{
    public static class UserManager
    {
        public static void AddUser(IUserService userService)
        {
            Console.WriteLine("Wprowadź imię i nazwisko użytkownika:");
            string name = Console.ReadLine() ?? string.Empty;
            Console.WriteLine("Wprowadź email użytkownika:");
            string email = Console.ReadLine() ?? string.Empty;

            int newId = userService.GetNextUserId();
            userService.AddUser(new User(newId, name, email));
            Console.WriteLine("Użytkownik dodany. Przyznano ID: " + newId);
        }

        public static void ViewUsers(IUserService userService)
        {
            var users = userService.GetAllUsers();
            if (!users.Any())
            {
                Console.WriteLine("Brak zarejestrowanych użytkowników.");
            }
            else
            {
                foreach (var user in users)
                {
                    Console.WriteLine($"{user.Id}. {user.Name} - {user.Email}");
                }
            }
        }
    }
}