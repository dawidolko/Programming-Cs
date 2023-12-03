namespace Lekcja5
{
    class Program
    {
        static void Main(string[] args)
        {
            //ctrl+k i potem ctrl+d układa kod
            //zamiana w komentarz ctrl+k i potem ctrl+c
            //odkomentowanie ctrl+k potem ctrl+u
            //f5 do kompilacji
            //cw do wypisywania w kosoli


            //RZUTOWANIE ZMIENNYCH
            int i = int.MaxValue;
            double d = 5.1;

            i = (int)d;
            Console.WriteLine(i);

            //WCZYTYWANIE DANYCH Z KONSOLI
            //string s = Console.ReadLine();
            //Console.WriteLine(s);
            if (Console.ReadKey().Key == ConsoleKey.D1)
            {
                Console.WriteLine("Prawda");
            }
            else
            {
                Console.WriteLine("Fałsz");
            }
            string s = Console.ReadLine();
            int i2 = int.Parse(s) + 2;
            s = i2.ToString();
            Console.WriteLine(s);
            string s1 = "Witaj";
            string s2 = " Świecie";
            //string s3 = s1 + s2;
            Console.WriteLine(s1 + s2 + "!!\n{0}{1}", s1, s2);

            //MODYFIKACJA WYGLĄDU KONSOLI
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.White;
            
            Console.WriteLine("TEKST");
            Console.ResetColor();
            Console.Clear();
        }
    }
}
