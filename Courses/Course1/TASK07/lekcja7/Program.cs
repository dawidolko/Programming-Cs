namespace Lekcja7
{
    class Program
    {
        static void Main(string[] args)
        {
            string xs, ys;
            Console.WriteLine("Proszę podać wartość x:");
            xs = Console.ReadLine();
            Console.WriteLine("Prosze podać wartość y:");
            ys = Console.ReadLine();
            int x = int.Parse(xs), y = int.Parse(ys);
            Console.WriteLine(x + " " + y);
            for (int i = 0; i < x; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            for (int i = 0; i < y - 2; i++)
            {
                Console.Write("*");
                for (int j = 0; j < x - 2; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("*");
            }
            for (int i = 0; i < x; i++)
            {
                Console.Write("*");
            }
            Random random = new Random();
            int liczba = random.Next()%10,podana;
            string podanas;
           
            Console.WriteLine("Losuję liczbę od 0 do 9 twoim zadaniem będzie zgadnięcie jej, w trakcie zgadywania będę ci podpowiadał");
            while (true)
            {
                Console.WriteLine("Podaj liczbę");
                podanas = Console.ReadLine();
                podana = int.Parse(podanas);
                if (podana == liczba)
                {
                    Console.WriteLine("udało ci się zgadnąć liczbę");
                    break;
                }
                else if (podana > liczba)
                {
                    Console.WriteLine("Podana przez ciebie liczba jest większa");
                }else
                {
                    Console.WriteLine("Twoja liczba jes mniejsza");
                }
            }
        }
    }
}
