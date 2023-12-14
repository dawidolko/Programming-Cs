using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.TASK3
{
    public class SomeClass
    {
        public bool Value { get; internal set; }

        public void CanThrowException(int id)
        {
            if (new Random().Next(5) == 0)
            {
                throw new Exception($"Wyjątek zgłoszony przez instrukcję numer: {id}");
            }
        }
    }
}
