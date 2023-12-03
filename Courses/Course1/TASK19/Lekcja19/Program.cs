namespace Lekcja19
{
    class Program
    {
        static void Main(string[] args)
        {
            string tekst = GenerujTekst("Mam na imię #0 i mam #1 lat", "Adam", 22);
            Console.WriteLine(tekst);
        }
        //params przyjmuje nieograniczoną liczbę parametrów i musi być zawsze ostatni
        public static string GenerujTekst(string tekst, params object[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                tekst = tekst.Replace("#" + i, args[i].ToString());
            }
            return tekst;
        } 
    }
}