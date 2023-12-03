using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.TASK1
{
    public class DocumentaryBook : Book
    {
        public string Topic { get; set; }

        public DocumentaryBook(string title, Person author, DateTime releaseDate, string topic)
            : base(title, author, releaseDate)
        {
            Topic = topic;
        }

        public override void View()
        {
            base.View();
            Console.WriteLine($"Topic: {Topic}");
        }
    }
}
