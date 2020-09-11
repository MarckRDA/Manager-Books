using System;
using System.Collections.Generic;
using System.Linq;

namespace Manager.Books.ConsoleApp
{
    public class BooksDAO : IBooksDAO, IDisposable
    {
        private BooksContext _context;
        public BooksDAO()
        {
            this._context = new BooksContext();
        }

        public void AddBook(Books book)
        {
            _context.Books.Add(book);
            _context.SaveChanges();
        }

        public void UpdateBook(Books book)
        {
            _context.Books.Update(book);
            _context.SaveChanges();
        }

        public void DeleteBook(Books book)
        {
            _context.Books.Remove(book);
            _context.SaveChanges();
        }

        public IList<Books> RecoverBooks()
        {
            return _context.Books.ToList();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}