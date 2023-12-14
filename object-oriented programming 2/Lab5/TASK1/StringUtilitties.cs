using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.TASK1
{
    using System;

    namespace Lab5.TASK1
    {
        public class StringUtilities
        {
            public static void PrintStringLength(string input)
            {
                if (input == null)
                {
                    throw new ArgumentNullException(nameof(input), "Napis nie może być null.");
                }

                Console.WriteLine($"Długość napisu: {input.Length}");
            }
        }
    }

}
