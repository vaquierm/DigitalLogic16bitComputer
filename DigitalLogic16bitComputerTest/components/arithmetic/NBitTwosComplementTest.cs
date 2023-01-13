using DigitalLogic16bitComputer.components.arithmetic;
using DigitalLogic16bitComputer.components;

namespace DigitalLogic16bitComputerTest.components.arithmetic
{
    public class NBitTwosComplementTest
    {
        [TestCase(12, 16)]
        [TestCase(6, 8)]
        [TestCase(-4, 16)]
        [TestCase(-34, 16)]
        public void Complements(int number, int nBits)
        {
            var bitArrayNumber = NBitArray.IntToNBitArray(number, nBits);
            var nBitTwosComplement = new NBitTwosComplement(bitArrayNumber);

            Assert.That(nBitTwosComplement.OutputNum.ToInt(), Is.EqualTo(-number));
        }

        public void Throws()
        {
            var bitArrayNumber = new NBitArray(new Bit[] { new Bit(true) });
            Assert.Throws(typeof(ArgumentException), () => new NBitTwosComplement(bitArrayNumber));
        }
    }
}
