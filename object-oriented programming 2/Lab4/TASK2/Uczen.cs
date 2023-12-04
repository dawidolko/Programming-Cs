using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4.TASK2
{
    public class Uczen : Osoba
    {
        public string Szkola { get; private set; }
        public bool MozeSamWracacDoDomu { get; private set; }

        public void SetSchool(string szkola) { Szkola = szkola; }
        public void ChangeSchool(string nowaSzkola) { Szkola = nowaSzkola; }
        public void SetCanGoHomeAlone(bool mozeSam) { MozeSamWracacDoDomu = mozeSam; }

        public override string GetEducationInfo()
        {
            return $"Uczeń szkoły: {Szkola}";
        }

        public override bool CanGoAloneToHome()
        {
            return GetAge() >= 12 || MozeSamWracacDoDomu;
        }

        public string Info()
        {
            return CanGoAloneToHome() ? $"{GetFullName()} może wracać do domu sam." : $"{GetFullName()} nie może wracać do domu sam.";
        }
    }
}
