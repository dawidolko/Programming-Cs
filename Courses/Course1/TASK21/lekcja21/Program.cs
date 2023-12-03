using System.Globalization;
namespace lekcja21
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = CultureInfo.GetCultures(CultureTypes.AllCultures);
            //foreach(var item in c)
            //{
            //    Console.Write(item.Name);
            //    Console.WriteLine(item.NumberFormat.NumberDecimalSeparator);
            //}
            Console.WriteLine(CultureInfo.CurrentCulture.Name);
           // CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator = ";";
            var newCulture = (CultureInfo)CultureInfo.CurrentCulture.Clone();
            newCulture.NumberFormat.NumberDecimalSeparator = ";";
            CultureInfo.CurrentCulture = newCulture;
            int a = -5;
            float b = 3.14f;
            Console.WriteLine($"{a}\n {b}");
        }
    }
}
