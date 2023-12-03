using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.TASK4
{

    public class Program4
    {
        public static void Wyszukiwanie()
        {
            double[] liczby = new double[10];
            double suma = 0, iloczyn = 1, srednia;
            double min = double.MaxValue, max = double.MinValue;

            Console.WriteLine("Wprowadź 10 liczb:");
            for (int i = 0; i < liczby.Length; i++)
            {
                Console.Write($"Liczba {i + 1}: ");
                liczby[i] = Convert.ToDouble(Console.ReadLine());

                suma += liczby[i];
                iloczyn *= liczby[i];

                if (liczby[i] < min)
                    min = liczby[i];
                if (liczby[i] > max)
                    max = liczby[i];
            }

            srednia = suma / liczby.Length;

            Console.WriteLine($"\nSuma elementów: {suma}");
            Console.WriteLine($"Iloczyn elementów: {iloczyn}");
            Console.WriteLine($"Średnia wartość: {srednia}");
            Console.WriteLine($"Wartość minimalna: {min}");
            Console.WriteLine($"Wartość maksymalna: {max}");
        }
    }

}
