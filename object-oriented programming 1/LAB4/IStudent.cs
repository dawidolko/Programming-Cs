namespace Lab8; 

public interface IStudent : IOsoba {
    string uczelnia { get; set; }
    string kierunek { get; set; }
    int rok { get; set; }
    int semestr { get; set; }
}