using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class Student : Human, IHuman, IStudent
    {
        public int Grade { get; set; }

        public Student(string firstName, string lastName, int grade)
            : base(firstName, lastName)
        {
            if (grade < 1 || grade > 7)
            {
                throw new ArgumentException("Ocena musi być między 1 a 6 i nie może być ujemna!");
            }

            Grade = grade;
        }

        public override string ToString()
        {
            return $"Student: {FirstName} {LastName}, Ocena: {Grade}";
        }
    }

}
