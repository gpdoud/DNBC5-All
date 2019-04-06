using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ArithmeticProject;

namespace TestArithmetic {

    [TestClass]
    public class TestSqr {

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestInvalidMinus127() {
            Arithmetic.sqr(-127);
        }
        [TestMethod]
        public void TestValid10() {
            var actual = Arithmetic.sqr(10);
            Assert.AreEqual(100, actual, "sqr(10) is not 100");
            actual = Arithmetic.sqr(11);
            Assert.AreEqual(121, actual);
            actual = Arithmetic.sqr(53);
            Assert.AreEqual(2809, actual);
            actual = Arithmetic.sqr(99);
            Assert.AreEqual(9801, actual, "sqr(99) is not 9801");
            
            Assert.AreEqual(10000, Arithmetic.sqr(100));
        }
    }
}
