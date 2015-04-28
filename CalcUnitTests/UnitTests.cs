using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalcUnitTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestFibonacci6()
        {
            int fibo6 = ConsoleCalc.calculations.fibonacci(6);
            Assert.AreEqual(8, fibo6);
        }

        [TestMethod]
        public void TestFibonacci2()
        {
            int fibo2 = ConsoleCalc.calculations.fibonacci(2);
            Assert.AreEqual(1, fibo2);
        }


        [TestMethod]
        public void TestFibonacci0()
        {
            Type arg = null;
            try
            {
                int fibo0 = ConsoleCalc.calculations.fibonacci(0);
            }
            catch (Exception e)
            {
                arg = e.GetType();
            }
            Assert.AreEqual("System.ArgumentOutOfRangeException", arg.FullName);
        }

        [TestMethod]
        public void TestFibonacci47()
        {
            Type arg = null;
            try
            {
                int fibo47 = ConsoleCalc.calculations.fibonacci(47);
            }
            catch (Exception e)
            {
                arg = e.GetType();
            }
            Assert.AreEqual("System.ArgumentOutOfRangeException", arg.FullName);
        }

        [TestMethod]
        public void TestPi()
        {
            decimal pi = ConsoleCalc.calculations.pi(2);
            Assert.AreEqual(3.14M, pi);
        }
    }
}
