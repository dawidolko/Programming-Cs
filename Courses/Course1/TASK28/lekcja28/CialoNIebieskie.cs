using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lekcja28
{
    abstract class CialoNIebieskie
    {
        public string Nazwa { get; set; }
        public void RuchObrotowy()
        {
            Console.WriteLine(Nazwa + " obraca się");
        }
    }
}
