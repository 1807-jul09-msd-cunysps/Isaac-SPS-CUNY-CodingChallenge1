using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PalindromeLibrary;

namespace PalindromUnitTest
{
    [TestClass]
    public class PalindromUnitTest
    {
        [TestMethod]
        public void NutTest()
        {
            PalindromeChecker checker = new PalindromeChecker();

            string testString = "A nut for a jar of tuna.";

            Assert.IsTrue(checker.Check(testString));
        }

        [TestMethod]
        public void BorrowTest()
        {
            PalindromeChecker checker = new PalindromeChecker();

            string testString = "Borrow or rob";

            Assert.IsTrue(checker.Check(testString));
        }

        [TestMethod]
        public void DigitTest()
        {
            PalindromeChecker checker = new PalindromeChecker();

            int testString = 343;

            Assert.IsTrue(checker.Check(testString));
        }
    }
}
