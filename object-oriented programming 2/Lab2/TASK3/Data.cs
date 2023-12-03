using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.TASK3
{
    public class Data
    {
        private DateTime aktualnaData;

        // Konstruktor domyślny ustawiający aktualną datę na dzisiejszą datę
        public Data()
        {
            aktualnaData = DateTime.Today;
        }

        // Metoda do odczytu bieżącej daty
        public DateTime OdczytajDate()
        {
            return aktualnaData;
        }

        // Metoda do przesunięcia daty o tydzień do przodu
        public void PrzesunTydzienDoPrzodu()
        {
            aktualnaData = aktualnaData.AddDays(7);
        }

        // Metoda do przesunięcia daty o tydzień do tyłu
        public void PrzesunTydzienDoTylu()
        {
            aktualnaData = aktualnaData.AddDays(-7);
        }
    }

}
