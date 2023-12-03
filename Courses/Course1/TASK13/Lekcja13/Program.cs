namespace Lekcja13
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Dodaj(2,4);
            Console.WriteLine("Wynik dodawania wynosi " + a);
        }

        static int Dodaj(int a, int b)
        {
            return a+b;
        }
    }
}