using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.TASK2
{
    public class ThirdCustomException : Exception
    {
        public ThirdCustomException(string message) : base(message) { }
    }
}
