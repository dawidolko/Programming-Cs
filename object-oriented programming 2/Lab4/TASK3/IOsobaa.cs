using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4.TASK3
{
    public interface IOsobaa
    {
        string Imie { get; set; }
        string Nazwisko { get; set; }
        string ZwrocPelnaNazwe();
    }
}
