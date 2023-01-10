using DigitalLogic16bitComputer.components;
using DigitalLogic16bitComputer.components.gates;


namespace DigitalLogic16bitComputerTest.gates
{
    public class AndGateTest
    {
        [Test]
        public void AndGateTruthTable()
        {
            var inputA = new Bit();
            var inputB = new Bit();
            var andGate = new AndGate(inputA, inputB);

            Assert.That(andGate.Output.Value, Is.EqualTo(false));

            inputA.Value = true;

            Assert.That(andGate.Output.Value, Is.EqualTo(false));

            inputB.Value = true;

            Assert.That(andGate.Output.Value, Is.EqualTo(true));

            inputA.Value = false;

            Assert.That(andGate.Output.Value, Is.EqualTo(false));
        }
    }
}
