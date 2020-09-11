using System.Collections.Generic;

namespace Manager.Books.ConsoleApp
{
    public interface IBooksDAO
    {
        void AddBook(Books book);
        void UpdateBook(Books book);
        void DeleteBook(Books book);
        IList<Books> RecoverBooks();        
    }
}