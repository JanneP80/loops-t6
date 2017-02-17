using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops_t6
{
    class Program
    {
        static void Main(string[] args)
        {

            double number = 10;
            double sqrnumber = 0;

            Console.WriteLine("Number   Sqrt");
            for (int i = 1; i < number+1; i++)
            {
                sqrnumber = Math.Sqrt(i);

                Console.WriteLine("  {0} \t{1}", i, Math.Round(sqrnumber, 2));
            }

            Console.ReadKey();
        }
    }
}
