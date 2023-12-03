
namespace Lab8; 

class Program {
    public static void Main(string[] args) {
        var os1 = new Osoba("Anna", "Kowalska");
        var os2 = new Osoba("Malwina", "Szumska");
        var os3 = new Osoba("Piotr", "Adamicki");
        var os4 = new Osoba("Daniel", "Fart");

        var list = new List<IOsoba>();
        list.Add(os1);
        list.Add(os2);
        list.Add(os3);
        list.Add(os4);

        IOsoba.WypiszOsoby(list);

        IOsoba.PosortujPoNazwisku(list);
        
        IOsoba.WypiszOsoby(list);
        
        var sur1 = new StudentUR("Michał", "Pilecki", "UR", "INF", 2021, 3);
        var sur2 = new StudentUR("Dawid", "Olko", "UR", "MAT", 2021, 3);
        var sur3 = new StudentUR("Łucja", "Nowak", "UR", "MECH", 2019, 6);
        var sur4 = new StudentUR("Ewa", "Dzik", "UR", "MAT", 2021, 4);

        var list2 = new List<StudentUR>();
        list2.Add(sur1);
        list2.Add(sur2);
        list2.Add(sur3);
        list2.Add(sur4);
        
        IOsoba.WypiszOsoby(list2);
    }
}