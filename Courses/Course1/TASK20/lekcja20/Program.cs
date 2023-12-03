using System.Diagnostics;
using System.Text;

namespace Lekcja20
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            int ile = 10000000;
            stopwatch.Start();
            string tekst = BudujString(ile);
            
            stopwatch.Stop();
            Console.WriteLine("Operator konatenacji: {0}ms",stopwatch.ElapsedMilliseconds);
            stopwatch.Reset();
            stopwatch.Start();
            string tekst2 = BudujStringBuilder(ile);
            stopwatch.Stop();
            Console.WriteLine("Builder: {0}ms",stopwatch.ElapsedMilliseconds);
            
        }
        /// <summary>
        /// Metoda buduje string
        /// </summary>
        /// <param name="ile">Podaj długość pętli</param>
        /// <returns>Zwracamy gotowy tekst</returns>
        public static string BudujString(int ile)
        {
            string tekst = "";
            for (int i = 0; i < ile; i++)
            {
                tekst += i;
            }
            return tekst;
        }
        
        public static string BudujStringBuilder(int ile)
        {
            string tekst = "";
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < ile; i++)
            {
                stringBuilder.Append(i);
            }
            tekst = stringBuilder.ToString();
            return tekst;
        }
    }
}
