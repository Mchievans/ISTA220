using Microsoft.VisualStudio.TestTools.UnitTesting;
using Circle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle.Tests
{
    [TestClass()]
    public class CircleTests
    {
        [TestMethod()]
        public void AreaTest()
        {
            //arange sets eveything upso you can run test
            Circle circle = new Circle(1);
            //act invokes method
            double a = circle.Area(1);
            //assert says if its  correct or not
            Assert.AreEqual(a, Math.PI);
        }

        [TestMethod()]
        public void CircumTest()
        {
            //arange
            Circle ball = new Circle(1);
            //act
            double c = ball.Circum(1);
            //assert
            Assert.AreEqual(c, 2 * Math.PI);
        }
    }
}