using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4.TASK3
{
    public class StudentWSIiZ : Student
    {
        public StudentWSIiZ(string imie, string nazwisko, string kierunek, int rok, int semestr)
            : base(imie, nazwisko, "WSIiZ", kierunek, rok, semestr)
        {
        }
    }
}
