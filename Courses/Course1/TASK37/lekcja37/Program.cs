namespace lekcja37
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw;
            string path = "C:\\Users\\micha\\Desktop\\strona_internetowa\\nauka\\C#\\lekcja37\\text.txt"; //żeby używać pojedyńczych \ trzeba przed stringiem użyć @
            string path2 = @"text.txt";
            if (File.Exists(path2))
            {
                 sw = new StreamWriter(path,true);//dodanie wartości true ustawia plik do dopisywania informacji
                

            }else
            {
                Console.WriteLine("Plik nie istnieje");
                
                sw = File.CreateText(path2);
                Console.WriteLine("Plik został utworzony");
            }
            Console.WriteLine("Podaj tekst:");
            string tekst = Console.ReadLine();
            sw.WriteLine(tekst);
            sw.Close();

            StreamReader sr = File.OpenText(path);
            string s = "";
            int i = 1;
            Console.WriteLine("\nZAWARTOŚĆ PLIKU:");
            while((s = sr.ReadLine()) != null)
            {
                Console.WriteLine(i++ + ". " + s);
            }
            sr.Close();

        }
    }
}
