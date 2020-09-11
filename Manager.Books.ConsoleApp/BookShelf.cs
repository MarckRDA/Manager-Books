using System;
using System.Collections.Generic;
using System.Linq;

namespace Manager.Books.ConsoleApp
{
    public class BookShelf
    {
        private IList<Books> _myBooks = new List<Books>();

        public BookShelf()
        {
        }

        private IList<Books> GetBooks() => this._myBooks;
        public void AddBook(Books book)
        {
            if (FindBooksByName(book.Name) == null)
                this._myBooks.Add(book);
        }

        public void removeBook(Books book)
        {
            if (FindBooksByName(book.Name) != null)
                this._myBooks.Remove(book);
        }

        public void ShowBooksInMyBookShelf()
        {
            foreach (var item in GetBooks())
            {
                Console.WriteLine(item);
            }
        }
        public Books FindBooksByName(string nameBook)
        {
            return _myBooks.FirstOrDefault(s => s.Name == nameBook);
        }

        public void ChangeStatusBook(Books book, string status)
        {
            var findBook = FindBooksByName(book.Name);
            book.States = status;
        }
        public void FindBooksByCathegory(string cathegory)
        {
            foreach (var i in _myBooks.Where(s => s.Cathegory == cathegory))
            {
                Console.WriteLine(i);
            }
        }

    }
}