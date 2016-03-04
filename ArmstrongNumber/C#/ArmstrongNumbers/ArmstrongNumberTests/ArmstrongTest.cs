using ArmstrongNumber;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ArmstrongNumberTests
{
    [TestClass]
    public class ArmstrongTest {
        [TestMethod]
        public void ZeroIsArmstrongNumber()
        {
            Assert.IsTrue(0.IsArmstrong());
        }

        [TestMethod]
        public void OneIsArmstrongNumber()
        {
            Assert.IsTrue(1.IsArmstrong());
        }

        [TestMethod]
        public void NoNumberAboveOneAndBelowTenIsArmstrong()
        {
            Assert.IsFalse(2.IsArmstrong());
        }

        [TestMethod]
        public void NonArmstrongNumberIsArmstrong()
        {
            Assert.IsFalse(999.IsArmstrong());
        }

        [TestMethod]
        public void ArmstrongNumberIsArmstrong()
        {
            Assert.IsTrue(407.IsArmstrong());
        }
    }
}
