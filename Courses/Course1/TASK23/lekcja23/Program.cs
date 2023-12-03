namespace lekcja23
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Auto> list = new List<Auto>();
            Auto bmw = new Auto("BMW");
            Auto ford = new Auto("Ford");
            Auto audi = new Auto("Audi");
            list.Add(bmw);
            list.Add(audi);
            list.Add(ford);

            foreach (Auto item in list)
            {
                Console.WriteLine(item.Nazwa);
            }
        }
    }

    class Auto
    {
        public string Nazwa { get; set; }
        public Auto(string nazwa)
        {
            this.Nazwa = nazwa;
        }
        public void UruchomSilnik()
        {
            Console.WriteLine("Uruchomiono silnik " + Nazwa);
        }
    }
}