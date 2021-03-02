using Microsoft.VisualStudio.TestTools.UnitTesting;
using Opgave_1;
using System;
using System.Collections.Generic;
using System.Text;

namespace Opgave_1.Tests
{
    [TestClass()]
    public class BeerTests
    {
        private Beer beer;

        [TestInitialize]
        public void init()
        {
            beer = new Beer(123, "Tuborg", 20, 5.2);
        }

            [TestMethod()]
        public void BeerTest()
        {
            Assert.AreEqual(123, beer.Id);
            Assert.AreNotEqual("Tubor", beer.Name);
            Assert.ThrowsException<ArgumentException>(() => beer.Name = "tub");
            Assert.AreEqual(20, beer.Price);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => beer.Price = -2);
            Assert.AreEqual(5.2, beer.Abv);
            Assert.AreNotEqual(5.1999, beer.Abv);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => beer.Abv = 101);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => beer.Abv = -1);
        }
    }
}