# Automat z przekąskami
Pewna firma sprzedaje 3 rodzaje automatów:
- MiniMunchMachine
    - wymiary szer. 77 cm, gł. 81 cm, wys. 97 cm
    - waga 150kg
    - 20 rodzajów produktów
    - pojemność 500 sztuk produktów(20 szuflad po 25 produktów)
    - Rodzaje produktów: batony, napoje zimne
    - płatnosć gotówką
    - przyciski mechaniczne do wyboru produktu (liczby od 0-9)
- CompactCafe
    - wymiary szer. 80 cm, gł. 83 cm, wys. 183 cm
    - waga 250kg
    - 7 rodzajów produktów
    - pojemność 1120 sztuk produktów
    - Rodzaje produktów: kawa, cherbata
    - płatnośći kartą
    - monitor dotykowy
- MicroMarket
    - wymiary szer. 89 cm, gł. 85 cm, wys. 183 cm
    - waga 240kg
    - 65 rodzajów produktów
    - pojemność 1430 sztuk produktów(65 szuflad po 22 produkty)
    - Rodzaje produktów: długopisy, zeszyty, witaminy, suplementy diety, chusteczki, batony, chipsy, woda, soki, napoje
    - płatnośći kartą
    - monitor dotykowy

### Zadanie 1
Utwórz klasę **Product**. Obiekty tej klasy będą przechowywać informacje o nazwie, cenie, dacie ważności produktu, typie produktu. Klasa powinna być hermetyczna. Cena nie może być ujemna a nazwa pusta. Jeśli użytkownik próbuje przypisać ujemną cenę do pola klasy zwróć wyjątek. Podobnie w przypadku pól nazwa i data. Jeśli zawietają pusty łańcuch znaków zwróć wyjątek.

Przesłoń metodę `ToString()` aby zwracała informację o nazwie produktu oraz jego cenie.

### Zadanie 2

Zaprojektuj abstrakcyjną klasę `AbstractVendingMachine`. Zachowaj hermetyczność klasy.
Każda klasa dziedzicząca po niej powinna mieć:
- metodę `AddProduct()` przyjmującą jako parametr obiekt klasy Product. Poszczególne implementacje metody będą się różnić w klasach dziedziczących.
- metodę `AddMoney()` przyjmującą kwotę wrzuconą przez użytkownika. Poszczególne implementacje metody będą się różnić w klasach dziedziczących.
- metodę `SelectProduct()` przyjmującą kod produktu. Poszczególne implementacje metody będą się różnić w klasach dziedziczących.
- pola przechowujące cechy wspólne wszystkich automatów.

### Zadanie 3

Stwórz klasę konkretną `MiniMunchMachine` dziedziczącą po AbstractVendingMachine umożliwiającą wykonanie wszystkich operacji.

- `AddProduct()` dodaje produkt do maszyny. Metoda przyjmuje obiekty klasy produkt. Produkty o tej samej nazwie i cenie są przechowywane w tej samej komorze automatu. Jeśli dodajemy produkt który nie jest znany, generowany jest nowy losowy kod dla tego produktu.  Nie można dodać produktu o tej samej nazwie ale różnych cenach do automatu. Nie można też dodać nowych produktów do pełnej maszyny lub jeśli osiągnięty został limit rodzajów produktów.

- `AddMomeny()` dodaje kwotę przekazaną jako parametr funkcji do kasetki maszyny. Kwota powinna być wielkokrotnością liczby 0.10(Automat przyjmuje minimalnie monety 10gr), jeśli spełnia założenia wartość jest zapisywana w polu klasy.

- `SelectProduct()` metoda przyjmuje numer produktu. Jeśli produkt jest w maszynie i kwota wrzucona do kasetki jest wystarczająca produkt ma zostać wydany.

- Przeciąż metodę `AddProduct()` tak aby przyjmowała jako parametr obiekt klasy Product oraz kod produktu pod jakim zostanie zapisany.

- `ShowProducts()` wyświetla kody przekąsek, ich nazwę, cenę, oraz ilość w danej komorze.

- przesłoń metodę `ToString()` by zwracała informację o wszystkich polach klasy.


### Zadanie 4

Utwórz obiekt klasy `MiniMunchMachine` a nastpęnie wypełnij maszynę różnymi generowanymi losowo produktami. 

### Zadanie 5
Napisz program pozwalający użytkownikowi zarządzać stanem klasy `MiniMunchMachine` przez standardowe wejście/wyjście.

Na początku działania programu wyświetl informację o obiekcie za pomocą metody `ToString()`.

Utwórz menu umożliwiające:
- Dodanie przekąski do automatu
- Wrzucenie monet
- Zakupienie produktu
- Wyświetlenie produktów
- Wyświetlenie informacji o automacie
- Wyjście z aplikacji

Historia działań użytkownika powinna zapisywać się do pliku log.txt

Program powinien działać do momentu wybrania opcji wyjście z aplikacji przez użytkownika. Obdłuż wyjątki mogące wystąpić w aplikacji.

## Kryteria oceny:
- Aby otrzymać ocenę 5, program powinien być poprawnie działający, dobrze zorganizowany i czytelny, oraz spełniać wszystkie wymagania zadania. Powinien przewidywać i obsługiwać sytuacje wyjątkowe.(EK_4, EK_5, EK_6)
- Należy dobrać odpowiednie struktury do problemów wystepujących w zadaniu.(EK_5)






