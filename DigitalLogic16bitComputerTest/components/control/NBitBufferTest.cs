using DigitalLogic16bitComputer.components.control;
using DigitalLogic16bitComputer.components;


namespace DigitalLogic16bitComputerTest.components
{
    public class NBitBufferTest
    {
        [TestCase(new bool[] { true, true, true }, new bool[] { false, false, false }, true)]
        [TestCase(new bool[] { true, false, true }, new bool[] { false, true, false }, false)]
        [TestCase(new bool[] { false, true, false }, new bool[] { true, true, true }, true)]
        public void NBitBufferInitializesCorrectly(bool[] inputVals, bool[] outputVals, bool enableVal)
        {
            var nBitInput = new NBitArray(inputVals.Select(x => new Bit(x)).ToArray());
            var nBitOutput = new NBitArray(outputVals.Select(x => new Bit(x)).ToArray());
            var enable = new Bit(enableVal);

            var nBitBuffer = new NBitBuffer(nBitInput, nBitOutput, enable);

            for (int i = 0; i < nBitInput.Length; i++)
            {
                Assert.That(nBitBuffer.NBitOutput[i].Value, Is.EqualTo(enableVal && inputVals[i]));
            }
        }

        [TestCase(new bool[] { true, false, true })]
        [TestCase(new bool[] { false, true, false })]
        public void NBitBufferEnablePassesInputToOutput(bool[] inputVals)
        {
            var nBitInput = new NBitArray(inputVals.Select(x => new Bit(x)).ToArray());
            var nBitOutput = new NBitArray(inputVals.Select(x => new Bit(!x)).ToArray());
            var enable = new Bit(false);

            var nBitBuffer = new NBitBuffer(nBitInput, nBitOutput, enable);

            enable.Value = true;

            for (int i = 0; i < nBitInput.Length; i++)
            {
                Assert.That(nBitBuffer.NBitOutput[i].Value, Is.EqualTo(inputVals[i]));
            }
        }

        [Test]
        public void NBitBufferDisableStopsPassingInputToOutput()
        {
            var inputVals = new bool[] { true, true, true };
            var nBitInput = new NBitArray(inputVals.Select(x => new Bit(x)).ToArray());
            var nBitOutput = new NBitArray(inputVals.Select(x => new Bit()).ToArray());
            var enable = new Bit(true);

            var nBitBuffer = new NBitBuffer(nBitInput, nBitOutput, enable);

            enable.Value = false;

            for (int i = 0; i < nBitInput.Length; i++)
            {
                Assert.That(nBitBuffer.NBitOutput[i].Value, Is.EqualTo(false));
            }
        }
    }
}
