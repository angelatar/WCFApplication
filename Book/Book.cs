using System;
using System.ServiceModel;

namespace BookNS
{
    [ServiceContract]
    [Serializable]
    /// <summary>
    /// Book intraduction
    /// </summary>
    public class Book
    {
        /// <summary>
        /// Book's ID
        /// </summary>
        public int Id { set; get; }

        /// <summary>
        /// Name of author
        /// </summary>
        public string Author { set; get; }

        /// <summary>
        /// Book's title
        /// </summary>
        public string Title { set; get; }

        /// <summary>
        /// Book's price
        /// </summary>
        public double Price { set; get; }

        /// <summary>
        /// Publish year
        /// </summary>
        public int Year { set; get; }

        public Book(int id, string author, string title, double price, int year)
        {
            this.Id = id;
            this.Author = author;
            this.Title = title;
            this.Year = year;
        }

        public override string ToString()
        {
            return "Author is " + this.Author + ". Tilite is " + this.Title + ". Published in " + this.Year + ". Cost " + this.Price + ".";
        }

    }
}
