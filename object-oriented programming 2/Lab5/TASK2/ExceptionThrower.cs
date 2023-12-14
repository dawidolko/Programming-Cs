using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.TASK2
{
    public static class ExceptionThrower
    {
        private static Random rng = new Random();

        public static void ThrowRandomException()
        {
            switch (rng.Next(3)) // Losowo zwraca 0, 1 lub 2
            {
                case 0:
                    throw new FirstCustomException("FirstCustomException was thrown.");
                case 1:
                    throw new SecondCustomException("SecondCustomException was thrown.");
                case 2:
                    throw new ThirdCustomException("ThirdCustomException was thrown.");
                default:
                    throw new Exception("Unexpected exception.");
            }
        }
    }
}
