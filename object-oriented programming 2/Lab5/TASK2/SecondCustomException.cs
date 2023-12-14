using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.TASK2
{
    public class SecondCustomException : Exception
    {
        public SecondCustomException(string message) : base(message) { }
    }
}
