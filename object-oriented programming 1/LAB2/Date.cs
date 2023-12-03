public class Date { 
    private int year, month, day;

    public Date(int year, int month, int day) {
        this.year = year;
        this.month = month;
        this.day = day;
    }

    public void AddWeek() {
        if (this.day+7>30) {
            this.day = (this.day + 7) - 30;
            this.month++;
        } else this.day += 7;
    }

    public void SubtractWeek() {
        if (this.day - 7 < 1) {
            this.day = (this.day - 7) + 30;
            this.month--;
        }
        else this.day -= 7;
    }

    public void print() {
        Console.WriteLine(this.year + "-" + this.month + "-" + this.day);
    }
}
