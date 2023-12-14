using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.TASK5
{
    public class CustomDataType : ICloneable
    {
        public int NumberValue;
        public string TextValue;

        // Konstruktor
        public CustomDataType(int numberValue, string textValue)
        {
            NumberValue = numberValue;
            TextValue = textValue;
        }

        // Implementacja metody Clone z interfejsu ICloneable
        public object Clone()
        {
            // MemberwiseClone() wykonuje płytką kopię
            return this.MemberwiseClone();
        }
    }
}
