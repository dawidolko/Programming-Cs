using System.Diagnostics;

namespace Lekcja3
{
    class Program
    {
        static void Main(String[] args)
        {
            float a = 2, b = 3, c;
            c = a + b;
            Console.WriteLine("Wyinik dodawania "+a+" + "+b+" = "+c);
            c = a - b;
            Console.WriteLine("Wynik odejmowania " + a + " - " + b + " = " + c);
            c = a * b;
            Console.WriteLine("Wynik mnożenia " + a + " * " + b + " = " + c);
            c = a / b;
            Console.WriteLine("Wynik dzielenia " + a + " / " + b + " = " + c);
            c = a % b;
            Console.WriteLine("Wynik dzielenia dzelenia " + a + " % " + b + " = " + c);
            bool d = true, e = false, f;
            int wynik = 2 + 2 * 2;
            Console.WriteLine("Wynik działania 2 + 2 * 2  = " + wynik);
            f = d && e;
            Console.WriteLine("Prawda i Fałsz wynosi " + f);
            f = d || e;
            Console.WriteLine("Prawda lub Fałsz wynosi " + f);
            c = a - b;
            c=Math.Abs(c);
            Console.WriteLine("Wartość bezwględna z " + a +" - " + b + " = " + c);
            double t = Math.Pow(a, b);
            Console.WriteLine("Liczba " + a + " do potęgi " + b + " wynosi " + t);
        }
    }
}
