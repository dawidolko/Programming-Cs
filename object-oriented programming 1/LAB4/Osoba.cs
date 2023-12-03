namespace Lab8; 

public class Osoba : IOsoba {
    public string imie { get; set; }
    public string nazwisko { get; set; }

    public Osoba(string imie, string nazwisko) {
        this.imie = imie;
        this.nazwisko = nazwisko;
    }

    public string ZwrocPelnaNazwe() {
        return (imie + " " + nazwisko);
    }
}