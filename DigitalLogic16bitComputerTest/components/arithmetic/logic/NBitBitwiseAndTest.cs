using DigitalLogic16bitComputer.components;
using DigitalLogic16bitComputer.components.arithmetic.logic;

namespace DigitalLogic16bitComputerTest.components.arithmetic.logic
{
    public class NBitBitwiseAndTest
    {
        [TestCase("0000", "0000", "0000")]
        [TestCase("1111", "1111", "1111")]
        [TestCase("1010", "0101", "0000")]
        [TestCase("0101", "1010", "0000")]
        [TestCase("1001", "0110", "0000")]
        [TestCase("0110", "1001", "0000")]
        public void TestNBitBitwiseAnd(string numA, string numB, string expected)
        {
            var nBitA = NBitArray.BinaryStringToNBitArray(numA);
            var nBitB = NBitArray.BinaryStringToNBitArray(numB);
            var nBitAnd = new NBitBitwiseAnd(nBitA, nBitB);

            Assert.That(nBitAnd.OutputNum.ToBinaryString(), Is.EqualTo(expected));
        }
    }
}
