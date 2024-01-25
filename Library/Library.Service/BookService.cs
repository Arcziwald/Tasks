using Library.Core;
using Library.Service;
using System.Collections.Generic;
using System.Linq;

namespace Library.Service
{
    public class BookService : IBookService
    {
        private readonly List<Book> _books;

        public BookService()
        {
            _books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            _books.Add(book);
        }

        public void RemoveBook(int index)
        {
            if (index >= 0 && index < _books.Count)
            {
                _books.RemoveAt(index);
            }
        }

        public Book? SearchBook(string title)
        {
            return _books.FirstOrDefault(book => book.Title.ToLower().Contains(title.ToLower()));
        }

        public void BorrowBook(int bookId, int userId)
        {
            var book = _books.FirstOrDefault(b => b.Id == bookId && b.Available);
            if (book != null)
            {
                book.Available = false;
                book.BorrowedById = userId;
            }
        }

        public List<Book> GetAllBooks()
        {
            return _books;
        }
    }
}