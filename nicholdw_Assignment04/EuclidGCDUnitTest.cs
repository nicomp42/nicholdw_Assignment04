using EuclidGCDNamespace;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace EuclidGCDUnitTestNamespace
{
    [TestClass]
    public class EuclidGCDUnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(10, EuclidGCD.ComputeGCD(110, 210));
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(3, EuclidGCD.ComputeGCD(300,33));
        }
        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(300, EuclidGCD.ComputeGCD(300, 300));
        }
        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual(300, EuclidGCD.ComputeGCD(300, 300));
        }
        [TestMethod]
        public void TestMethod5()
        {
            Assert.AreEqual(33, EuclidGCD.ComputeGCD(33, 3300000000000000));
        }
        [TestMethod]
        public void TestMethod6()
        {
            Assert.AreEqual(1, EuclidGCD.ComputeGCD(9,7));
        }
        [TestMethod]
        public void TestMethod7()
        {
            Assert.AreEqual(11, EuclidGCD.ComputeGCD(99, 77));
        }
        [TestMethod]
        public void TestMethod8()
        {
            // A big prime and a number just 1 smaller
            Assert.AreEqual(1, EuclidGCD.ComputeGCD(99999999977, 99999999976));
        }
        [TestMethod]
        public void TestMethod9()
        {
            // A big prime and a number just 1 smaller, args swapped from previous test
            Assert.AreEqual(1, EuclidGCD.ComputeGCD(99999999976, 99999999977));
        }
        [TestMethod]
        public void TestMethod10()
        {
            // Two big primes
            Assert.AreEqual(1, EuclidGCD.ComputeGCD(100123456789, 99999999977));
        }
        [TestMethod]
        public void TestMethod11()
        {
            // Two big composites. See https://www.wolframalpha.com/input/?i=gcd+100123456786%2C+99999999978
            Assert.AreEqual(2, EuclidGCD.ComputeGCD(100123456786, 99999999978));
        }
        [TestMethod]
        public void TestMethod12()
        {
            // Two big composites. See https://www.wolframalpha.com/input/?i=gcd+100123456786%2C+99999999978
            Assert.AreEqual(2, EuclidGCD.ComputeGCD(100123456786, 99999999978));
        }

    }
}
