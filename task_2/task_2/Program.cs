using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Input first number");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input second number");
            b = Convert.ToInt32(Console.ReadLine());

            bool nothing = true;
            for(int i = Math.Min(a, b); i < (Math.Max(a, b) + 1); i++)
            {
                if(UnitsIncluding(i) == 4)
                {
                    Console.WriteLine(i);
                    nothing = false;
                }
            }
            if (nothing)
            {
                Console.WriteLine("Nothing to output");
            }
            Console.ReadKey();
        }
        static int UnitsIncluding(int source)
        {
            int count = 0; 
            for (int i = 0; i < 32; i++)
            {
                if (Math.Abs((source >> i) % 2) == 1)
                    count++;
            }
            return count;
        }
    }
}
