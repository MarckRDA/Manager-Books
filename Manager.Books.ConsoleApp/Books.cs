using System;

namespace Manager.Books.ConsoleApp
{
    public class Books
    {
        public int BooksId { get; set; }
        public string Name { get; }
        public string Cathegory { get; private set; }
        public int Pages { get; private set; }
        public string States { get; set; }
        public Books(string name, int pages, string cathegory, string states)
        {
            if (String.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("The name's book is required!");
            }
            this.Name = name;

            if (pages <= 0)
            {
                throw new ArgumentException("A book has more than 0 page!");
            }

            this.Pages = pages;

            this.States = states;

            this.Cathegory = cathegory;
        }

        public override string ToString()
        {
            return $"Book: {Name}   Pages: {Pages}  Status: {States}";
        }

    }
}