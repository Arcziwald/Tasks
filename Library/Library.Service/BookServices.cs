using Library.Core;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Library.Services
{
    public class BookService : IBookService
    {
        private readonly List<Book> _books;

        public BookService()
        {
            _books = new List<Book>();
            // Możesz tu dodać kilka książek dla testów
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

        public void BorrowBook(int bookId, int userId)
        {
            var book = _books.FirstOrDefault(b => b.Id == bookId);
            if (book != null && book.Available)
            {
                book.BorrowedById = userId;
                book.Available = false;
            }
        }

        public List<Book> GetAllBooks()
        {
            return _books;
        }

        public List<Book> GetBooksByGenre(string genre)
        {
            return _books.Where(b => b.Genre.Equals(genre, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public List<Book> GetBooksSortedByYear()
        {
            return _books.OrderBy(b => b.YearOfPublication).ToList();
        }

        public Book SearchBook(string title)
        {
            return _books.FirstOrDefault(book => book.Title.ToLower().Contains(title.ToLower()));
        }

        // Inne metody
    }
}