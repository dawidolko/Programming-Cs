namespace Ex2; 

public abstract class Osoba {
    private string imie, nazwisko, pesel;

    public Osoba(string imie, string nazwisko, string pesel) {
        this.imie = imie;
        this.nazwisko = nazwisko;
        this.pesel = pesel;
    }

    public void SetFirstName(string name) {
        this.imie = name;
    }
    
    public void SetLastName(string lname) {
        this.nazwisko = lname;
    }
    
    public void SetPesel(string pes) {
        this.pesel = pes;
    }

    public int GetWiek() {
        string year = this.pesel[0].ToString() + this.pesel[1].ToString();
        int old = int.Parse(year);
        int result;
        
        if (old > 22) result = (100-old) + 22;
        else result = 22 - old;

        string s = this.pesel;

        int status = int.Parse(pesel[2].ToString());
        
        if (status > 0) result += 100;
        
        return result;
    }

    public string GetGender() {

        string num = pesel[9].ToString();
        string result;

        if (int.Parse(num) % 2 == 0) result = "Kobieta";
        else result = "Mezczyzna";
        
        return result;
    }

    public string GetFullName() {
        return imie + " " + nazwisko;
    }
    
    public abstract string GetEducationInfo();
    public abstract bool CanGoAloneToHome();
}