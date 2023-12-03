using Lab9.Ex2;
using Lab9.Ex5;

internal class Program {
    public static void Main(string[] args) {
        
        Console.WriteLine();
        //Ex.1
        try {
            Length(null);
        }
        catch (NullReferenceException e) {
            Console.WriteLine(e.StackTrace);
            //throw new NullReferenceException();
        }
        
        
        //Ex.2
        Console.WriteLine();
        try {
            RandomException();
        } catch (Exception1 e1) {
            Console.WriteLine("Exception1");
        } catch (Exception2 e2) {
            Console.WriteLine("Exception2");
        } catch (Exception3 e3) {
            Console.WriteLine("Exception3");
        }
        
        //Ex. 3
        Console.WriteLine();
        Ex3(); //False
        
        //Ex. 4
        Console.WriteLine();
        //Console.WriteLine(e.StackTrace());
        
        //Ex.5
        Console.WriteLine();
        var p1 = new Person("Jan", "Kowalski", 33);
        var p2 = clonePerson(p1);
        var p3 = p2.Clone();
    }
    
    public static void Length(string text) {
        Console.WriteLine(text.Length);
    }

    public static void RandomException() {
        Random rand = new Random();
        int number = rand.Next(1, 3);

        switch (number) {
            case 1:
                throw new Exception1("Excepion1");
                break;
            case 2:
                throw new Exception2("Exception2");
                break;
            case 3:
                throw new Exception2("Exception3");
                break;
        }
    }

    public static void Ex3() {
        try {
            Console.Write("Wpisz index: ");
            int number = Int32.Parse(Console.ReadLine());
            int[] tab = new int[3];
            Console.WriteLine(tab[number]);
        }
        catch (IndexOutOfRangeException e) {
            Length(null);
        }
        catch (NullReferenceException e) {
            Console.WriteLine("Przechwyciłem z catcha!");
        }
    }

    public static Person clonePerson(Person toClone) {
        var p = new Person();
        p.FirstName = toClone.FirstName;
        p.LastName = toClone.LastName;
        p.Age = toClone.Age;
        return p;
    }

}