namespace Lekcja10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tablica = new int[365];
            string[] dni = { "poniedziałek", "wtorek", "środa", "czwartek", "piątek", "sobota", "niedziela" };
            for(int i = 0; i < dni.Length; i++)
            {
                Console.WriteLine(dni[i]);
            }
           
           

        }
    }
}
