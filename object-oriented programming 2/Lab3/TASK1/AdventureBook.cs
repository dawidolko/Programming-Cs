using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.TASK1
{
    public class AdventureBook : Book
    {
        public string Genre { get; set; }

        public AdventureBook(string title, Person author, DateTime releaseDate, string genre)
            : base(title, author, releaseDate)
        {
            Genre = genre;
        }

        public override void View()
        {
            base.View();
            Console.WriteLine($"Genre: {Genre}");
        }
    }
}
