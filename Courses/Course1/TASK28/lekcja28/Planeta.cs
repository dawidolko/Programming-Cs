using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lekcja28
{
    abstract class Planeta : CialoNIebieskie
    {
        public void PoraDniaINocy()
        {
            Console.WriteLine("Pory dnia i nocy");
        }
    }
}
