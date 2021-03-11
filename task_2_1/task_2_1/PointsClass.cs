using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointsClass
{
    class Point3D
    {
        private int[]  coordinates;
        private double mass;
        public Point3D(int x = 0, int y = 0, int z = 0)
        {
            coordinates = new int[3] {x, y, z};
        }
        public int X
        {
            set
            {
                coordinates[0] = value;
            }
            get { return coordinates[0]; }
        }

        public int Y
        {
            set
            {
                coordinates[1] = value;
            }
            get { return coordinates[1]; }
        }

        public int Z
        {
            set
            {
                coordinates[2] = value;
            }
            get { return coordinates[2]; }
        }

        public double Mass
        {
            set
            {
                if (value < 0)
                {
                    mass = 0;
                }
                else
                {
                    mass = value;
                }
            }
            get { return mass; }
        }

        public bool IsZero()
        {
            if((coordinates[0] == 0) && (coordinates[1] == 0) && (coordinates[2] == 0))
            {
                return true;
            }
            return false;
        }

        public double Distance(Point3D point)
        {
            return Math.Sqrt(Math.Pow((this.X - point.X), 2) + Math.Pow((this.Y - point.Y), 2) + Math.Pow((this.Z - point.Z), 2));
        }
    }
}
