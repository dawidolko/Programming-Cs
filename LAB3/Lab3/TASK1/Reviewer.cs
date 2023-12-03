using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.TASK1
{
    // Zadanie 1f
    public class Reviewer : Reader
    {
        public Reviewer(string firstName, string lastName, int age) : base(firstName, lastName, age)
        {
        }

        public new void ViewBook()
        {
            var random = new Random();
            foreach (var book in ReadBooks)
            {
                int score = random.Next(1, 6); // Random score from 1 to 5
                book.View();
                Console.WriteLine($"Score: {score}");
            }
        }
    }
}
