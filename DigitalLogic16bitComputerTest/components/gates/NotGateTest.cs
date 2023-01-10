using DigitalLogic16bitComputer.components;
using DigitalLogic16bitComputer.components.gates;


namespace DigitalLogic16bitComputerTest.gates
{
    public class NotGateTest
    {
        [Test]
        public void NotGateTruthTable()
        {
            var input = new Bit();
            var notGate = new NotGate(input);

            Assert.That(notGate.Output.Value, Is.EqualTo(true));

            input.Value = true;

            Assert.That(notGate.Output.Value, Is.EqualTo(false));
        }
    }
}
