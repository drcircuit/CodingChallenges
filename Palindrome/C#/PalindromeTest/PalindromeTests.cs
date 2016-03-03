using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Otto.Frameworks.Palindrome.Palindrome;
using Otto.Frameworks.Palindrome;

namespace PalindromeTest
{
    [TestClass]
    public class Words
    {
        [TestMethod]
        public void EmptyReturnsTrue()
        {
            Assert.IsTrue(IsPalindrome(null));
            Assert.IsTrue(IsPalindrome(string.Empty));
        }
        [TestMethod]
        public void SingleCharacterRetursTrue()
        {
            Assert.IsTrue(IsPalindrome("a"));
        }
        [TestMethod]
        public void DoubleCharacterNonPalindromeReturnsFalse()
        {
            Assert.IsFalse(IsPalindrome("an"));
            Assert.IsFalse("an".IsPalindrome());
        }
        [TestMethod]
        public void DoubleCharacterPalindromeReturnsTrue()
        {
            Assert.IsTrue(IsPalindrome("aa"));
        }
        [TestMethod]
        public void SingleWordNonPalindromeReturnsFalse()
        {
            Assert.IsFalse(IsPalindrome("anda"));
        }
        [TestMethod]
        public void SingleWordPalindrumeReturnsTrue()
        {
            Assert.IsTrue(IsPalindrome("racecar"));
        }
        [TestMethod]
        public void PalindromeWithWhitespaceReturnsTrue()
        {
            Assert.IsTrue(IsPalindrome("race car"));
        }
        [TestMethod]
        public void PalindromeWithPunctuactionReturnsTrue()
        {
            Assert.IsTrue(IsPalindrome("!@#$%^&*()_-+=}{[]/?,\\|racecar."));
        }
        [TestMethod]
        public void PalindromeWithMixedCaseReturnsTrue()
        {
            Assert.IsTrue(IsPalindrome("aA A"));
        }
        [TestMethod]
        public void NonPalindromeWithMixedCaseReturnsFalse()
        {
            Assert.IsFalse(IsPalindrome("bA A"));
        }
        [TestMethod]
        public void SentencePalindromeReturnsTrue()
        {
            Assert.IsTrue(IsPalindrome("no x in nixon"));
        }
        [TestMethod]
        public void SentencePalindromeWithMixedCaseAndPunctuationReturnsTrue()
        {
            Assert.IsTrue(IsPalindrome("No 'X' in Nixon"));
        }       
    }
    [TestClass]
    public class Numerics
    {
        [TestMethod]
        public void NumericNonPalindromeReturnsFalse()
        {
            Assert.IsFalse(IsPalindrome(1234));
            Assert.IsFalse(1234.IsPalindrome());
        }
        [TestMethod]
        public void NumericPalindromeReturnsTrue()
        {
            Assert.IsTrue(IsPalindrome(12344321));
        }
        [TestMethod]
        public void NumericWithDecimalNonPalindromeReturnsFalse()
        {
            Assert.IsFalse(IsPalindrome(Math.PI));
            Assert.IsFalse(IsPalindrome(1.0m));
        }
        [TestMethod]
        public void NumericWithDecimalPalindromeReturnsTrue()
        {
            Assert.IsTrue(IsPalindrome(1.001));
            Assert.IsTrue(IsPalindrome(1.001m));

        }

    }
}
