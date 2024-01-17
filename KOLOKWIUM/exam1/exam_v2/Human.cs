using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
namespace test
{

    public abstract class Human : IHuman
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Human(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public void Print()
        {
            Console.WriteLine($"Imię: {FirstName}, Nazwisko: {LastName}");
        }
    }
}
