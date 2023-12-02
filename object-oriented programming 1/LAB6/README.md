# Programowanie obiektowe – C#
## WYJĄTKI
Wyjątki to problemy, które pojawiają się podczas wykonywania programu. Wyjątek C # jest
odpowiedzią na wyjątkową okoliczność, która pojawia się podczas działania programu, na przykład
próbę dzielenia przez zero.
Wyjątki umożliwiają przeniesienie kontroli z jednej części programu do innej. Obsługa wyjątków w C
# opiera się na czterech słowach kluczowych: try, catch, finally, oraz throw.

· try − Blok try identyfikuje blok kodu, dla którego aktywowane są określone wyjątki. Po nim
następuje jeden lub więcej bloków catch.

· catch − Program przechwytuje wyjątek za pomocą procedury obsługi wyjątków w miejscu
programu, w którym chcesz obsłużyć problem. Słowo kluczowe catch oznacza wyłapanie
wyjątku.

· finally − Blok finally służy do wykonania danego zestawu instrukcji, niezależnie od tego, czy
wyjątek jest zgłaszany, czy nie. Na przykład po otwarciu pliku należy go zamknąć, niezależnie
od tego, czy zgłoszony zostanie wyjątek.

· throw − Program zgłasza wyjątek, gdy pojawia się problem. Odbywa się to za pomocą słowa
kluczowego throw.

Zakładając, że blok zgłosi wyjątek, metoda wyłapuje wyjątek za pomocą kombinacji słów kluczowych
try and catch. Blok try/catch jest umieszczony wokół kodu, który może wygenerować wyjątek. Kod w
bloku try/catch jest nazywany kodem chronionym, a składnia użycia try/catch wygląda następująco:
```
try
{
// statements causing exception
}
catch (ExceptionName e1)
{
// error handling code
}
catch (ExceptionName e2)
{
// error handling code
}
catch (ExceptionName eN)
{
// error handling code
}
finally
{
// statements to be executed
}
```
Możemy wypisać wiele instrukcji catch, aby wychwycić różnego rodzaju wyjątki na wypadek, gdyby
blok try wywoływał więcej niż jeden wyjątek w różnych sytuacjach.
```
class ExceptionTestClass
{
  public static void Main()
  {
    int x = 0;
    try
    {
    int y = 100 / x;
    }
    catch (ArithmeticException e)
    {
    Console.WriteLine($"ArithmeticException Handler: {e}");
    }
    catch (Exception e)
    {
    Console.WriteLine($"Generic Exception Handler: {e}");
    }
  }
}
```
Wyjątki w C# są reprezentowane przez klasy. Klasy wyjątków w języku C # pochodzą głównie
bezpośrednio lub pośrednio z klasy System.Exception. Niektóre klasy wyjątków wyprowadzone z klasy
System.Exception to klasy System.ApplicationException i System.SystemException. Klasa
System.ApplicationException obsługuje wyjątki generowane przez aplikacje. Stąd wyjątki
zdefiniowane przez programistów powinny wywodzić się z tej klasy. Klasa System.SystemException
jest klasą bazową dla wszystkich predefiniowanych wyjątków systemowych. Poniższa tabela zawiera
niektóre z predefiniowanych klas wyjątków pochodzących z klasy Sytem.SystemException:

| L.P. | Exception Class                      | Description                                                     |
|------|--------------------------------------|-----------------------------------------------------------------|
| 1    | System.IO.IOException                | Handles I/O errors.                                             |
| 2    | System.IndexOutOfRangeException     | Handles errors generated when a method refers to an array index out of range. |
| 3    | System.ArrayTypeMismatchException    | Handles errors generated when the type is mismatched with the array type. |
| 4    | System.NullReferenceException        | Handles errors generated from referencing a null object.        |
| 5    | System.DivideByZeroException         | Handles errors generated from dividing a dividend with zero.    |
| 6    | System.InvalidCastException          | Handles errors generated during upcasting.                      |
| 7    | System.OutOfMemoryException          | Handles errors generated from insufficient free memory.        |
| 8    | System.StackOverflowException        | Handles errors generated from stack overflow.                   |

### Własne wyjątki
Aplikacje w języku C# mogą zgłaszać wyjątki systemowe lub zdefiniowane przez programistę. Wyjątki
definiowane przez programistę powinny zawierać minimalnie cztery konstruktory:

