using DigitalLogic16bitComputer.components;
using DigitalLogic16bitComputer.components.arithmetic.logic;

namespace DigitalLogic16bitComputerTest.components.arithmetic.logic
{
    public class NBitBitwiseNandTest
    {
        [TestCase("0000", "0000", "1111")]
        [TestCase("1111", "1111", "0000")]
        [TestCase("1010", "0101", "1111")]
        [TestCase("0101", "1010", "1111")]
        [TestCase("1001", "0110", "1111")]
        [TestCase("0110", "1001", "1111")]
        public void TestNBitBitwiseNand(string numA, string numB, string expected)
        {
            var nBitA = NBitArray.BinaryStringToNBitArray(numA);
            var nBitB = NBitArray.BinaryStringToNBitArray(numB);
            var nBitNand = new NBitBitwiseNand(nBitA, nBitB);

                Assert.That(nBitNand.OutputNum.ToBinaryString(), Is.EqualTo(expected));
        }
    }
}
