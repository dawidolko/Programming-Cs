# Programowanie obiektowe- LAB 2 zadania
### 1)
Stwórz klasę Licz z:

i) publicznym polem wartosc przechowującym wartość liczbową.

ii) metodą Dodaj przyjmującą jeden parametr i dodającą przekazaną wartość do wartości trzymanej w polu wartosc.

iii) analogiczną operację odejmij

W Main utwórz kilka obiektów klasy Licz i wykonaj różne operacje.

b) Do klasy Licz dodaj konstruktor z jednym parametrem - który inicjuje pole wartość na liczbę przekazaną w parametrze.

c) Zmień widoczność pola na private i dodaj funkcję wypisującą stan obiektu (pole wartosc)
### 2) 
Stwórz klasę Sumator z:

i) publicznym polem Liczby będącym tablicą liczb

ii) metodą Suma zwracającą sumę liczb z pola Liczby

iii) metodę SumaPodziel2 zwracającą sumę liczb z tablicy, które są podzielne przez 2

b) Zmień widoczność pola Liczby na private oraz dodaj konstruktor.

c) Dodaj metodę: int IleElementów () zwracającej liczbę elementów na w tablicy

d) Dodaj metodę wypisującą wszystkie elementy tablicy

e) Dodaj metodę przyjmującą dwa parametry: lowIndex oraz highIndex, która wypisze elementy o indeksach >= lowIndex oraz <= highIndex. Metoda powinna zadziałać poprawnie, gdy lowIndex lub highIndex wykraczają poza zakres tablicy (pominąć te elementy).
### 3) 
Zdefiniuj klasę opisującą datę. Zastanów się nad wyborem wewnętrznej reprezentacji dat. Zdefiniuj metody pozwalające na odczytywanie bieżącej daty i przestawianie jej o jeden tydzień w przód i w tył. Zadbaj o dobranie odpowiednich modyfikatorów dostępu do składowych.
### 4) 
Zdefiniuj klasę Liczba, która przechowuje w tablicy cyfry liczby dziesiętnej. Zdefiniuj operacje wypisywania liczby, nadawania jej wartości (w postaci parametru konstruktora będącego napisem) oraz mnożenia przez liczbę typu int. W przypadku gdy w czasie mnożenia okaże się, że tablica jest za mała, procedura mnożąca powinna kopiować jej zawartość do większej. Zdefiniuj wreszcie metodę silnia, która policzy silnię zadanej jako parametr liczby typu int.
