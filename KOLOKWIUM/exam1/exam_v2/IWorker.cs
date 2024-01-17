using System;
namespace test
{
    public interface IWorker
    {
        decimal WeekSalary { get; set; }
        int WorkHoursPerDay { get; set; }
        decimal MoneyPerHour();
        string ToString();
    }
}

