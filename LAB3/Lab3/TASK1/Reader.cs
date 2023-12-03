using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.TASK1
{
    // Zadanie 1b
    public class Reader : Person
    {
        protected List<Book> ReadBooks { get; set; }

        public Reader(string firstName, string lastName, int age) : base(firstName, lastName, age)
        {
            ReadBooks = new List<Book>();
        }

        public void ViewBook()
        {
            foreach (var book in ReadBooks)
            {
                book.View();
            }
        }

        public void AddBook(Book book)
        {
            ReadBooks.Add(book);
        }

        // Zadanie 1c
        public override void View()
        {
            base.View();
            ViewBook();
        }
    }
}
