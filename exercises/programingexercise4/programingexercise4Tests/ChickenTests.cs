using Microsoft.VisualStudio.TestTools.UnitTesting;
using programingexercise4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programingexercise4.Tests
{
    [TestClass()]
    public class ChickenTests
    {
        [TestMethod()]
        public void TalkTest()
        {
            //arange
            Chicken first = new Chicken();
            //act
            string sound = first.Talk();
            //asseret 
            Assert.AreEqual(sound, "COCKaDOODLEDOO");
        }

        [TestMethod()]
        public void PeckTest()
        {
            //arrange
            Chicken f = new Chicken();
            //act
            string feed = f.Eat();
            //assert
            Assert.AreEqual(feed, "Peck, Peck, Peck <<<<......");
        }
    }
}