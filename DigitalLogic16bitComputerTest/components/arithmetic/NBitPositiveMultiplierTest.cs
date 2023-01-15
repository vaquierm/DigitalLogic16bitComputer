using DigitalLogic16bitComputer.components;
using DigitalLogic16bitComputer.components.arithmetic;

namespace DigitalLogic16bitComputerTest.components.arithmetic
{
    public class NBitPositiveMultiplierTest
    {
        [TestCase(6, 3, 8)]
        [TestCase(13, 25, 16)]
        [TestCase(4, 56, 16)]

        public void Multiplies(int numA, int numB, int nBits)
        {
            var numABitArray = NBitArray.IntToNBitArray(numA, nBits);
            var numBBitArray = NBitArray.IntToNBitArray(numB, nBits);

            var adderSubtracter = new NBitPositiveMultiplier(numABitArray, numBBitArray);

            Assert.That(adderSubtracter.FullOutputNum.ToInt(), Is.EqualTo(numA * numB));
            Assert.That(adderSubtracter.OutputNum.ToInt(), Is.EqualTo(numA * numB));
            Assert.That(adderSubtracter.OutputOverflow.Value, Is.EqualTo(false));
        }

        [TestCase(6, 3, 4)]
        [TestCase(13, 25, 7)]
        [TestCase(4, 56, 7)]

        public void MultipliesOverflow(int numA, int numB, int nBits)
        {
            var numABitArray = NBitArray.IntToNBitArray(numA, nBits);
            var numBBitArray = NBitArray.IntToNBitArray(numB, nBits);

            var adderSubtracter = new NBitPositiveMultiplier(numABitArray, numBBitArray);

            Assert.That(adderSubtracter.FullOutputNum.ToInt(), Is.EqualTo(numA * numB));
            Assert.That(adderSubtracter.OutputOverflow.Value, Is.EqualTo(true));
        }
    }
}
