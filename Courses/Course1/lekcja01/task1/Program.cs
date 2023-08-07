// 1. Kurs C# dla początkujących - Zmienne, stałe oraz podstawowe typy danych[https://www.youtube.com/watch?v=hSHmbLxtB_Q&list=PL6aekdNhY7DAeU-2LEGBDXls60Yy-Ubbu&index=3]
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            sbyte zmienna11 = sbyte.MaxValue;
            sbyte zmienna12 = sbyte.MinValue;
            byte zmienna5 = byte.MaxValue; // od 0 do 255
            short zmienna7 = short.MaxValue; // od -32767 32767
            ushort zmienna13 = ushort.MaxValue; // jest ich 2 tyle bo są liczone od 0 nie od -32767
            int zmienna6 = int.MaxValue;
            int zmienna2 = 100;
            int zmienna3 = int.MaxValue + zmienna2;
            Console.WriteLine(zmienna3);
            long zmienna8 = long.MaxValue;
            float zmienna10 = float.MaxValue; // zmienno przecinkowe F musi miec na koncu float
            double zmienna9 = double.MaxValue;
            decimal zmienna14 = 9.21312M;
            var zmienna = int.MaxValue; //maksymalna wartość liczb całkowitych zmiennych integer.
            Console.WriteLine(zmienna);
            var zmienna4 = "Hello";

            string zmienna15 = "a";
            char zmienna16 = 'b';

            bool zmienna17 = false;
            //Console.WriteLine("Hello world!");
            Console.ReadKey();
        }
    }
}
