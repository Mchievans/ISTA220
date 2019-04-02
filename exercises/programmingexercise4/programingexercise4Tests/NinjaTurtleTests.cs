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
    public class NinjaTurtleTests
    {
        [TestMethod()]
        public void TalkTest()
        {
            //arrange
            NinjaTurtle d = new NinjaTurtle();
            //act
            string sound = d.Talk();
            //assert
            Assert.AreEqual(sound, "Cowabunga Dude!!!");
            //Assert.Fail();
        }

        [TestMethod()]
        public void EatTest()
        {
            //arrange
            NinjaTurtle d = new NinjaTurtle();
            //act
            string food = d.Eat();
            //assert
            Assert.AreEqual(food, "Pizza is Awesome sauce!");
            //Assert.Fail();
        }
    }
}