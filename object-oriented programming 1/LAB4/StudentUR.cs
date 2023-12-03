namespace Lab8; 

public class StudentUR : Student {
    
    public StudentUR(string imie, string nazwisko, string uczelnia, string kierunek, int rok, int semestr) : base(imie, nazwisko, uczelnia, kierunek, rok, semestr) {
        this.imie = imie;
        this.nazwisko = nazwisko;
        this.uczelnia = uczelnia;
        this.kierunek = kierunek;
        this.rok = rok;
        this.semestr = semestr;
    }
}