using Microsoft.VisualStudio.TestTools.UnitTesting;
using Opgave_1_og_Unit_tests_Obligatorisk_opg_1;
using System;
using System.Collections.Generic;
using System.Text;

namespace Opgave_1_og_Unit_tests_Obligatorisk_opg_1.Tests
{
    [TestClass()]
    public class BeerTests
    {
        private Beer beer = new Beer(1,"halooo",50,12);
        [TestMethod()]
        public void NameTest()
        {
            //Beer beer = new Beer(); Fjernet pga linje 12
            beer.Name = "12345";
            Assert.AreEqual(expected: "12345", actual: beer.Name);
            Assert.ThrowsException<ArgumentException>(() => beer.Name = "123"); // Man laver en test der skal være forkert før den er Grøn (succes)
        }
        [TestMethod()]
        public void PriceTest()
        {
            //Beer beer = new Beer(); Fjernet pga linje 12.
            beer.Price = 1;
            Assert.AreEqual(expected: 1, actual: beer.Price);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => beer.Price = -1);
        }

        [TestMethod()]
        public void AbvTest()
        {
            //Beer beer = new Beer(); Fjernet pga linje 12.
            beer.Abv = 99;
            Assert.AreEqual(expected: 99, actual: beer.Abv);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => beer.Abv = 101);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => beer.Abv = -1);

        }
    }
}