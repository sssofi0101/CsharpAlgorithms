using Microsoft.VisualStudio.TestTools.UnitTesting;
using CsharpAlgorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAlgorithms.Tests
{
    [TestClass()]
    public class Leetcode9Tests
    {
        [TestMethod()]
        public void IsPalindromeTest1()
        {
            Assert.AreEqual(true, Leetcode9.IsPalindrome(121));

        }
        [TestMethod()]
        public void IsPalindromeTest2()
        {
            Assert.AreEqual(false, Leetcode9.IsPalindrome(-121));
        }

        [TestMethod()]
        public void IsPalindromeTest3()
        {
            Assert.AreEqual(false, Leetcode9.IsPalindrome(10));
        }
    }
}