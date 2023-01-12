using DigitalLogic16bitComputer.components;
using Buffer = DigitalLogic16bitComputer.components.Buffer;

namespace DigitalLogic16bitComputerTest.components
{
    public class BufferTest
    {
        [TestCase(true, true)]
        [TestCase(true, false)]
        [TestCase(false, true)]
        [TestCase(false, false)]
        public void BufferInitializesCorrectly(bool inputVal, bool enableVal)
        {
            var input = new Bit(inputVal);
            var enable = new Bit(enableVal);

            var output = new Bit();
            var buffer = new Buffer(input, output, enable);

            Assert.That(buffer.Output.Value, Is.EqualTo(enableVal && inputVal));
        }

        [TestCase(true)]
        [TestCase(false)]
        public void BufferEnablePassesInputToOutput(bool inputVal)
        {
            var input = new Bit(inputVal);
            var enable = new Bit(false);

            var output = new Bit(!inputVal);
            var buffer = new Buffer(input, output, enable);

            enable.Value = true;

            Assert.That(buffer.Output.Value, Is.EqualTo(inputVal));
        }

        [Test]
        public void BufferDisableStopsPassingInputToOutput()
        {
            var input = new Bit(true);
            var enable = new Bit(true);

            var output = new Bit();

            var buffer = new Buffer(input, output, enable);

            enable.Value = false;

            Assert.That(buffer.Output.Value, Is.EqualTo(false));
        }
    }
}
