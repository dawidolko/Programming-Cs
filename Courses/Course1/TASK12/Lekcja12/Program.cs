namespace Lekcja12
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 432, b = 123;
            Dodaj(a, b);
            Dodaj(a, b, a, b);
            Dodaj(a, b, a);
            //można użyć etykiet
            Dodaj(b: a, a: b);
        }

        static void Dodaj(int a, int b)
        {
            Console.WriteLine(a + " + " + b + " = " + (a + b));
        }
        static void Dodaj(int a, int b, int c, int d)
        {
            Console.WriteLine(a + " + " + b + " + " + c + " + " + d + " = " + (a + b + d + c));
        }
        static void Dodaj(int a = 0, int b = 0, int c = 0)
        {
            Console.WriteLine(a + " + " + b + " + " + c +  " = " + (a + b  + c));
        }
    }
}
