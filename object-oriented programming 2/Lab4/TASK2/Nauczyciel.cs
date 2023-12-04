using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4.TASK2
{
    public class Nauczyciel : Uczen
    {
        public string TytulNaukowy { get; set; }
        public List<Uczen> PodwladniUczniowie { get; set; } = new List<Uczen>();

        public override string GetEducationInfo()
        {
            return $"{TytulNaukowy} {GetFullName()}";
        }

        public void WhichStudentCanGoHomeAlone(DateTime dateToCheck)
        {
            Console.WriteLine("Uczniowie, którzy mogą wracać do domu sami:");
            foreach (var uczen in PodwladniUczniowie)
            {
                if (uczen.CanGoAloneToHome())
                {
                    Console.WriteLine(uczen.GetFullName());
                }
            }
        }
    }
}
