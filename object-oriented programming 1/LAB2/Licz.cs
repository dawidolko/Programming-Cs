public class Licz {
    private double number = 9.1;

    public Licz(double number) {
        this.number = number;
    }

    public double Dodaj(double x) { 
        return this.number+x;
    }

    public double Odejmij(double x) {
        return this.number-x;
    }

    public void Show() {
        Console.WriteLine("Liczba wynosi " + this.number);
    }
}