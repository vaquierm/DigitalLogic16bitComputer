using DigitalLogic16bitComputer.components.control;
using DigitalLogic16bitComputer.components;

namespace DigitalLogic16bitComputerTest.components.control
{
    public class NBitMultiplexerTest
    {
        [TestCase(new bool[] { false, true, false }, new bool[] { true, false, true })]
        [TestCase(new bool[] { true, true, true, false }, new bool[] { false, false, false, false })]
        public void NBitMultiplexer(bool[] inputA, bool[] inputB)
        {
            var nBitInputA = new NBitArray(inputA.Select(x => new Bit(x)).ToArray());
            var nBitInputB = new NBitArray(inputB.Select(x => new Bit(x)).ToArray());
            var selectBit = new Bit(false);
            var nBitMultiplexer = new NBitMultiplexer(nBitInputA, nBitInputB, selectBit);

            Assert.That(nBitMultiplexer.NBitOutput.Select(bit => bit.Value).ToArray(), Is.EqualTo(inputA));

            selectBit.Value = true;

            Assert.That(nBitMultiplexer.NBitOutput.Select(bit => bit.Value).ToArray(), Is.EqualTo(inputB));
        }

        [Test]
        public void NTo1MultiplexerTest()
        {
            var inputs = new string[] { "1111", "0101", "0000", "1010" };
            var selectBitsArray = new Bit[(int)Math.Log2(inputs.Length)];
            for (int i = 0; i < selectBitsArray.Length; i++)
            {
                selectBitsArray[i] = new Bit();
            }
            var inputBits = inputs.Select(input => NBitArray.BinaryStringToNBitArray(input)).ToArray();
            var selectBits = new NBitArray(selectBitsArray);

            var multiplexer = new NBitMultiplexer(inputBits, selectBits);

            for (var i = 0; i < inputBits.Length; i++)
            {
                var desiredInputBits = NBitArray.IntToNBitArray(i, selectBits.Length + 1);
                for (var j = 1; j < desiredInputBits.Length; j++)
                {
                    selectBits[j - 1].Value = desiredInputBits[j].Value;
                }
                Assert.That(multiplexer.NBitOutput.ToBinaryString(), Is.EqualTo(inputBits[i].ToBinaryString()));
            }
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
