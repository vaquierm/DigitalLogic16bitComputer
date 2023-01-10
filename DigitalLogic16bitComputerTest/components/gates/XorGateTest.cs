using DigitalLogic16bitComputer.components;
using DigitalLogic16bitComputer.components.gates;


namespace DigitalLogic16bitComputerTest.gates
{
    public class XorGateTest
    {
        [Test]
        public void XorGateTruthTable()
        {
            var inputA = new Bit();
            var inputB = new Bit();
            var xorGate = new XorGate(inputA, inputB);

            Assert.That(xorGate.Output.Value, Is.EqualTo(false));

            inputA.Value = true;

            Assert.That(xorGate.Output.Value, Is.EqualTo(true));

            inputB.Value = true;

            Assert.That(xorGate.Output.Value, Is.EqualTo(false));

            inputA.Value = false;

            Assert.That(xorGate.Output.Value, Is.EqualTo(true));
        }
    }
}
