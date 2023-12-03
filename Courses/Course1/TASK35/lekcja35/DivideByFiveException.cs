using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lekcja35
{
    class DivideByFiveException : Exception
    {
        public DivideByFiveException() 
        {
            Console.WriteLine("Błąd");
        }
        public DivideByFiveException(string message) : base(message + " dzielenia przez 5!")
        {

        }

        
    }
}
