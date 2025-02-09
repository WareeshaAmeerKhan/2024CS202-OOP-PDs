using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    internal class Angle
    {
        public int Degree;
        public double Minute;
        public char Direction;

        public Angle()
        {

        }

        public Angle(int deg, double min, char dir)
        {
            Degree = deg;
            Minute = min;
            Direction = dir;
        }
    }
}
