using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("pls enter n1");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("pls enter n2");
            int n2 = int.Parse(Console.ReadLine());

            int i, x;
            Console.Write("The perfect numbers between " + n1 + " and " + n2 + " are: ");
            for (i = n1; i <= n2; i++)
            {
                int sum = 0;
                for (x = 1; x < i; x++)
                {
                    if (i % x == 0)
                    {
                        sum += x;
                    }

                }
                if (sum == i)
                {
                    Console.Write(i + ", ");
                }
            }
        }

        
    }
}
