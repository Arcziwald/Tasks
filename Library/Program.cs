using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Tworzenie tablicy książek
        Book[] library = new Book[]
        {
            new Book("Władca Pierścieni", "J.R.R. Tolkien", 1954),
            new Book("1984", "George Orwell", 1949),
            new Book("Harry Potter", "J.K. Rowling", 1997)
        };

        // Lista użytkowników
        List<User> users = new List<User> 
        {
            new User("Jan Kowalski", "jan@kowalski.com"),
            new User("Anna Nowak", "anna@nowak.com")
        };

       