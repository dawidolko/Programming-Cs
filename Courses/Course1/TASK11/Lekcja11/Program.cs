namespace Lekcja11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] tab = new int[2,3];
            for(int i = 0; i < 2; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    tab[i, j] = 1;
                    Console.WriteLine(tab[i,j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine(tab.GetLength(1));

            int[][] tab2 = new int[2][];
            tab2[0] = new int[3];
            tab2[1] = new int[2];
            tab2[0][2] = 123;
            tab2[1][1] = 120;
            for(int i = 0; i < tab2.Length; i++)
            {
                for(int j = 0; j < tab2[i].Length; j++)
                {
                    Console.WriteLine(tab2[i][j]);
                }
                Console.WriteLine();
            }
            int[] tab3 = new int[3];
            tab3[0] = 5;
            tab3[1] = 25;
            tab3[2] = 15;
            Console.WriteLine(tab3.Max());
            Console.WriteLine(tab3.Min());
            Console.WriteLine(tab3.Sum());

            Array.Sort(tab3);
            for(int i = 0; i < tab3.Length; i++)
            {
                Console.WriteLine(tab3[i]);
            }
            Array.Reverse(tab3);
            for (int i = 0; i < tab3.Length; i++)
            {
                Console.WriteLine(tab3[i]);
            }

            

        }

    }
}
