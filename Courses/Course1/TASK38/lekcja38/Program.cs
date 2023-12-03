using System.Diagnostics;

namespace lekcja38
{
    class Program
    {
        static void Main(string[] args)
        {
            const int LICZBA = 20;
            Console.WriteLine("Czas bez rekurencji:\n");
            Stopwatch sw = Stopwatch.StartNew();
            sw.Start();
            Console.WriteLine(Silnia(LICZBA));
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks+"\n");
            Console.WriteLine("Czas z rekurencją:");
            sw.Reset();
            sw.Start();
            Console.WriteLine(SilniaR(LICZBA));
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks + "\n");
        }

        private static long SilniaR(int x)
        {
            if (x > 1)
            {
                return Silnia(x - 1)*x;
            }else
            {
                return 1;
            }
        }

        private static long Silnia(int x)
        {
            long wynik = 1;
            while( x > 1)
            {
                wynik *= x;
                x--;
            }
            return wynik;
        }
    }
}
