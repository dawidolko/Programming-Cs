namespace Lekcja8
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            while (true)
            {
                Console.WriteLine(a);
                if (a == 10)
                {
                    break; //break przerywa działanie pętli/switcha
                    //continue; continue przechodzi w tym momencie do kolejnego uzcia pętli więc po osiągnieciu 1000 pętla nie będzie powiększać a tylko będzie w nieskończoność wypisywać wartość a
                }
                a++;
            }
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {

                    continue;
                }
                Console.WriteLine(i);
            }
            int b = 0;

        jeden:
            Console.WriteLine("Jedne");
        dwa:
            Console.WriteLine("dwa");

        trzy:
            Console.WriteLine("trzy");
            b++;

            if (b < 10)
            {
                goto jeden;
            }

        }
    }
}
