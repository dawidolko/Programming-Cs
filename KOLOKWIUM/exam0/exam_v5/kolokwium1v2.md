# Automat z przekąskami
Pewna firma sprzedaje 3 rodzaje automatów:
- **MiniMunchMachine**
    - **wymiary szer. 77 cm, gł. 81 cm, wys. 97 cm**
    - pojemność 20 produktów
    - płatnosć gotówką monety (20gr 50gr 1zł 2zł 5 zł)
    - przyciski mechaniczne do wyboru produktu (znaki A-Z)
- CompactCafe
    - wymiary szer. 80 cm, gł. 83 cm, wys. 183 cm
    - pojemność 25 produktów
    - płatnosć gotówką (50gr 1zł 2zł 5zł)
    - przyciski mechaniczne do wybotu produktu (znaki A-Z)
- MicroMarket
    - wymiary szer. 89 cm, gł. 85 cm, wys. 183 cm
    - pojemność 30 produktów
    - płatnośći kartą
    - monitor dotykowy

### Zadanie 1
Utwórz klasę **Product**. Obiekty tej klasy będą przechowywać informacje o nazwie i cenie produktu. Klasa powinna być hermetyczna. Cena nie może być ujemna a nazwa pusta. Jeśli użytkownik próbuje przypisać ujemną cenę lub pustą nazwę zwróć odpowiedni wyjątek.

Przesłoń metodę `ToString()` aby zwracała informację o produkcie.

<details>
<summary>
Wskazówki
</summary>

Hermetyzacja nie polega na samym dodaniu do pól klasy modyfikatora dostępu private oraz utworzeniu Atrybutów lub getterów i setterów. Tworząc klasę należy zadbać o to aby nie mogło dojść do sytuacji w której wartość pola jest niepoprawne. **Jeśli nie ma takiej potrzeby nie udostępniamy metody set lub get**. Tyczy się to całego kolokwium nie tylko tego zadania.

Częstym błędem jest utworzenie Atrybutu w którym wartość pola cena jest poprawnie zwalidowana natomiast w konstruktorze metody przypisują Państwo wartość bezpośrednio.

```cs
private _price

public Product(Decimal price)
{
    _price = price; // Używając konstruktora możliwe jest wpisanie ujemnej ceny TAK NIE ROBIĆ
}

public Decimal Price // używając konstruktora wpisujemy tylko poprawną cenę
{
    get { return _price; }
    set { if (value < 0)
        {
            _price = 0;
        }
        else
        {
            _price = value;
        }
        }
}
```

</details>

### Zadanie 2

Zaprojektuj abstrakcyjną klasę `AbstractVendingMachine`. Zachowaj hermetyczność klasy.
Każda klasa dziedzicząca po niej powinna mieć:
- metodę `AddProduct()` przyjmującą jako parametr obiekt klasy Product. Poszczególne implementacje metody będą się różnić w klasach dziedziczących.
- metodę `AddMoney()` przyjmującą kwotę wrzuconą przez użytkownika. Poszczególne implementacje metody będą się różnić w klasach dziedziczących.
- metodę `BuyProduct()` przyjmującą kod produktu. Poszczególne implementacje metody będą się różnić w klasach dziedziczących.
- metodę `ReturnCoins()`

<details>
<summary>
Wskazówki
</summary>

Pola wspólne wszystkich automatów to nazwa i rozmiary. 
Pracując z kodem w którym wykonuje się działania na pieniądzach należy używać typu Decimal i uważać na zaokrąglenia.

Na kolokwium zamiast klasy abstrakcyjnej w jednej z grup może pojawić się interfejs.

</details>


### Zadanie 3

Stwórz klasę konkretną `CompactCafe` dziedziczącą po AbstractVendingMachine umożliwiającą wykonanie wszystkich operacji.
- `AddMomeny()` dodaje kwotę przekazaną jako parametr funkcji do kasetki maszyny. Kwota powinna być monetą o odpowiednim nominale. jeśli spełnia założenia wartość jest zapisywana w **polu klasy**. W przeciwnym wypadku zwróć odpowiedni wyjątek.

- `BuyProduct()` metoda przyjmuje kod produktu(możliwy do wpisania na klawiaturze dostępnej w maszynie patrz wyżej). Jeśli produkt jest w maszynie i kwota wrzucona do kasetki jest wystarczająca produkt ma zostać wydany(usunięty z maszyny).

- `AddProduct()` dodaje produkt do maszyny. Metoda przyjmuje obiekty klasy produkt. Nie można też dodać nowych produktów do pełnej maszyny.

- Przeciąż metodę `AddProduct()` tak aby przyjmowała jako parametr obiekt klasy Product oraz kod(miejsce) produktu pod jakim zostanie zapisany.

- `ShowProducts()` wyświetla kody przekąsek, ich nazwę i cenę.

- `ReturnCoins()` zwraca monety wrzucone przez użytkownika. Po wywołaniu funkcji pole przechowujące liczbę monet powinno mieć wartość 0.

- Klasa powinna przechowywać cechy tego automatu(wymiary oraz nazwę) niemożliwe do zmiany po utworzeniu obiektu.

