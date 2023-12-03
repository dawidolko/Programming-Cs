using System.Collections;
using System.ComponentModel;

namespace Lekcja22
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto audi = new Auto("Audi");
            ArrayList list = new ArrayList();
            list.Add(2);
            list.Add("Bartek");
            list.Add(new Auto("BMW").Nazwa);
            Console.WriteLine(list.Count);
            list.RemoveAt(1);
            Console.WriteLine(list.Count);
            list.Insert(1, "tak");
            //pomiędzy indexami nie ma przerwy nawet jeśli usuniemy jakiś index
            //Console.WriteLine(list[2]);
            //Console.WriteLine(list[2].ToString());
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            list.Clear();
            Console.WriteLine(list.Count);

        }
    }

    class Auto
    {

        public string Nazwa { get; set; }
        public Auto(string marka)
        {
            Nazwa = marka;
        }
    }
}
