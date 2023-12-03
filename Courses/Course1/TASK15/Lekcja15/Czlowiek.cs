using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja15
{
    internal class Czlowiek
    {
        public string imie = "Adrain", nazwisko = "Kowalski";
        public void PrzedstawSie()
        {
            //this działa tak samo ja w java 
            Console.WriteLine("Mam na imię: " + this.imie + " na nazwisko: " + this.nazwisko);
        }
    }
}