• konstruktor domyślny,

• pozwalający na ustawienie wiadomości tekstowej,

• ustawiający wiadomość tekstową,

• ustawiający wiadomość tekstową oraz wyjątek wewnętrzny,

• inicjujący nowe wystąpienie klasy klasy z serializowanych danych. (którym się na razie nie
będziemy zajmować (można pomijać))
```
public class InvalidNumberException : System.Exception
{
  public InvalidNumberException() : base() { }
  public InvalidNumberException(string message) : base(message) { }
  public InvalidNumberException(string message, System.Exception inner) :
  base(message, inner)
  { }
}
//Wykorzystanie
int DivideBy4(int a, int b)
{
  if (b != 4)
  throw new InvalidNumberException("Liczba b nie jest równa 4");
  return a / b;
}
```
### Kiedy należy zgłaszać wyjątki:

· wykonywana metoda nie może zakończyć działania w sposób poprawny realizując zlecone jej
zadanie

· niepoprawne odwołanie do obiektu biorąc pod uwagę jego stan

· argument wywołania metody powoduje wyjątek

### Kiedy **NIE** należy używać wyjątków:

· zmiana wykonania programu w przypadku poprawnego jego działania np. Obsługa natrafienia
na znak EOF podczas czytania pliku.

· sytuacja zwracania wartości funkcji.

· nie zaleca się zgłaszania wyjątków: System.Exception, System.SystemException,
System.NullReferenceException oraz System.IndexOutOfRangeException

### Zadania do samodzielnego wykonania:

### 1. 
Napisz metodę, która jako parametr będzie przyjmowała napis i wypisywała na standardowe
wyjście jego długość.

· Przekaż do tej metody null i zobacz, jaki wyjątek został zgłoszony.

· Otocz wywołanie metody blokiem try-catch, przechwyć ten wyjątek i wypisz na standardowe
wyjście ślad stosu wywołań z chwili zgłoszenia wyjątku. (StackTrace).

· Bezpośrednio po wypisaniu jego śladu zgłoś obsługiwany wyjątek ponownie.

· Dołącz obsługiwany wyjątek do nowo tworzonego wyjątku Exception jako przyczynę jego
powstania.

### 2. 
Napisz trzy nowe wyjątki oraz metodę, która za każdym wywołanie będzie losowo zgłaszała jeden
z nich.

· Otocz wywołanie tej metody instrukcją try-catch zawierającą po jednym bloku catch dla
każdego z wyjątków. Niech każdy blok catch wypisuje, który wyjątek złapała.

### 3. 
Napisz program sprawdzający, czy wyjątki zgłoszone w blokach catch mogą być obsłużone przez
ten sam blok lub jeden z pozostałych bloków tej samej instrukcji try-catch.

### 4. 
W poniższym przykładzie w bloku try jest pięć instrukcji. Każda z nich może zgłosić taki sam
wyjątek. Zaproponuj rozwiązanie, które w kodzie obsługi wyjątku pozwoli sprawdzić, w której
instrukcji on wystąpił.
```
public class SomeClass
{
  public void CanThrowException()
  {
    if (new Random().Next(5) == 0)
    throw new Exception();
  }
  }
  class Program
  {
    static void Main(string[] args)
    {
    SomeClass someClassObj = new SomeClass();
    try
    {
      someClassObj.CanThrowException();
      someClassObj.CanThrowException();
      someClassObj.CanThrowException();
      someClassObj.CanThrowException();
      someClassObj.CanThrowException();
    }
    catch (Exception e)
    {
    //jakiś kod obsługi
    }
  }
}
```
### 5. 
Zaimplementuj metodę kopiującą obiekt (Ma zostać skopiowana każda zmienna obiektu, a nie
referencja). W przypadku braku parametru (np. parametr null) należy zgłosić wyjątek ze
stosownym komunikatem. (można wykorzystać klasy zaprogramowane na poprzednich zajęciach).
### 6. 
Zmodyfikuj poprzednie zadanie tworząc własny typ danych. Następnie zaimplementuj interfejs
IClonable i wykonaj jeszcze raz zadanie pierwsze. Sprawdź działanie metody `MemberwiseClone()`.
