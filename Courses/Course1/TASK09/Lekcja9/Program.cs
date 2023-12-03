namespace Lekcja9
{
    class Program
    {
        static void Main(string[] args)
        {
            int liczba;
            Console.WriteLine("Podaj wartość: ");
            liczba = int.Parse(Console.ReadLine());

            switch (liczba)
            {
                case 0:
                    Console.WriteLine("Wybrano 0");
                    break;
                case 1:
                    Console.WriteLine("Wybrano 1");
                    break;
                default:
                    Console.WriteLine("Wybrano coś innego");
                    break;
            }
        }
    }
}
