namespace Lekcja4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            bool b = a > 0;

            if (b)
            {
                Console.WriteLine(a + " jes większe od 0");
            }
            else
            {
                Console.WriteLine(a + " nie jest większe od 0");
            }

            if (b) Console.WriteLine("Warunek jest prawdziwy"); Console.WriteLine("Warunek jest prawdziwy");

        }
    }
}
