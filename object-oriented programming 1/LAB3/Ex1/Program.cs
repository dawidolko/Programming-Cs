using Lab7.Ex1;

class Program {
    public static void Main(string[] args) {
        var rect1 = new Rectangle();
        var cir1 = new Circle();
        var tria1 = new Triangle();

        var list = new List<Shape>();

        list.Add(rect1);
        list.Add(cir1);
        list.Add(tria1);

        for (int i = 0; i < 3; i++) {
            list[i].Draw();
        }
    }
}
