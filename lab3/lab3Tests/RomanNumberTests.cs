using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumbers.Tests
{
    [TestClass()]
    public class RomanNumberTests
    {
        [TestMethod()]
        public void ZeroExceptionTest()
        {
            RomanNumber a;
            Assert.ThrowsException<RomanNumberException>(() => a = new(0));
        }
        [TestMethod()]
        public void ZeroExceptionTest2()
        {
            RomanNumber a = new(13);
            RomanNumber b = new(17);
            Assert.ThrowsException<RomanNumberException>(() => a - b);
        }
        [TestMethod()]
        public void RomanNumberTest()
        {
            RomanNumber a = new(55);
            Assert.IsNotNull(a);
        }

        [TestMethod()]
        public void ToStringTest()
        {
            RomanNumber a = new(20);
            string result = "XX";
            Assert.AreEqual(a.ToString(), result);
        }

        [TestMethod()]
        public void CloneTest()
        {
            RomanNumber a = new(113);
            RomanNumber b = (RomanNumber)a.Clone();
            Assert.AreNotSame(a, b);
        }

        [TestMethod()]
        public void ArraySortTest()
        {
            RomanNumber a = new(26);
            RomanNumber b = new(113);
            RomanNumber c = new(12);
            RomanNumber d = new(260);
            RomanNumber[] result = { c, a, b, d };
            RomanNumber[] massive = { a, b, c, d };

            Array.Sort(massive);
            for (int i = 0; i < 3; i++)
            {
                Assert.AreEqual(massive[i], result[i]);
            }
        }

        [TestMethod()]
        public void CompareToTest()
        {
            RomanNumber a = new(113);
            RomanNumber b = new(113);
            int expected = 0;
            int actual = a.CompareTo(b);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void AddTest()
        {
            RomanNumber a = new(113);
            RomanNumber b = new(370);
            RomanNumber result = new(483);
            Assert.AreEqual(result.ToString(), (a + b).ToString());
        }

        [TestMethod()]
        public void SubTest()
        {
            RomanNumber a = new(1260);
            RomanNumber b = new(370);
            RomanNumber result = new(890);
            Assert.AreEqual(result.ToString(), (a - b).ToString());
        }
        [TestMethod()]
        public void DivTest()
        {
            RomanNumber a = new(500);
            RomanNumber b = new(250);
            RomanNumber result = new(2);
            Assert.AreEqual(result.ToString(), (a / b).ToString());
        }
        [TestMethod()]
        public void MulTest()
        {
            RomanNumber a = new(9);
            RomanNumber b = new(5);
            RomanNumber result = new(45);
            Assert.AreEqual(result.ToString(), (a * b).ToString());
        }
    }
}