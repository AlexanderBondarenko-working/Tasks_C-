using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] input;
            Console.WriteLine("Enter 9 numerals");
            string numerals = Console.ReadLine();
            int sum = 0;
            input = numerals.Split(' ').Select(int.Parse).ToArray();
            if (input.Length == 9)
            {
                foreach (int number in input)
                {
                    sum += number;
                }
                for(int i = 0; i < 11; i++)
                {
                    if ((sum + i) % 11 == 0)
                    {
                        if (i != 10)
                        {
                            Console.WriteLine($"{string.Join(null, input)}{i.ToString()}");
                        }
                        if (i == 10)
                        {
                            Console.WriteLine($"{string.Join(null, input)}X");
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("incorrect paremetr");
            }


        }
    }
}
