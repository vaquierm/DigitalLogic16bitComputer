using DigitalLogic16bitComputer.components.arithmetic;
using DigitalLogic16bitComputer.components;

namespace DigitalLogic16bitComputerTest.components.arithmetic
{
    public class NBitAdderSubtracterTest
    {
        [TestCase(5, 14, 10)]
        [TestCase(5, -14, 10)]
        [TestCase(-5, -14, 10)]
        [TestCase(-5, 14, 10)]
        public void Adds(int numA, int numB, int nBits)
        {
            var numABitArray = NBitArray.IntToNBitArray(numA, nBits);
            var numBBitArray = NBitArray.IntToNBitArray(numB, nBits);

            var adderSubtracter = new NBitAdderSubtracter(numABitArray, numBBitArray, new Bit(false));

            Assert.That(adderSubtracter.OutputNum.ToInt(), Is.EqualTo(numA + numB));
        }

        [TestCase(5, 14, 10)]
        [TestCase(5, -14, 10)]
        [TestCase(-5, -14, 10)]
        [TestCase(-5, 14, 10)]
        public void Subtract(int numA, int numB, int nBits)
        {
            var numABitArray = NBitArray.IntToNBitArray(numA, nBits);
            var numBBitArray = NBitArray.IntToNBitArray(numB, nBits);

            var adderSubtracter = new NBitAdderSubtracter(numABitArray, numBBitArray, new Bit(true));

            Assert.That(adderSubtracter.OutputNum.ToInt(), Is.EqualTo(numA - numB));
        }
    }
}
