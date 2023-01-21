using DigitalLogic16bitComputer.components;
using DigitalLogic16bitComputer.components.arithmetic.logic;

namespace DigitalLogic16bitComputerTest.components.arithmetic.logic
{
    public class NBitBitwiseNotTest
    {
        [TestCase("0000", "1111")]
        [TestCase("1111", "0000")]
        [TestCase("1010", "0101")]
        [TestCase("0101", "1010")]
        [TestCase("1001", "0110")]
        [TestCase("0110", "1001")]
        public void TestNBitBitwiseNot(string input, string expected)
        {
            var nBitInput = NBitArray.BinaryStringToNBitArray(input);
            var nBitNot = new NBitBitwiseNot(nBitInput);

            Assert.That(nBitNot.OutputNum.ToBinaryString(), Is.EqualTo(expected));
        }
    }
}
