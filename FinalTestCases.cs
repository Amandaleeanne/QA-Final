using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FindDiscountTestCases
{
    [TestClass]
    public class UnitTest1
    {
        public bool CanDrive(int age) {

            const int drivingAge = 16; 
            return age >= drivingAge;

        }
        //int min boundary
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestMethod1()
        {
            CanDrive(int.MinValue);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestMethod2()
        {
            CanDrive(int.MinValue + 1);
        }
        //Min boundary
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestMethod3()
        {
            CanDrive(-1);
        }
        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual(false, CanDrive(0));
        }
        [TestMethod]
        public void TestMethod5()
        {
            Assert.AreEqual(false, CanDrive(1));
        }
        //At Value
        [TestMethod]
        public void TestMethod6()
        {
            Assert.AreEqual(false, CanDrive(15));
        }
        [TestMethod]
        public void TestMethod7()
        {
            Assert.AreEqual(true, CanDrive(16));
        }
        [TestMethod]
        public void TestMethod8()
        {
            Assert.AreEqual(true, CanDrive(17));
        }
        //Within parameters edge case
        [TestMethod]
        public void TestMethod7()
        {
            Assert.AreEqual(true, CanDrive(69));
        }
        [TestMethod]
        public void TestMethod7()
        {
            Assert.AreEqual(true, CanDrive(70));
        }
        [TestMethod]
        public void TestMethod7()
        {
            Assert.AreEqual(true, CanDrive(71));
        }
        //Max Value
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestMethod6()
        {
            CanDrive(int.MaxValue);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestMethod7()
        {
            CanDrive(int.MaxValue - 1);
        }

    }
}
