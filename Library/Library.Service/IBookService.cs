using Library.Core;
using Library.Service;

namespace Library.Service
{
    public interface IBookService
    {
        void AddBook(Book book);

        void RemoveBook(int index);

        Book? SearchBook(string title);

        void BorrowBook(int bookId, int userId); // Dodana metoda

        List<Book> GetAllBooks(); // Dodana metoda

        // Inne metody
    }
}