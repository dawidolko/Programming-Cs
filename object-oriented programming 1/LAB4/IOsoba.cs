using System.Collections;

namespace Lab8; 

public interface IOsoba {
    string imie {
        get;
        set;
    }
    
    string nazwisko {
        get;
        set;
    }

    public string ZwrocPelnaNazwe();

    public static void WypiszOsoby(List<IOsoba> list) {
        Console.WriteLine("Osoby: ");
        foreach (Osoba e in list) {
            Console.WriteLine(e.ZwrocPelnaNazwe());
        }
        Console.WriteLine();
    }
    
    public static void WypiszOsoby(List<StudentUR> list) {
        Console.WriteLine("Osoby: ");
        foreach (StudentUR e in list) {
            Console.WriteLine(e.ZwrocPelnaNazweIUczelnie());
        }
        Console.WriteLine();
    }

    public static void PosortujPoNazwisku(List<IOsoba> list) {
        int records = list.Count;

        for (int i = records - 1; i > 0; i--) {               
            for (int j = 0; j < i; j++) {
                if (list[j].nazwisko.CompareTo(list[j+1].nazwisko) > 0) {
                    Osoba temp = (Osoba)list[j];
                    list[j] = list[j+1];
                    list[j+1] = temp;
                }
            }
        }
    }
}