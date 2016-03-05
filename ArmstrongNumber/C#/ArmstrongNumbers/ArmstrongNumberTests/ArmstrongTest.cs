using Microsoft.VisualStudio.TestTools.UnitTesting;
using Utilities;

namespace ArmstrongNumberTests
{
    [TestClass]
    public class ArmstrongTest {
        [TestMethod]
        public void AllSingleDigitNumbersAreArmstrong()
        {
            int n = 0;
            while (n < 10)
                Assert.AreEqual(true,n++.IsArmstrong());
        }

        [TestMethod]
        public void NoDoubleDigitNumbersAreArmstrong()
        {
            int n = 10;
            while (n < 100)
                Assert.AreEqual(false,n++.IsArmstrong());
        }

        [TestMethod]
        public void ThreeDigitNonArmstrongAreNotArmstrong()
        {
            Assert.AreEqual(false, 100.IsArmstrong());
        }

        [TestMethod]
        public void ThreeDigitArmstrongsAreArmstrong()
        {
            Assert.AreEqual(true, 153.IsArmstrong());
            Assert.AreEqual(true, 370.IsArmstrong());
            Assert.AreEqual(true, 371.IsArmstrong());
            Assert.AreEqual(true, 407.IsArmstrong());
        }

        [TestMethod]
        public void FourDigitArmstrongAreArmstrong()
        {
            Assert.AreEqual(true,1634.IsArmstrong());
            Assert.AreEqual(true, 8208.IsArmstrong());
            Assert.AreEqual(true, 9474.IsArmstrong());
        }

        [TestMethod]
        public void BigArmstrongAreArmstrong()
        {
            Assert.AreEqual(true, 24678051.IsArmstrong());
            Assert.AreEqual(true, 146511208.IsArmstrong());
        }
    }

    [TestClass]
    public class RaiseToPowerTest
    {
        [TestMethod]
        public void ZeroToTheZeroethPowerIsOne()
        {
            Assert.AreEqual(1, 0.Raise(0));
        }

        [TestMethod]
        public void PositiveToZeroethPowerIsZero()
        {
            Assert.AreEqual(0, 1.Raise(0));
        }

        [TestMethod]
        public void SquaredIsSquared()
        {
            Assert.AreEqual(4, 2.Raise(2));
            Assert.AreEqual(16, 4.Raise(2));
            Assert.AreEqual(100, 10.Raise(2));
            Assert.AreEqual(65536, 256.Raise(2));
        }

        [TestMethod]
        public void CubedIsCubed()
        {
            Assert.AreEqual(8, 2.Raise(3));
            Assert.AreEqual(27, 3.Raise(3));
            Assert.AreEqual(16777216, 256.Raise(3));
        }

        [TestMethod]
        public void LargePowersAreCorrect()
        {
            Assert.AreEqual(int.MaxValue, 2.Raise(31)-1);
        }
    }

    [TestClass]
    public class CountDigitTest
    {
        [TestMethod]
        public void SingleDigitReturnsOne()
        {
            Assert.AreEqual(1, 1.CountDigits());
        }

        [TestMethod]
        public void DoubleDigitsReturnsTwo()
        {
            Assert.AreEqual(2, 10.CountDigits());
        }

        [TestMethod]
        public void NumberOfDigitsReturnCorrect()
        {
            Assert.AreEqual(3, 100.CountDigits());
            Assert.AreEqual(4, 1000.CountDigits());
            Assert.AreEqual(5, 10010.CountDigits());
            Assert.AreEqual(10, 1001511000.CountDigits());
        }
    }
}
