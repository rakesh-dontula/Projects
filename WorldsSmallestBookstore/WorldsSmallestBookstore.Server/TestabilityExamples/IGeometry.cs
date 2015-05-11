using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WorldsSmallestBookstore.Server.TestabilityExamples
{

    public class Point
    {
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
        public Double X { get; private set; }
        public Double Y { get; private set; }
    }
    interface IGeometry
    {
        Point XIntercept(Point p1, Point p2);
        Point YIntercept(Point p1, Point p2);
    }
}
