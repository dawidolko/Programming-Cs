namespace Lab8;

public class Student : IStudent {
    public string imie { get; set; }
    public string nazwisko { get; set; }
    public string uczelnia { get; set; }
    public string kierunek { get; set; }
    public int rok { get; set; }
    public int semestr { get; set; }

    public Student(string imie, string nazwisko, string uczelnia, string kierunek, int rok, int semestr) {
        this.imie = imie;
        this.nazwisko = nazwisko;
        this.uczelnia = uczelnia;
        this.kierunek = kierunek;
        this.rok = rok;
        this.semestr = semestr;
    }

    public string ZwrocPelnaNazwe() {
        return (imie + " " + nazwisko);
    }
    
    public string ZwrocPelnaNazweIUczelnie() {
        return (imie + " " + nazwisko + " - " + semestr + kierunek + " " + rok + " " + uczelnia);
    }
}