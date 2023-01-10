using DigitalLogic16bitComputer.components;
using DigitalLogic16bitComputer.components.gates;


namespace DigitalLogic16bitComputerTest.gates
{
    public class NorGateTest
    {
        [Test]
        public void NorGateTruthTable()
        {
            var inputA = new Bit();
            var inputB = new Bit();
            var norGate = new NorGate(inputA, inputB);

            Assert.That(norGate.Output.Value, Is.EqualTo(true));

            inputA.Value = true;

            Assert.That(norGate.Output.Value, Is.EqualTo(false));

            inputB.Value = true;

            Assert.That(norGate.Output.Value, Is.EqualTo(false));

            inputA.Value = false;

            Assert.That(norGate.Output.Value, Is.EqualTo(false));
        }
    }
}
