using System;
using Lab5.TASK1;
using Lab5.TASK1.Lab5.TASK1;
using Lab5.TASK2;
using Lab5.TASK3;
using Lab5.TASK4;
using Lab5.TASK5;

class Program
{
    static void Main(string[] args)
    {

        //ZADANIE 1
        Console.WriteLine("\n\nZADANIE: 1\n\n");

        try
        {
            StringUtilities.PrintStringLength(null);
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine(ex.StackTrace);
            // Zgłaszanie wyjątku ponownie nie jest tutaj potrzebne, jeśli chcemy tylko wydrukować StackTrace
        }
        catch (Exception ex)
        {
            Console.WriteLine("StackTrace: " + ex.StackTrace);
            throw new Exception("Nowy wyjątek z oryginalnym wyjątkiem jako przyczyną", ex);
        }

        //ZADANIE 2
        Console.WriteLine("\n\nZADANIE: 2\n\n");

        try
        {
            ExceptionThrower.ThrowRandomException();
        }
        catch (FirstCustomException ex)
        {
            Console.WriteLine("Caught an exception: " + ex.Message);
        }
        catch (SecondCustomException ex)
        {
            Console.WriteLine("Caught an exception: " + ex.Message);
        }
        catch (ThirdCustomException ex)
        {
            Console.WriteLine("Caught an exception: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An unexpected exception occurred: " + ex.Message);
        }

        //ZADANIE 3
        Console.WriteLine("\n\nZADANIE: 3\n\n");

        SomeClass someClassObj = new SomeClass();
        try
        {
            someClassObj.CanThrowException(1);
            someClassObj.CanThrowException(2);
            someClassObj.CanThrowException(3);
            someClassObj.CanThrowException(4);
            someClassObj.CanThrowException(5);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        //ZADANIE 4
        Console.WriteLine("\n\nZADANIE: 4\n\n");

        static DeepCopyableItem CopyObject(DeepCopyableItem original)
        {
            if (original == null)
            {
                throw new ArgumentNullException("original", "Parametr nie może być null.");
            }

            return original.DeepCopy();
        }

        try
            {
                DeepCopyableItem originalItem = new DeepCopyableItem(123, "Przykładowy tekst");
                DeepCopyableItem copiedItem = CopyObject(originalItem);

                Console.WriteLine("Oryginalny obiekt:");
                Console.WriteLine($"NumberValue: {originalItem.NumberValue}, TextValue: {originalItem.TextValue}");

                Console.WriteLine("Skopiowany obiekt:");
                Console.WriteLine($"NumberValue: {copiedItem.NumberValue}, TextValue: {copiedItem.TextValue}");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"Błąd: {ex.Message}");
            }
        

        //ZADANIE 5
        Console.WriteLine("\n\nZADANIE: 5\n\n");

        CustomDataType original = new CustomDataType(123, "Przykładowy tekst");
        CustomDataType copy = (CustomDataType)original.Clone();

        Console.WriteLine("Oryginalny obiekt:");
        Console.WriteLine($"NumberValue: {original.NumberValue}, TextValue: {original.TextValue}");

        Console.WriteLine("Skopiowany obiekt:");
        Console.WriteLine($"NumberValue: {copy.NumberValue}, TextValue: {copy.TextValue}");

        // Sprawdzenie, czy referencje są różne (powinny być, ponieważ MemberwiseClone tworzy płytką kopię)
        Console.WriteLine($"Czy to ten sam obiekt: {ReferenceEquals(original, copy)}");
        Console.WriteLine($"Czy to ta sama wartość TextValue: {ReferenceEquals(original.TextValue, copy.TextValue)}");


        //ZADANIE 6
        Console.WriteLine("\n\nZADANIE: 6\n\n");

        var myList = new Lab5.TASK6.MyList<int>();
        myList.Add(1);
        myList.Add(2);
        myList.Add(3);
        myList.Add(4);
        myList.Add(5);

        Console.WriteLine("Lista liczb parzystych:");
        for (int i = 0; i < 5; i++)
        {
            if (myList[i] % 2 == 0)
            {
                Console.WriteLine(myList[i]);
            }
        }
    }

    private static SomeClass CopyObject(SomeClass original)
    {
        throw new NotImplementedException();
    }
}
