namespace lekcja24
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto auto1 = new Auto("FIAT", 1999);
            Auto auto2 = new Auto("FIAT", 1999);
            Console.WriteLine(auto1.Equals(auto2));
        }
    }

    class Auto
    {
        public string Model { get; set; }
        public int Rocznik { get; set; }
        public Auto(string Model, int Rocznik)
        {
            this.Rocznik = Rocznik;
            this.Model = Model;
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }
        
        public bool Equals(Auto auto)
        {
            return auto.Model == this.Model && auto.Rocznik == this.Rocznik;
        }
    }
}