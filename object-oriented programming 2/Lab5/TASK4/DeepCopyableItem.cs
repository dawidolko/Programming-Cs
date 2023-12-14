using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.TASK4
{
    public class DeepCopyableItem
    {
        public int NumberValue;
        public string TextValue;
        // ... inne pola

        // Konstruktor
        public DeepCopyableItem(int numberValue, string textValue)
        {
            NumberValue = numberValue;
            TextValue = textValue;
            // ... inicjalizacja innych pól
        }

        // Metoda do głębokiego kopiowania
        public DeepCopyableItem DeepCopy()
        {
            // Tworzenie nowej instancji obiektu z tymi samymi wartościami
            return new DeepCopyableItem(this.NumberValue, (string)this.TextValue.Clone());
        }
    }
}
