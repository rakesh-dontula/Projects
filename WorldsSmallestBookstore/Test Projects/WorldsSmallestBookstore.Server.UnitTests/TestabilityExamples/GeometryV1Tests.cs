using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldsSmallestBookstore.Server.TestabilityExamples;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WorldsSmallestBookstore.Server.TestabilityExamples.Tests
{
    [TestClass()]
    public class GeometryV1Tests
    {
        [TestMethod()]
        public void XInterceptTest()
        {
            var instance = new GeometryV1();
            var p1 = new Point(2, 13);
            var p2 = new Point(3, 17);
            var actual = instance.XIntercept(p1, p2);
            Assert.AreEqual(-1.25, actual.X);
        }

        [TestMethod()]
        public void YInterceptTest()
        {
            var instance = new GeometryV1();
            var p1 = new Point(2, 13);
            var p2 = new Point(3, 17);
            var actual = instance.YIntercept(p1, p2);
            Assert.AreEqual(5, actual.Y);
        }

        [TestMethod()]
        public void X_HorizontalTest()
        {
            var instance = new GeometryV1();
            var p1 = new Point(2, 13);
            var p2 = new Point(3, 17);
            var actual = instance.YIntercept(p1, p2);
            Assert.AreEqual(0, actual.X);
        }

        [TestMethod()]
        public void Y_HorizontalTest()
        {
            var instance = new GeometryV1();
            var p1 = new Point(2, 13);
            var p2 = new Point(3, 17);
            var actual = instance.YIntercept(p1, p2);
            Assert.AreEqual(0, actual.Y);
        }

        [TestMethod()]
        public void X_VerticalTest()
        {
            var instance = new GeometryV1();
            var p1 = new Point(2, 13);
            var p2 = new Point(3, 17);
            var actual = instance.YIntercept(p1, p2);
            Assert.AreEqual(5, actual.Y);
        }

        [TestMethod()]
        public void Y_VerticalTest()
        {
            var instance = new GeometryV1();
            var p1 = new Point(2, 13);
            var p2 = new Point(3, 17);
            var actual = instance.YIntercept(p1, p2);
            Assert.AreEqual(5, actual.Y);
        }
    }
}
