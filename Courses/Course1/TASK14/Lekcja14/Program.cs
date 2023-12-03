namespace Lekcja14
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[2];
            int a;
            tab[0] = 1;
            tab[1] = 2;
            Console.WriteLine("Przed: " + tab[0] + ", " + tab[1]);
            Test2(ref tab);
            Console.WriteLine("Po: " + tab[0] + ", " + tab[1]);
            //Console.WriteLine("Przed: " + a);
            //ref jest referencją(wskaźnikiem jak w C/C++)
            Test(out a);
            Console.WriteLine("Po: " + a);
        }

        static void Test(out int a)
        {
            a = 5;
            a += 5;
            Console.WriteLine("W funkcji: " + a);
        }
        static void Test2(ref int[] tab)
        {
            tab[0] = 555;
            tab[1] = 222;
           
            Console.WriteLine("W funkcji: " + tab[0] + ", " + tab[1]);
        }
    }
}
