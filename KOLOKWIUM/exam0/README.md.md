Zagadnienia C#:

### Tworzenie typów wyliczeniowych i przykłady ich wykorzystania. 

<details>
<summary>
Utwórz typ wyliczeniowy dla różnych stanów transakcji bankowej.
</summary>

Należy potrafić wykorzytsać stworzony typ np. w instrukcjach switch i if wiedząc że pod danymi nazwami kryją się liczby.

</details><br>

### Definiowanie klasy i ich instancji(obiektów) zgodnie z zasadami enkapsulacji(hermetyzacji).

<details>
<summary>
Utwórz klasę reprezentującą Produkt.
</summary>

Każdy produkt ma pewne cechy takie jak nazwa, cena, wielkość itp. które są reprezentowane przez pola klasy. Hermetyzacja polega na ukrywaniu pewnych składowych klasy pól/metod tak aby inne klasy lub użytkownik tworzacy instancję danej klasy mógł użyć jej tylko w poprawny sposób. Np. cena produktu powinna być wartością dodatnią. Zatem pole cena powinno być prywatne i zdefiniowane w ten sposób aby można było do niego przypisać tylko poprawne wartości. 

https://codeeasy.io/lesson/properties

</details><br>

### Definiowanie interfejsów.

<details>
<summary>
Utwórz interfejs dla automatów z przekąskami.
</summary>

Interfejs mówi co dana klasa powinna zrobić, nie w jaki sposób. Interfejs zawiera deklaracje metody bez ich implementacji. W nowszych wersjach Java i C# możliwa jest domyślna implementacja interfejsu wtedy klasa nie musi implementować danej metody.

</details><br>


### Definiowanie klas abstrakcyjnych

<details>
<summary>
Utwórz klasę abstrakcyjną reprezentującą automat.
</summary>

Mając różne automaty: Automat z przekąskami, Automat do gier, Automat z napojami można wyróżnić w nich pewną część wspólną czyli metodę płacenia polegającą na wrzuceniu monety, wybraniu produktu a następnie wydaniu reszty. Zatem definiując wspólny interfejs dla tych automatów implementacja metod za wrzucenie monety, wybranie produktu i wydanie reszty będzie taka sama. Rozwiązaniem tego problemu jest klasa abstrakcyjna która będzie implementować wspólny "moduł" płacenia. 

Nie można tworzyć instancji Klasy(tworzyć obiektów).

</details><br>

### Dziedziczenie i polimorfizm

<details>
<summary>
Utwórz klasę SnackMachine dziedziczącą po klasie Automat. 
</summary>

W Java i C# możliwe jest dziedziczenie po jednej klasie i implementacja wielu interfejsów.

Polimorfizm pozwala na wykorzystanie różnych implementacji metod dla różnych typów obiektów, np. wykorzystanie jednego interfejsu do obsługi różnych typów plików.

</details><br>

### Zapis i odczyt z plików

<details>
<summary>
Zmodyfikuj klasę SnackMachine by zapisywała historię operacji wykonywanych przez użytkonika do pliku.
</summary>

</details><br>

### Struktury danych

Złożoność obliczeniowa struktur danych:
https://learn.microsoft.com/pl-pl/dotnet/standard/collections/#algorithmic-complexity-of-collections

- List (lista) [metody](https://learn.microsoft.com/pl-pl/dotnet/api/system.collections.generic.list-1?view=net-7.0#methods)
- HashSet (zbiór) [metody](https://learn.microsoft.com/pl-pl/dotnet/api/system.collections.generic.hashset-1?view=net-7.0#methods)
- Dictionary (słownik) [metody](https://learn.microsoft.com/pl-pl/dotnet/api/system.collections.generic.dictionary-2?view=net-7.0#methods)
- Queue (kolejka) [metody](https://learn.microsoft.com/pl-pl/dotnet/api/system.collections.generic.queue-1?view=net-7.0#methods)

Należy znać różnice pomiędzy kolekcjami oraz potrafić dodać, usunąć wybrany element, wyszukać element, wyczyścić kolekcję.

<details>
<summary>
Utwórz 100 losowych produktów i dodaj je do SnackMachine.
</summary>

Należy użyć jednej z wymienionych kolekcji do utworzenia zbioru nazw produktów. Jeśli użyjemy struktury HashSet zagwarantuje nam to że nazwy nie będą się powtarzać. Podobnie postąpić w przypadku innych właściwości produktu ceny itp.

Następnie tworzyć obiekty i losowo przydzielać wartości nazwy, ceny itp.

Utworozny obiekt dodać do SnackMachine

</details>


<br>
Do utworzonego programu będzie trzeba stworzyć menu umożliwliające interakcję użytkownika z SnackMachine.

## Kryteria oceny:
- Aby otrzymać ocenę 5, program powinien być poprawnie działający, dobrze zorganizowany i czytelny, oraz spełniać wszystkie wymagania zadania. Powinien przewidywać i obsługiwać sytuacje wyjątkowe.(EK_4, EK_5, EK_6)
- Należy dobrać odpowiednie struktury do problemów wystepujących w zadaniu.(EK_5)
<!-- ### EK_4
Potrafi  precyzyjnie  specyfikować  problemy  informatyczne  i formułować ich rozwiązania w języku C#, wykorzystując poznane techniki programowania zorientowanego obiektowo.

### EK_5
Potrafi  stosować  podstawowe  konstrukcje programistyczne   i struktury danych występujące w języku C#. Rozumie ich zalety i wady oraz potrafi odpowiednio je dobrać uwzględniając złożoność, efektywność i jakość utworzonego rozwiązania.
### EK_6
Umie tworzyć proste aplikacje w języku C#. -->