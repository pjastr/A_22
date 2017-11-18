using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_22
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < 10; i++)
            {
                for (int j = 10; j >= i; j--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j < 2 * i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();

            }

            for (int i = 0; i < 10; i++)
            {

                for (int j = -2; j <= i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 14; j >=2*i; j--)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }


            Console.ReadKey();
        }
    }
}
