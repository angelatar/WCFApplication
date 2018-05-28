using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace BookNS
{
    /// <summary>
    /// Simple library
    /// </summary>
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class Library : ILibrary
    {
        /// <summary>
        /// Books
        /// </summary>
        public List<Book> Books { set; get; }

        public Library()
        {
            this.Books = new List<Book>();
        }

        /// <summary>
        /// Add book in library
        /// </summary>
        /// <param name="book"></param>
        public void AddBook(Book book)
        {
            Console.WriteLine(this.Books.Count);
            this.Books.Add(book);
            Console.WriteLine(this.Books.Count);
        }

        /// <summary>
        /// Return all books in library
        /// </summary>
        /// <returns></returns>
        public List<Book> AllBooks()
        {
            Console.WriteLine(this.Books.Count);
            return this.Books;
        }

        /// <summary>
        /// Update special book's price
        /// </summary>
        /// <param name="book"></param>
        /// <param name="newPrice"></param>
        public void UpdatePrice(Book book, double newPrice)
        {
            if(this.Books.Contains(book))
            {
                var index = this.Books.IndexOf(book);
                this.Books[index].Price = newPrice;
            }
            else
            {
                Console.WriteLine("This book does not exist!!");
            }
        }
    }
}
