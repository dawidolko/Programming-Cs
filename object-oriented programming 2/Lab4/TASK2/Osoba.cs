using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4.TASK2
{
    public abstract class Osoba
    {
        public string Imie { get; private set; }
        public string Nazwisko { get; private set; }
        public string Pesel { get; private set; }

        public void SetFirstName(string imie) { Imie = imie; }
        public void SetLastName(string nazwisko) { Nazwisko = nazwisko; }
        public void SetPesel(string pesel) { Pesel = pesel; }

        public int GetAge()
        {
            int rok = int.Parse(Pesel.Substring(0, 2));
            int miesiac = int.Parse(Pesel.Substring(2, 2));
            if (miesiac > 20) rok += 2000; else rok += 1900;
            int currentYear = DateTime.Now.Year;
            return currentYear - rok;
        }

        public string GetGender()
        {
            return int.Parse(Pesel[9].ToString()) % 2 == 0 ? "Kobieta" : "Mężczyzna";
        }

        public string GetFullName()
        {
            return $"{Imie} {Nazwisko}";
        }

        public virtual string GetEducationInfo() { return ""; }
        public virtual bool CanGoAloneToHome() { return false; }
    }
}
