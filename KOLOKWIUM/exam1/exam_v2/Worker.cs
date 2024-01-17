using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class Worker : Human, IHuman, IWorker
    {
        public decimal WeekSalary { get; set; }
        public int WorkHoursPerDay { get; set; }

        public Worker(string firstName, string lastName, decimal weekSalary, int workHoursPerDay)
            : base(firstName, lastName)
        {
            if (weekSalary < 0 || workHoursPerDay <= 0)
            {
                throw new ArgumentException("Wynagrodzenie tygodniowe musi być nieujemne, a liczba godzin pracy dziennie musi być większa od zera.");
            }

            WeekSalary = weekSalary;
            WorkHoursPerDay = workHoursPerDay;
        }

        public decimal MoneyPerHour()
        {
            // Zakładamy, że tydzień pracy ma 5 dni
            return WeekSalary / (WorkHoursPerDay * 5);
        }
        public override string ToString()
        {
            return $"Pracownik: {FirstName} {LastName}, Zarobek na godzinę: {MoneyPerHour():C}";
        }
    }
}
