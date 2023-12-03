using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.TASK2
{
    public class Sumator
    {
        private int[] Liczby; // Prywatna tablica liczb

        // Konstruktor inicjujący tablicę 'Liczby'
        public Sumator(int[] liczby)
        {
            Liczby = liczby;
        }

        // Metoda zwracająca sumę liczb z tablicy
        public int Suma()
        {
            int suma = 0;
            foreach (int liczba in Liczby)
            {
                suma += liczba;
            }
            return suma;
        }

        // Metoda zwracająca sumę liczb podzielnych przez 2
        public int SumaPodziel2()
        {
            int suma = 0;
            foreach (int liczba in Liczby)
            {
                if (liczba % 2 == 0)
                {
                    suma += liczba;
                }
            }
            return suma;
        }

        // Metoda zwracająca liczbę elementów w tablicy
        public int IleElementów()
        {
            return Liczby.Length;
        }

        // Metoda wypisująca wszystkie elementy tablicy
        public void WypiszWszystkieElementy()
        {
            foreach (int liczba in Liczby)
            {
                Console.WriteLine(liczba);
            }
        }

        // Metoda wypisująca elementy tablicy w zakresie od lowIndex do highIndex
        public void WypiszElementy(int lowIndex, int highIndex)
        {
            for (int i = lowIndex; i <= highIndex && i < Liczby.Length; i++)
            {
                if (i >= 0)
                {
                    Console.WriteLine(Liczby[i]);
                }
            }
        }
    }
}
