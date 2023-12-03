using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.TASK5
{
    public class Program5
    {
        public static void Wyswietlanie()
        {
            for (int i = 20; i >= 0; i--)
            {
                if (i == 2 || i == 6 || i == 9 || i == 15 || i == 19)
                {
                    continue; // Pomiń wybrane liczby
                }
                Console.WriteLine(i);
            }
        }
    }

}
