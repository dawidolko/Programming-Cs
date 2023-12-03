using System.Linq.Expressions;

namespace lekcja34
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(Dzielenie(10,0));
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("Dzielisz przez 0");
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("O nie coś poszło nie tak");
                Console.WriteLine(e.Message);

            }
            finally
            {
                Console.WriteLine("Program skończył działanie");
            }
            
            
        }
       
        public static float Dzielenie(int a, int b)
        {
            if(b == 5)
            {
                throw new Exception("Nigdy nie dziel przez 5");
            }
            return a / b;
        }
    }
}
