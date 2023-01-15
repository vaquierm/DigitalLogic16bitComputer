using DigitalLogic16bitComputer.components;
using DigitalLogic16bitComputer.components.arithmetic;

namespace DigitalLogic16bitComputerTest.components.arithmetic
{
    public class NBitMultiplierTest
    {
        [TestCase(6, 3, 8)]
        [TestCase(13, 25, 16)]
        [TestCase(4, -56, 16)]
        [TestCase(-6, 3, 8)]
        [TestCase(-13, 25, 16)]
        [TestCase(-4, -56, 16)]
        public void Multiplies(int numA, int numB, int nBits)
        {
            var numABitArray = NBitArray.IntToNBitArray(numA, nBits);
            var numBBitArray = NBitArray.IntToNBitArray(numB, nBits);

            var multiplier = new NBitMultiplier(numABitArray, numBBitArray);

            Assert.That(multiplier.OutputNum.ToInt(), Is.EqualTo(numA * numB));
            Assert.That(multiplier.FullOutputNum.ToInt(), Is.EqualTo(numA * numB));
            Assert.That(multiplier.OutputOverflow.Value, Is.EqualTo(false));
        }

        [TestCase(13, 25, 8)]
        [TestCase(4, -56, 7)]
        [TestCase(-6, 3, 4)]
        public void Overflows(int numA, int numB, int nBits)
        {
            var numABitArray = NBitArray.IntToNBitArray(numA, nBits);
            var numBBitArray = NBitArray.IntToNBitArray(numB, nBits);

            var multiplier = new NBitMultiplier(numABitArray, numBBitArray);

            Assert.That(multiplier.OutputOverflow.Value, Is.EqualTo(true));
        }
    }
}
