namespace lekcja5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pętla for");
            for (int a = 0; a < 100; a++)
            {
                Console.WriteLine(a);
            }
            int i = 0;
            Console.WriteLine("Pętla while");
            while (i < 100)
            {
                Console.WriteLine(i);
                i++;
            }
            i = 0;
            Console.WriteLine("Pętla do while");
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i < 100);
            Console.WriteLine("Pętla for przerwanie po 5");
            for(int a = 0; a < 100; a++)
            {
                Console.WriteLine(a);
                if(a== 5)
                {
                    break;
                }
            }
            Console.WriteLine("Wypisywanie liczb nie parzystych");
            for(int a = 0; a < 100; a++)
            {
                Console.WriteLine(a);
                if (a % 2 == 0)
                {
                    continue;
                }
            }
        }
    }
}