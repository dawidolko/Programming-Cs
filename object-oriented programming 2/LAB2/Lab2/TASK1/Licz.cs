using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Licz
    {
        private double value; // Prywatne pole przechowujące wartość liczbową

        // Konstruktor inicjujący pole 'value'
        public Licz(double initialValue)
        {
            value = initialValue;
        }

        // Metoda dodająca wartość do pola 'value'
        public void Dodaj(double amount)
        {
            value += amount;
        }

        // Metoda odejmująca wartość od pola 'value'
        public void Odejmij(double amount)
        {
            value -= amount;
        }

        // Metoda wypisująca stan obiektu
        public void WypiszStan()
        {
            Console.WriteLine("Aktualna wartość: " + value);
        }
    }

}
