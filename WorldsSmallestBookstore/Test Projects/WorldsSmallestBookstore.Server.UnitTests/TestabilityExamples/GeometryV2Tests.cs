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
    //[TestClass()]
    public class GeometryV2Tests
    {
        [TestMethod()]
        public void XInterceptTest_MinMax()
        {
            var instance = new GeometryV1();
            var p1 = new Point(Double.MaxValue, Double.MaxValue);
            var p2 = new Point(Double.MinValue, Double.MinValue);
            var actual = instance.XIntercept(p1, p2);
            Assert.AreEqual(-50, actual.X);
        }

        [TestMethod()]
        public void XInterceptTest_Vertical()
        {
            var instance = new GeometryV1();
            var p1 = new Point(10, 10);
            var p2 = new Point(10, 20);
            var actual = instance.XIntercept(p1, p2);
            Assert.AreEqual(10, actual.X);
        }

        [TestMethod()]
        public void YInterceptTest_Horizontal()
        {
            var instance = new GeometryV1();
            var p1 = new Point(10, 10);
            var p2 = new Point(20, 10);
            var actual = instance.YIntercept(p1, p2);
            Assert.AreEqual(10, actual.Y);
        }

        [TestMethod()]
        // There is no answer....
        public void XInterceptTest_Horizontal()
        {
            var instance = new GeometryV1();
            var p1 = new Point(10, 10);
            var p2 = new Point(20, 10);
            var actual = instance.XIntercept(p1, p2);
            throw new Exception("What is Desired??");
            //Assert.IsTrue(Double.IsInfinity(actual.X));
        }

        [TestMethod()]
        // There is no answer....
        public void YInterceptTest_Vertical()
        {
            var instance = new GeometryV1();
            var p1 = new Point(10, 10);
            var p2 = new Point(10, 20);
            var actual = instance.YIntercept(p1, p2);
            throw new Exception("What is Desired??");
            //Assert.IsTrue(Double.IsInfinity(actual.Y));
        }

    }
}
