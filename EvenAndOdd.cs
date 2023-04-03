using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_SimpleProgram
{
    internal class EvenAndOdd
    {
        public void EvenOrOdd(int givenData, int valueTwo2)
        {
            if (givenData % 2 == 0)
            {
                Console.WriteLine("Given Number is Even Number");
            }
            else
            {
                Console.WriteLine("Ggiven Number is Odd Number");
            }
        }

    }
}
