using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.TASK6
{
    public class Program6
    {
        public static void Nieskonczonosc()
        {
            while (true) // Pętla nieskończona
            {
                Console.Write("Wprowadź liczbę całkowitą (liczba ujemna zakończy działanie programu): ");
                int liczba = int.Parse(Console.ReadLine());

                if (liczba < 0) // Jeśli użytkownik wprowadzi liczbę mniejszą od zera, zakończ pętlę
                {
                    break;
                }

                // Można tutaj dodać dodatkowe operacje na liczbie, jeśli jest to potrzebne.
                Console.WriteLine("Wprowadziłeś liczbę: " + liczba);
            }

            Console.WriteLine("Wprowadzono liczbę ujemną, program zostanie zakończony.");
        }
    }

}
