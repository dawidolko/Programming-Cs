namespace Ex2; 

public class Nauczyciel : Osoba {
    private string tytulNaukowy;
    private List<Uczen> listaUczniow = new List<Uczen>();

    public Nauczyciel(string imie, string nazwisko, string pesel, string tytul, List<Uczen> list) : base(imie, nazwisko, pesel) {
        tytulNaukowy = tytul;
        listaUczniow = list;
    }

    public override string GetEducationInfo() {
        return tytulNaukowy;
    }

    public override bool CanGoAloneToHome() {
        return true;
    }
    
    public void WhichStudentCanGoHomeAlone() {
        foreach (Uczen element in listaUczniow) {
            if (element.CanGoAloneToHome()) Console.WriteLine(GetFullName());
        }
    }
}