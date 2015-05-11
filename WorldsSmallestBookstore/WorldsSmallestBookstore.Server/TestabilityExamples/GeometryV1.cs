using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorldsSmallestBookstore.Server.TestabilityExamples
{
    public class GeometryV1 : IGeometry
    {
        private double Slope(Point p1, Point p2)
        {
            double dx = p2.X - p1.X;
            double dy = p2.Y - p1.Y;
            double m = dy / dx;
            return m;
        }
        public Point XIntercept(Point p1, Point p2)
        {
            var m = Slope(p1, p2);
            var b = YIntercept(p1, p2).Y;
            var intercept = -b / m;
            return new Point(intercept, 0);
        }

        public Point YIntercept(Point p1, Point p2)
        {
            var m = Slope(p1, p2);
            var b = p1.Y - p1.X * m;
            return new Point(0, b);
        }
    }
}