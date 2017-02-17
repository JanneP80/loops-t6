using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops_t7
{
    class Program
    {
        static void Main(string[] args)
        {

            int number1 = 1;
            int number2 = 1;
            int answer = 0;

            for (int x = 1; x < 10; x++) // calculcates first number 9 times
            {

                for (int i = 1; i < 10; i++) // calculcates second number 9 times
                {
                    answer = number1 * number2; // the actual calculation itself
                    Console.WriteLine("{0} x {1} = {2}", number1, number2, answer);
                    number2 = number2 + 1; // increase second number by one for next loop
                                   
                }

                number1 = number1 + 1; // increase first number by one for next loop
                number2 = 1; // reset for next loop

            }
            Console.ReadKey();

        }
    }
}
