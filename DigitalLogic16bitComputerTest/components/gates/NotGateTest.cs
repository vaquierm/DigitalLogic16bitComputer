using DigitalLogic16bitComputer.components;
using DigitalLogic16bitComputer.components.gates;


namespace DigitalLogic16bitComputerTest.gates
{
    public class NotGateTest
    {
        [TestCase(true)]
        [TestCase(false)]
        public void TruthTable(bool inputVal)
        {
            var input = new Bit(inputVal);
            var notGate = new NotGate(input);

            Assert.That(notGate.Output.Value, Is.EqualTo(!inputVal));
        }

        [Test]
        public void InputsUpdateGateOutput()
        {
            var input = new Bit();
            var notGate = new NotGate(input);

            Assert.That(notGate.Output.Value, Is.EqualTo(true));

            input.Value = true;

            Assert.That(notGate.Output.Value, Is.EqualTo(false));
        }
    }
}
