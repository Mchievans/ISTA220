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
    public class squareTests
    {
        [TestMethod()]
        public void areaTest()
        {
            //arange 
            square claude = new square(1);
            double a = claude.area(2);
            Assert.AreEqual(a, 4);
            //act 
            //assert
        }

        [TestMethod()]
        public void PerimeterTest()
        {
            square sally = new square(1);
            int p = sally.perimeter(7);
            Assert.AreEqual(p, 28);
        }
    }
}