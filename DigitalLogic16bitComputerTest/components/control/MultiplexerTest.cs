using DigitalLogic16bitComputer.components.control;
using DigitalLogic16bitComputer.components;


namespace DigitalLogic16bitComputerTest.components.control
{
    public class MultiplexerTest
    {
        [TestCase(true, true, true)]
        [TestCase(true, true, false)]
        [TestCase(true, false, true)]
        [TestCase(true, false, false)]
        [TestCase(false, true, true)]
        [TestCase(false, true, false)]
        [TestCase(false, false, true)]
        [TestCase(false, false, false)]
        public void MultiplexerTruthTable(bool inputAVal, bool inputBVal, bool selectVal)
        {
            var inputA = new Bit(inputAVal);
            var inputB = new Bit(inputBVal);
            var select = new Bit(selectVal);

            var multiplexer = new Multiplexer(inputA, inputB, select);

            if (select.Value)
            {
                Assert.That(multiplexer.Output.Value, Is.EqualTo(inputB.Value));
            }
            else
            {
                Assert.That(multiplexer.Output.Value, Is.EqualTo(inputA.Value));

            }
        }

        [TestCase("11111111")]
        [TestCase("10011001")]
        [TestCase("1011")]
        public void NTo1MultiplexerTest(string input)
        {
            var selectBitsArray = new Bit[(int)Math.Log2(input.Length)];
            for (int i = 0; i < selectBitsArray.Length; i++)
            {
                selectBitsArray[i] = new Bit();
            }
            var inputBits = NBitArray.BinaryStringToNBitArray(input);
            var selectBits = new NBitArray(selectBitsArray);

            var multiplexer = new Multiplexer(inputBits, selectBits);

            for (var i = 0; i < inputBits.Length; i++)
            {
                var desiredInputBits = NBitArray.IntToNBitArray(i, selectBits.Length + 1);
                for (var j = 1; j < desiredInputBits.Length; j++)
                {
                    selectBits[j - 1].Value = desiredInputBits[j].Value;
                }
                Assert.That(multiplexer.Output.Value, Is.EqualTo(inputBits[i].Value));
            }
        }

        [Test]
        public void InputsNotPowerOfTwo()
        {
            var inputArray = new NBitArray(new Bit[] { new Bit(), new Bit(), new Bit() });
            var selectArray = new NBitArray(new Bit[] { new Bit() });
            Assert.Throws<ArgumentException>(() => new Multiplexer(inputArray, selectArray));
        }

        [Test]
        public void SelectBitsNotEqualInputLog2()
        {
            var inputArray = new NBitArray(new Bit[] { new Bit(), new Bit(), new Bit(), new Bit() });
            var selectArray = new NBitArray(new Bit[] { new Bit(), new Bit(), new Bit() });
            Assert.Throws<ArgumentException>(() => new Multiplexer(inputArray, selectArray));
        }
    }
}
