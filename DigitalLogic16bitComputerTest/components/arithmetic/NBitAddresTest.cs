using DigitalLogic16bitComputer.components.arithmetic;
using DigitalLogic16bitComputer.components;

namespace DigitalLogic16bitComputerTest.components.arithmetic
{
    public class NBitAddresTest
    {
        [TestCase(2, 4, 5, false, 6, false)]
        [TestCase(2, 4, 5, true, 7, false)]
        [TestCase(271, 80, 16, false, 351, false)]
        [TestCase(5, 12, 5, false, -15, true)]
        public void AdditionWorks(int numA, int numB, int numBits, bool inputCarry, int expected, bool overflow)
        {
            var numABits = NBitArray.IntToNBitArray(numA, numBits);
            var numBBits = NBitArray.IntToNBitArray(numB, numBits);

            var adder = new NBitAdder(numABits, numBBits, new Bit(inputCarry));
            Assert.That(adder.OutputNum.ToInt(), Is.EqualTo(expected));
            Assert.That(adder.OutputOverflow.Value, Is.EqualTo(overflow));
        }
    }
}
