using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointsClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Point3D first_point = new Point3D(4, 7, 24);
            Point3D second_point = new Point3D(67, 2, 5);
            Console.WriteLine($"coordinates of first point, X = {first_point.X} Y = {first_point.Y} Z = {first_point.Z}");
            first_point.Mass = 3.14;
            Console.WriteLine($"Mass(3.14) of first point {first_point.Mass}");
            first_point.Mass = -4.45;
            Console.WriteLine($"Mass(-4.45) of first point {first_point.Mass}");
            first_point.X = 8;
            first_point.Y = 12;
            first_point.Z = 54;
            Console.WriteLine($"coordinates of first point after changes, X = {first_point.X} Y = {first_point.Y} Z = {first_point.Z}");
            Console.WriteLine($"coordinates of second point, X = {second_point.X} Y = {second_point.Y} Z = {second_point.Z}");
            Console.WriteLine($"distance between first point and second piont {first_point.Distance(second_point)}");
            Console.WriteLine($"distance between second point and first piont {second_point.Distance(first_point)}");
            Point3D null_point = new Point3D();
            Console.WriteLine($"first_point.IsZero() = {first_point.IsZero()}");
            Console.WriteLine($"null_point.IsZero() = {null_point.IsZero()}");
            Console.ReadKey();

        }
    }
}
