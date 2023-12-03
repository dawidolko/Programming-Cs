namespace lekcja24
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dictonary = new Dictionary<int, string>();
            dictonary.Add(1, "Ania");
            dictonary.Add(2, "Bartek");
            Console.WriteLine(dictonary.Count);
            foreach (var item in dictonary)
            {
                Console.WriteLine("{0} : {1}", item.Key, item.Value);
            }
        }
    }
}
