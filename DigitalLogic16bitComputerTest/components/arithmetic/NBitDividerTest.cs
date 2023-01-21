using DigitalLogic16bitComputer.components;
using DigitalLogic16bitComputer.components.arithmetic;

namespace DigitalLogic16bitComputerTest.components.arithmetic
{
    public class NBitDividerTest
    {
        [TestCase(6, 3, 8)]
        [TestCase(13, 25, 16)]
        [TestCase(57, 4, 16)]
        [TestCase(12, 12, 16)]
        [TestCase(56, 1, 16)]
        public void Divides(int numA, int numB, int nBits)
        {
            var numABitArray = NBitArray.IntToNBitArray(numA, nBits);
            var numBBitArray = NBitArray.IntToNBitArray(numB, nBits);

            var adderSubtracter = new NBitDivider(numABitArray, numBBitArray);

            Assert.That(adderSubtracter.OutputNum.ToInt(), Is.EqualTo(numA / numB));
            Assert.That(adderSubtracter.OutputRemainder.ToInt(), Is.EqualTo(numA % numB));
        }

        [TestCase(-7, 3, 8)]
        [TestCase(13, -25, 16)]
        [TestCase(-57, -4, 16)]
        [TestCase(-12, 12, 16)]
        [TestCase(56, -1, 16)]
        public void DividesSigned(int numA, int numB, int nBits)
        {
            var numABitArray = NBitArray.IntToNBitArray(numA, nBits);
            var numBBitArray = NBitArray.IntToNBitArray(numB, nBits);

            var adderSubtracter = new NBitDivider(numABitArray, numBBitArray);

            Assert.That(adderSubtracter.OutputNum.ToInt(), Is.EqualTo(numA / numB));
            Assert.That(adderSubtracter.OutputRemainder.ToInt(), Is.EqualTo(numA % numB));
        }
    }
}
