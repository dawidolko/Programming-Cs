namespace lekcja33
{
    class Program
    {

        enum PoryRoku : long
        {
            //każda zmienna jest numerowana domyślnie od 0
            Wiosn , Lato, Jesień, Zima
        }

        static void Main(string[] args)
        {   //można też rzutować liczby na typ enum
            PoryRoku pory = (PoryRoku)1;
            //można przeżutować enum na int
            Console.WriteLine(pory);
        }
    }
}
