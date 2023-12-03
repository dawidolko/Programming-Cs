namespace lekca27
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto auto1 = new Auto("FIAT", 1999);
            Auto auto2 = new Auto("MERCEDES", 1995);
            Auto auto3 = new Auto("BMW", 2000);
            Auto auto4 = new Auto("FIAT", 1989);
            Auto auto5 = new Auto("SKODA", 2015);
            List<Auto> list = new List<Auto>();
            list.Add(auto1);
            list.Add(auto2);
            list.Add(auto3);
            list.Add(auto4);
            list.Add(auto5);

            list.Sort(new AutoComparer());

            foreach (var item in list)
            {
                Console.WriteLine(item.Rocznik + " - " + item.Model);
            }
        }
    }
    class AutoComparer : IComparer<Auto>
    {
        public int Compare(Auto? x, Auto? y)
        {
            if (x.Rocznik > y.Rocznik)
                return 1;
            else if (x.Rocznik == y.Rocznik)
                return 0;
            else return -1;
        }
    }

    class Auto : IComparable
    {
        public String Model { get; set; }
        public int Rocznik { get; set; }
        public Auto(string Model, int Rocznik)
        {
            this.Model = Model;
            this.Rocznik = Rocznik;
        }

        public int CompareTo(object? obj)
        {
            var arg = (Auto)obj;

            if (Rocznik < arg.Rocznik)
                return 1;
            else if (Rocznik == arg.Rocznik)
                return 0;
            else return -1;
        }
    }

}
