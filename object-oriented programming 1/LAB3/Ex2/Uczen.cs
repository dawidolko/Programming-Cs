namespace Ex2; 

public class Uczen : Osoba {
    private string szkola;
    private bool mozeSamWracacDoDomu;

    public Uczen(string imie, string nazwisko, string pesel, string szkola) : base(imie, nazwisko, pesel) {
        this.szkola = szkola;
        SetCanGoAloneToHome();
    }
    
    public void SetSchool(string school) {
        this.szkola = school;
    }

    public void ChangeSchool(string sch) {
        this.szkola = sch;
    }

    public override string GetEducationInfo() {
        return szkola;
    }

    public override bool CanGoAloneToHome() {
        return mozeSamWracacDoDomu;
    }

    public void SetCanGoAloneToHome() {
        int yearOld = GetWiek();

        if (yearOld < 12) mozeSamWracacDoDomu = false;
        else mozeSamWracacDoDomu = true;
    }
}