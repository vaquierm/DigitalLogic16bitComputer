using DigitalLogic16bitComputer.components;
using DigitalLogic16bitComputer.components.gates;


namespace DigitalLogic16bitComputerTest.gates
{
    public class OrGateTest
    {
        [Test]
        public void NorGateTruthTable()
        {
            var inputA = new Bit();
            var inputB = new Bit();
            var orGate = new OrGate(inputA, inputB);

            Assert.That(orGate.Output.Value, Is.EqualTo(false));

            inputA.Value = true;

            Assert.That(orGate.Output.Value, Is.EqualTo(true));

            inputB.Value = true;

            Assert.That(orGate.Output.Value, Is.EqualTo(true));

            inputA.Value = false;

            Assert.That(orGate.Output.Value, Is.EqualTo(true));
        }
    }
}
