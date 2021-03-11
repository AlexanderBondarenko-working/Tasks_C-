using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double w;
            double T;
            double v;
            bool result = true;
            Console.WriteLine("Enter the temperature");
            T = Convert.ToDouble(Console.ReadLine());
            T = (T * 1.8) + 32.0;
            Console.WriteLine("Enter wind speed");
            v = Convert.ToDouble(Console.ReadLine());
            v *= 2.2369362920544;
            w = 35.74 + (0.6215 * T) + (0.4275 * T - 33.75) * Math.Pow(v, 0.16);
            if((Math.Abs(T) > 50) || (Math.Abs(v) < 3) || (Math.Abs(v) > 120))
            {
                result = false;
            }
            Console.WriteLine($"Effective temperature: {((T - 32.0) / 1.8)}");
            if (!result)
            {
                Console.WriteLine("The result may be incorrect");
            }
            Console.ReadKey();
        }
    }
}
