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