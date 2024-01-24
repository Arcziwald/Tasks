using System;
using Library.Core;

namespace Library.Services
{
    public interface IBookService
    {
        void AddBook(Book book);
        void RemoveBook(int index);
        Book SearchBook(string title);
        // Inne metody
    }
}
public class Class1
{
    public Class1()
    {
    }
}