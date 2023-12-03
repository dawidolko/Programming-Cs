using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.TASK1
{
    //Zadanie 1a
    public class Book
    {
        protected string Title { get; set; }
        protected Person Author { get; set; }
        protected DateTime ReleaseDate { get; set; }

        public Book(string title, Person author, DateTime releaseDate)
        {
            Title = title;
            Author = author;
            ReleaseDate = releaseDate;
        }

        public virtual void View()
        {
            Console.WriteLine($"\"{Title}\", author: {Author.FirstName} {Author.LastName}, released: {ReleaseDate.ToShortDateString()}");
        }
    }
}