- Przesłoń metodę `ToString()` aby wypisała informację w podanym formacie gdzie nazwa automatu to NazwaAutomatu, XX to wymiary danego automatu:
```
NazwaAutomatu - szer. XX cm, gł. XX cm, wys. XX cm
```

<details>
<summary>
Wskazówki
</summary>

Klasa powinna mieć pole w którym będzie przechowywana kwota którą podaje użytkownik.

- `AddMomeny()` - nominały jakie może wrzucić użytkownik są podane w opisie maszyny. Na poprzednim kolokwium często możliwe było podanie kwoty ujemnej.

- `BuyProduct()` - użytkownik podaje kod_produktu który jest zamieniany na index w kolekcji przechowującej produkty. Pomocniczno można zrobić listę liter od A do U i wyszukać na której pozycji dany kod jest w liście a następnie użyć tego indexu do sprawdzenia czy produkt jest w kolekcji czy nie. Istnieje wiele innych metod np zamienienie znaku pobranego od użytkownika na liczbę i obliczenie pozycji. Ważne jest aby po kupieniu produktu znikł on z maszyny.

- `AddProduct()` - Metoda ma dodać produkt w pierwsze wolne miejsce jeśli takie występuje.

- `AddProduct()` - przeciążąnie to zdefiniowanie metody o tej samej nazwie ale różnych typach parametrów. Ta metoda ma dodać produkt pod kodem wybranym przez użytkownika

- `ShowProducts()` - wyświetla kody przekąsek, ich nazwę i cenę. Proszę robić to w czytelny sposób. Programy w których wyświetlany jest łańcuch w postaci "1 6 5 Product1 4" są niezrozumiałe.

- `ReturnCoins()` - wraca monety wrzucone przez użytkownika. Po wywołaniu funkcji pole przechowujące liczbę monet powinno mieć wartość 0.

- Instancje tej klasy powinny mieć nazwę oraz wymiary których użytkownik nie może zmienić.(Jeśli pola są wspólne dla wyszystkich obiektów należy użyć odpowiedniego modyfikatora.) 

</details>

### Zadanie 4

Utwórz obiekt klasy `CompactCafe`. Wypełnij maszynę produktami.

<details>

Należy utworzyć instancję klasy i wypełnić ją różnymi produktami wykorzystując stworzone metody.

</details>

### Zadanie 5 

!Na ocenę 4.0+ powinny być obsłużone wyjątki występujące w programie.

Napisz program pozwalający użytkownikowi zarządzać stanem klasy `CompactCafe` przez standardowe wejście/wyjście.

Utwórz menu umożliwiające:<br>
A. Pokaż produkty<br>
B. Wrzuć monetę<br>
C. Kup produkt<br>
D. Pokaż ilość wrzuconych pieniędzy<br>
E. Wyciąg monety<br>
F. Wyjście<br>

Program powinien mieć ukryte menu. po wpisaniu "3721" mamy możliwość dodania produktów do automatu. 

**Program powinien działać do momentu wybrania opcji wyjście z aplikacji przez użytkownika. Obdłuż wyjątki mogące wystąpić w aplikacji.**

<details>

1. Pokaż produkty

wyświetla listę produktów dostępnych w automacie. Lista powinna być czytelna i pozwolić określić jaki kod należy wprowadzić, nazwę produktu oraz cenę jaką za dany produkt zapłacimy.

2. Wrzuć monetę

Program prosi użytkownika o wpisanie wartości następnie dodaje tę wartość do automatu za pomocą odpowiedniej metody. Przy pobieraniu danych od użytkownika mogą wystąpić wyjątki.

3. Kup produkt

Program prosi użytkownika o wpisanie kodu produktu a następnie wywołuje odpowiednią metodę na obiekcie przekazując pobraną wartość. Tutaj też mogą pojawić się wyjątki. Użytkownik powinien widzieć co jest nie tak. Czy kwota jest zbyt mała czy wpisał zły kod.

4. Pokaż ilość wrzuconych pieniędzy

Wyświetla ilość pieniędzy znajdujących się w automacie. Z odpowiednią adnotacją poprzedzającą. Sama liczba w konsoli niewiele mówi.

5. Wyciąg monety

Wywołuje metodę ReturnCoins i wyświetla komunikat który infomruje użytkownika jaka kwota została zwrócona.

6. Wyjście

Wyjście z programu

Po wpisaniu kodu 3721 ukryte menu powinno pobrać od użytkownika nazwę oraz cenę produktu a następnie utworzyć nowy produkt i dodać do maszyny wykorzytując odpowiednią metodę. 

</details>

### Zadanie 6 (Na ocenę 4.0+)
Zdomyfikuj program aby zapisywał i odczytywał  historię akcji wykonywanych przez użytkownika z pliku.

## Kryteria oceny:
- Aby otrzymać ocenę 5, program powinien być poprawnie działający, dobrze zorganizowany i czytelny, oraz spełniać wszystkie wymagania zadania. Powinien przewidywać i obsługiwać sytuacje wyjątkowe.(EK_4, EK_5, EK_6)
- Należy dobrać odpowiednie struktury do problemów wystepujących w zadaniu.(EK_5)






