using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ArithmeticProject;

namespace TestArithmetic {

    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class TestSimpleMethods {

        [TestMethod]
        public void TestAdd() {
            Assert.AreEqual(-97, Arithmetic.Add(-49, -48));
            Assert.AreEqual(-3, Arithmetic.Add(-1, -2));
            Assert.AreEqual(0, Arithmetic.Add(-1, 1));
            Assert.AreEqual(97, Arithmetic.Add(49, 48));
            try {
                Arithmetic.Add(-49, -50);
                Assert.Fail("Add should have thrown an exceptin");
            } catch(Exception) { }
        }
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestAddWithException() {
            Arithmetic.Add(49, 50);
        }
        [TestMethod]
        public void TestSubract() {
            Assert.AreEqual(-1, Arithmetic.Subtract(-49, -48));
            Assert.AreEqual(1, Arithmetic.Subtract(-1, -2));
            Assert.AreEqual(-2, Arithmetic.Subtract(-1, 1));
            Assert.AreEqual(1, Arithmetic.Subtract(49, 48));
            try {
                Arithmetic.Subtract(-49, -50);
                Assert.Fail("Subtract should have thrown an exceptin");
            } catch(Exception) { }
            try {
                    Arithmetic.Subtract(49, 50);
                Assert.Fail("Subtract should have thrown an exceptin");
            } catch(Exception) { }
        }
        [TestMethod]
        public void TestMultiply() {
            Assert.AreEqual(2352, Arithmetic.Multiply(-49, -48));
            Assert.AreEqual(2, Arithmetic.Multiply(-1, -2));
            Assert.AreEqual(-1, Arithmetic.Multiply(-1, 1));
            Assert.AreEqual(2352, Arithmetic.Multiply(49, 48));
            try {
                Arithmetic.Multiply(-49, -50);
                Assert.Fail("Multiply should have thrown an exceptin");
            } catch(Exception) { }
            try {
                Arithmetic.Multiply(49, 50);
                Assert.Fail("Multiply should have thrown an exceptin");
            } catch(Exception) { }
        }
        [TestMethod]
        public void TestDivide() {
            Assert.AreEqual(1, Arithmetic.Divide(-49, -48));
            Assert.AreEqual(0, Arithmetic.Divide(-1, -2));
            Assert.AreEqual(-1, Arithmetic.Divide(-1, 1));
            Assert.AreEqual(1, Arithmetic.Divide(49, 48));
            try {
                Arithmetic.Divide(-49, -50);
                Assert.Fail("Divide should have thrown an exceptin");
            } catch(Exception) { }
            try {
                Arithmetic.Divide(49, 50);
                Assert.Fail("Divide should have thrown an exceptin");
            } catch(Exception) { }
        }
        public TestSimpleMethods() {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext {
            get {
                return testContextInstance;
            }
            set {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

    }
}
