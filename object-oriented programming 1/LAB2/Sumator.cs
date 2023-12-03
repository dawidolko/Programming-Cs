public class Sumator {
    private double[] liczby;

    public Sumator(double[] tab) {
        this.liczby = tab;
    }

    public double Suma() {
        double sum = 0;

        for (int i = 0; i < liczby.Length; i++) sum += liczby[i];

        return sum;
    }

    public double SumaPodziel2() {
        double sum = 0;

        for (int i = 0; i < liczby.Length; i++) if(liczby[i]%2==0) sum += liczby[i];

        return sum;
    }

    public int IleElementow() {
        return liczby.Length;
    }

    public void show() { 
        for (int i=0;i<liczby.Length;i++) Console.Write(liczby[i] + " "); 
    }

    public void printingByIndexes(int lowIndex, int highIndex) {
        for (int i=0;i<liczby.Length;i++) {
            if (i >= lowIndex && i <= highIndex) Console.Write(liczby[i] + " ");
        }
    }

}
