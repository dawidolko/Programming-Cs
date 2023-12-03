using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.TASK3
{

    public class Program3
    {
        public static void Wypisywanie()
        {
            double[] liczby = new double[10];

            Console.WriteLine("Wprowadź 10 liczb rzeczywistych:");
            for (int i = 0; i < liczby.Length; i++)
            {
                Console.Write($"Liczba {i + 1}: ");
                liczby[i] = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine("\nWyświetlanie tablicy od pierwszego do ostatniego indeksu:");
            for (int i = 0; i < liczby.Length; i++)
            {
                Console.WriteLine(liczby[i]);
            }

            Console.WriteLine("\nWyświetlanie tablicy od ostatniego do pierwszego indeksu:");
            for (int i = liczby.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(liczby[i]);
            }

            Console.WriteLine("\nWyświetlanie elementów o nieparzystych indeksach:");
            for (int i = 1; i < liczby.Length; i += 2)
            {
                Console.WriteLine(liczby[i]);
            }

            Console.WriteLine("\nWyświetlanie elementów o parzystych indeksach:");
            for (int i = 0; i < liczby.Length; i += 2)
            {
                Console.WriteLine(liczby[i]);
            }
        }
    }

}
