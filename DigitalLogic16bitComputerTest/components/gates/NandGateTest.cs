using DigitalLogic16bitComputer.components;
using DigitalLogic16bitComputer.components.gates;


namespace DigitalLogic16bitComputerTest.gates
{
    public class NandGateTest
    {
        [Test]
        public void NandGateTruthTable()
        {
            var inputA = new Bit();
            var inputB = new Bit();
            var nandGate = new NandGate(inputA, inputB);

            Assert.That(nandGate.Output.Value, Is.EqualTo(true));

            inputA.Value = true;

            Assert.That(nandGate.Output.Value, Is.EqualTo(true));

            inputB.Value = true;

            Assert.That(nandGate.Output.Value, Is.EqualTo(false));

            inputA.Value = false;

            Assert.That(nandGate.Output.Value, Is.EqualTo(true));
        }
    }
}
