using System;


namespace Manager.Books.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var myBookShelf = new BookShelf();
            var harryPotter = new Books("Harry Potter and the chamber secret", 450, "Adventure", "Reading");
            var gameOfThrones = new Books("A song of ice and fire: A game of thrones", 690, "Dark Fantasy", "Read");
            var gameOfThrones1 = new Books("A song of ice and fire: A game of thrones", 690, "Dark Fantasy", "Read");
            var gameOfThrones2 = new Books("A song of ice and fire: A game of thrones", 690, "Dark Fantasy", "Read");

            myBookShelf.AddBook(harryPotter);
            myBookShelf.AddBook(gameOfThrones);

            myBookShelf.ShowBooksInMyBookShelf();

            myBookShelf.ChangeStatusBook(gameOfThrones, "Unread");



            Console.WriteLine(myBookShelf.FindBooksByName("Harry Potter and the chamber secret"));

            myBookShelf.FindBooksByCathegory("Dark Fantasy");
            
        }
    }
}
