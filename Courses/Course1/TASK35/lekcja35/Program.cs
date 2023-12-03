using lekcja35;

namespace lecka35
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Wynik = " + Dzielenie(5));
            }catch(DivideByFiveException e)
            {
                Console.WriteLine("Dzielisz przez pięć!!!" + e.Message);

            }
            catch(Exception e)
            {
                Console.WriteLine("Coś poszło nie tak");
            }
        }

        public static float Dzielenie(int a)
        {
            if(a == 5)
            {
                throw new DivideByFiveException("Wystąpił błąd");
            }
            return 10 / a;
        }
    }
}
