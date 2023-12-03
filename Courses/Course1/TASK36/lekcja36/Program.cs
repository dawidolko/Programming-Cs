namespace lekcja36
{
    class Program
    {
        static void Main(string[] args)
        {
            Zwierze zwierze = new Zwierze();
            Kot kot = new Kot();
            Console.WriteLine("Zwierze:");
            zwierze.DajGlos();
            Console.WriteLine("Kot:");
            kot.DajGlos();
            kot.PijMleko();
            //zwierze = new Kot();

            Console.WriteLine("Czy kot jest kotem?");
            if (kot is Kot)
            {
                Console.WriteLine("Powiodło się");
            }
            else
            {
                Console.WriteLine("Nie powiodło się");
            }
            Console.WriteLine("Czy zwierze jest kotem?");
            if (zwierze is Kot)
            {
                Console.WriteLine("Powiodło się");
            }
            else
            {
                Console.WriteLine("Nie powiodło się");
            }

            //Kot kot3 = (Kot)zwierze;
            Kot kot2 = zwierze as Kot;

            if (!(kot2 == null))
            {
                Console.WriteLine("Powiodło się");
            }else
            {
                Console.WriteLine("Nie powiodło się");
            }
            //kot2.PijMleko(); nie ma tej metody gdyż kot2 powstał na bazie zwierze

        }
    }
}
