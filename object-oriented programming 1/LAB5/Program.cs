using System.Collections;
using Lab5.Ex4;
using Newtonsoft.Json;

internal class Program {
    public static void Main(string[] args) {
        
        //Ex. 1
        using (var sw = new StreamWriter("file.txt")) {
            sw.WriteLine("Michał Komsa - 123633");
        }

        
        //Ex. 2
        using (var sr = new StreamReader("file.txt")) {
            string text = sr.ReadToEnd();
            Console.WriteLine(text);
        }
        
        
        //Ex. 3
        int fem = 0, men = 0;
        
        using (var sr = new StreamReader("pesels.txt")) {
            string line = sr.ReadLine();

            while (line!=null) {
                if (line[9] % 2 == 0) fem++;
                else men++;
                line = sr.ReadLine();
            }
        }
        
        Console.WriteLine("\nLiczba kobiet: " + fem);
        Console.WriteLine("Liczba mezczyzn: " + men);
        
        
        //Ex. 4
        string json;
        using (var sr = new StreamReader("db.json")) {
            json = sr.ReadToEnd();
        }

        Data[] arrayData = JsonConvert.DeserializeObject<Data[]>(json);

        int length = arrayData.Length;

        int INFirst=0, INSecond=0;
        int USAFirst = 0, USASecond = 0;
        int CHIFirst = 0, CHISecond = 0;
        
        for (int i = 0; i < length; i++) {
            int year = arrayData[i].Date;
            string country = arrayData[i].Country.value;
            
            if (year == 2000 && country.Equals("India")) INFirst = int.Parse(arrayData[i].Value);
            if (year == 1970 && country.Equals("India")) INSecond = int.Parse(arrayData[i].Value);
            
            if (year == 2010 && country.Equals("United States")) USAFirst = int.Parse(arrayData[i].Value);
            if (year == 1965 && country.Equals("United States")) USASecond = int.Parse(arrayData[i].Value);
            
            if (year == 2008 && country.Equals("China")) CHIFirst = int.Parse(arrayData[i].Value);
            if (year == 1980 && country.Equals("China")) CHISecond = int.Parse(arrayData[i].Value);
            
        }
        
        Console.WriteLine("\nIndia 2000-1970: " + (INFirst-INSecond));
        Console.WriteLine("USA 2010-1965: " + (USAFirst-USASecond));
        Console.WriteLine("China 2008-1980: " + (CHIFirst-CHISecond));
        
        Console.Write("Wpisz kraj: ");
        string userCountry = Console.ReadLine();

        while (!userCountry.Equals("India") && !userCountry.Equals("China") && !userCountry.Equals("United States")) {
            Console.Write("Wpisz India/China/United States: ");
            userCountry = Console.ReadLine();
        } 
        
        Console.Write("Wpisz rok: ");
        int userYear = int.Parse(Console.ReadLine());

        while (!(userYear<=2019 && userYear>=1960)) {
            Console.Write("Wpisz rok z zakresu 1960:2019: ");
            userYear = int.Parse(Console.ReadLine());
        } 
        
        for (int i = 0; i < length; i++) {
            int year = arrayData[i].Date;
            string country = arrayData[i].Country.value;
            
            if (year==userYear && country.Equals(userCountry)) Console.WriteLine("Liczba mieszkancow dla " + userCountry + " na rok " + userYear + ": " + arrayData[i].Value);
        }
        
        Console.Write("Wpisz kraj: ");
        string userCountry1 = Console.ReadLine();

        while (!userCountry1.Equals("India") && !userCountry1.Equals("China") && !userCountry1.Equals("United States")) {
            Console.Write("Wpisz India/China/United States: ");
            userCountry1 = Console.ReadLine();
        } 
        
        Console.Write("Wpisz rok: ");
        int userYear1 = int.Parse(Console.ReadLine());

        while (!(userYear1<=2019 && userYear1>=1960)) {
            Console.Write("Wpisz rok z zakresu 1960:2019: ");
            userYear1 = int.Parse(Console.ReadLine());
        } 
        
        Console.Write("Wpisz drugi rok: ");
        int userYear2 = int.Parse(Console.ReadLine());

        while (!(userYear2<=2019 && userYear2>=1960)) {
            Console.Write("Wpisz rok z zakresu 1960:2019: ");
            userYear2 = int.Parse(Console.ReadLine());
        }

        int userFirst = 0, userSecond = 0;

        for (int i = 0; i < length; i++) {
            int year = arrayData[i].Date;
            string country = arrayData[i].Country.value;

            if (year == userYear1 && country.Equals(userCountry1)) userFirst = int.Parse(arrayData[i].Value);
            if (year == userYear2 && country.Equals(userCountry1)) userSecond = int.Parse(arrayData[i].Value);
        }
        
        
        Console.WriteLine(userCountry1 + " " + userYear1 + "-" + userYear2 + ": " + (userFirst-userSecond));
        
        Console.Write("Wpisz rok: ");
        int userYear3 = int.Parse(Console.ReadLine());

        while (!(userYear3<=2018 && userYear3>=1961)) {
            Console.Write("Wpisz rok z zakresu 1961:2018: ");
            userYear3 = int.Parse(Console.ReadLine());
        }

        int previous = userYear3--;
        int pChina = 0, China = 0, pUSA = 0, USA = 0, pIndia = 0, India = 0;
        for (int i = 0; i < length; i++) {
            int year = arrayData[i].Date;
            
            string country = arrayData[i].Country.value;

            if (year == userYear3 && country.Equals("China")) China = int.Parse(arrayData[i].Value);
            if (year == previous && country.Equals("China")) pChina = int.Parse(arrayData[i].Value);
            
            if (year == userYear3 && country.Equals("India")) India = int.Parse(arrayData[i].Value);
            if (year == previous && country.Equals("India")) pIndia = int.Parse(arrayData[i].Value);
            
            if (year == userYear3 && country.Equals("United States")) USA = int.Parse(arrayData[i].Value);
            if (year == previous && country.Equals("United States")) pUSA = int.Parse(arrayData[i].Value);
        }
        
        Console.WriteLine("Zmiennosc dla " + userYear3 + ":");
        Console.WriteLine("India: " + (((pIndia-India)/(India*1.0))*100) + "%");
        Console.WriteLine("China: " + (((pChina-China)/(China*1.0))*100) + "%");
        Console.WriteLine("United States: " + (((pUSA-USA)/(USA*1.0))*100) + "%");
        
        
        //Ex. 5
        
    }
}