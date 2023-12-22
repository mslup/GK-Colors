using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal static class PointExtensions
    {
        public static float eps = 8;

        public static bool IsCloseToPoint(this Point point, Point other)
        {
            return Math.Abs(point.X - other.X) < eps &&
                Math.Abs(point.Y - other.Y) < eps;
        }
    }
}
