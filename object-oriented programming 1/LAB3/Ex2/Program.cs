
using Ex2;

class Program {
    public static void Main(string[] args) {
        var pupil = new Uczen("Kamil", "Fof", "01021533675", "ZST");

        Console.WriteLine(pupil.GetWiek());
    }
}