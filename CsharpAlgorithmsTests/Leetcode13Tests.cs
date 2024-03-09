namespace CsharpAlgorithms.Tests
{
    [TestClass()]
    public class Leetcode13Tests
    {
        [TestMethod()]
        public void RomanToIntTest1()
        {
            Assert.AreEqual(3, Leetcode13.RomanToInt("III"));
        }

        [TestMethod()]
        public void RomanToIntTest2()
        {
            Assert.AreEqual(58, Leetcode13.RomanToInt("LVIII"));
        }

        [TestMethod()]
        public void RomanToIntTest3()
        {
            Assert.AreEqual(1994, Leetcode13.RomanToInt("MCMXCIV"));
        }
    }
}