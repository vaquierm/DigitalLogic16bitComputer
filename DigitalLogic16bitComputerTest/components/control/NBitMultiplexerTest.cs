using DigitalLogic16bitComputer.components.control;
using DigitalLogic16bitComputer.components;

namespace DigitalLogic16bitComputerTest.components.control
{
    public class NBitMultiplexerTest
    {
        [TestCase(new bool[] { false, true, false }, new bool[] { true, false, true })]
        [TestCase(new bool[] { true, true, true, false }, new bool[] { false, false, false, false })]
        public void Test_NBitMultiplexer(bool[] inputA, bool[] inputB)
        {
            var nBitInputA = new NBitArray(inputA.Select(x => new Bit(x)).ToArray());
            var nBitInputB = new NBitArray(inputB.Select(x => new Bit(x)).ToArray());
            var selectBit = new Bit(false);
            var nBitMultiplexer = new NBitMultiplexer(nBitInputA, nBitInputB, selectBit);

            Assert.That(nBitMultiplexer.NBitOutput.Select(bit => bit.Value).ToArray(), Is.EqualTo(inputB));

            selectBit.Value = true;

            Assert.That(nBitMultiplexer.NBitOutput.Select(bit => bit.Value).ToArray(), Is.EqualTo(inputA));
        }

        [Test]
        public void InputsDifferentLength()
        {
            var inputA = new NBitArray(new Bit[] { new Bit(false), new Bit(true), new Bit(false) });
            var inputB = new NBitArray(new Bit[] { new Bit(true), new Bit(false) });
            var select = new Bit(false);
            Assert.Throws<ArgumentException>(() => new NBitMultiplexer(inputA, inputB, select));
        }
    }
}
