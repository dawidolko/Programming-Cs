namespace Lekcja16
{
    internal class Czlowiek
    {
        public Czlowiek(string imie, string nazwisko)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
        }
        public Czlowiek()
        {
            Console.WriteLine("Imię i nazwisko zostało ustawione na domyślne");
        }
        public string imie = "Adrian", nazwisko = "Kowalski";

        public void PrzedstawSie()
        {
            Console.WriteLine("Mam na imię " + this.imie + "\nMam na nazwisko " + this.nazwisko);
        }
        ~Czlowiek()
        {
            System.Diagnostics.Trace.WriteLine("Jestem destruktorem");
        }

    }
}
