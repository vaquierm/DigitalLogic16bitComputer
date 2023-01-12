using DigitalLogic16bitComputer.components;


namespace DigitalLogic16bitComputerTest.components
{
    public class MultiPlexerTest
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
                Assert.That(multiplexer.Output.Value, Is.EqualTo(inputA.Value));
            }
            else
            {
                Assert.That(multiplexer.Output.Value, Is.EqualTo(inputB.Value));

            }
        }
    }
}
