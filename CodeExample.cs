using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1B
{
    class CodeExample
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    if (i % 5 == 0)
                    {
                        Console.Write(" BudSoft ");
                    }
                    else
                    {
                        Console.Write(" Bud ");
                    }
                }
                if (i % 5 == 0 && i % 3 != 0)
                {
                    Console.Write(" Soft ");
                }
                else if (i % 3 != 0 && i % 5 != 0)
                {
                    Console.Write($" {i} ");
                }
            }
            Console.ReadLine();
        }
    }
}
