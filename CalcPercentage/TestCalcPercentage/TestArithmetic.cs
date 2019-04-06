using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Max;

namespace TestMaxArithmetic {

    [TestClass]
    public class TestArithmetic {

        [TestMethod]
        public void TestAdd() {
            var result = Arithmetic.Add(4, 2);
            Assert.AreEqual(6, result);
        }
        [TestMethod]
        public void TestAddIntMaxValue() {
            var maxint = int.MaxValue;
            var increment = 1;
            var result = Arithmetic.Add(int.MaxValue, increment);
            Assert.AreEqual(increment + maxint, result);
        }
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestDivideByZero() {
            Arithmetic.Divide(1, 0);
        }
    }
}
