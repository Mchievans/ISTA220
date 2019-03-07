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
    public class BigDogsTests
    {
        [TestMethod()]
        public void TalkTest()
        {
            //arrange
            BigDogs sc = new BigDogs();
            //act
            string sound = sc.Talk();
            //assert
            Assert.AreEqual(sound, "Roof Roof!!");
            //Assert.Fail();
        }

        [TestMethod()]
        public void EatTest()
        {
            //arrange
            BigDogs cl = new BigDogs();
            //act
            string food = cl.Eat();
            //assert
            Assert.AreEqual(food, "chew, chew, chew");
        }
    }
}