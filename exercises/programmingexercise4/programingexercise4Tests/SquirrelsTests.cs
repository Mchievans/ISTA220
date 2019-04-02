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
    public class SquirrelsTests
    {
        [TestMethod()]
        public void TalkTest()
        {
            //arrange
            Squirrels nut = new Squirrels();
            //act
            string sound = nut.Talk();
            //assert
            Assert.AreEqual(sound, "hide my nuts!");
            //Assert.Fail();
        }

        [TestMethod()]
        public void EatTest()
        {
            //arrange
            Squirrels nutty = new Squirrels();
            //act
            string food = nutty.Eat();
            //assert
            Assert.AreEqual(food, "tititititittititit");
        }
    }
}