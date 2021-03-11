using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            SquareMatrix firstMatrix = new SquareMatrix(1, 2, 3, 4, 5);
            SquareMatrix secondMatrix = new SquareMatrix(1, 2, 3, 4, 5, 6);
            Console.WriteLine("firstMatrix-");
            Console.WriteLine(firstMatrix.MatrixTostring());
            Console.WriteLine("secondMatrix-");
            Console.WriteLine(secondMatrix.MatrixTostring());
            Console.WriteLine($"firstMatrix.Track()- {firstMatrix.Track()}");
            Console.WriteLine($"secondMatrix.Track()- {secondMatrix.Track()}");
            Console.WriteLine($"firstMatrix.Size- {firstMatrix.Size}");
            Console.WriteLine($"secondMatrix.Size- {secondMatrix.Size}");
            Console.WriteLine($"secondMatrix[8,8]- {secondMatrix[8,8]}");
            secondMatrix[8, 8] = 5;
            Console.WriteLine($"secondMatrix[8,8] = 5 - \n{secondMatrix.MatrixTostring()}");
            secondMatrix[3, 2] = 5;
            Console.WriteLine($"secondMatrix[3,2] = 5 - \n{secondMatrix.MatrixTostring()}");
            secondMatrix[3, 3] = 15;
            Console.WriteLine($"secondMatrix[3,3] = 15 - \n{secondMatrix.MatrixTostring()}");
            Console.WriteLine($"firstMatrix.Add(secondMatrix)- \n{(firstMatrix.Add(secondMatrix)).MatrixTostring()}");
           

        }
    }
}
