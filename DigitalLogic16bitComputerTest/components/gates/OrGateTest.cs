using DigitalLogic16bitComputer.components;
using DigitalLogic16bitComputer.components.gates;


namespace DigitalLogic16bitComputerTest.gates
{
    public class OrGateTest
    {
        [TestCase(true, true)]
        [TestCase(true, false)]
        [TestCase(false, true)]
        [TestCase(false, false)]
        public void TruthTable(bool inA, bool inB)
        {
            var inputA = new Bit(inA);
            var inputB = new Bit(inB);
            var orGate = new OrGate(inputA, inputB);

            Assert.That(orGate.Output.Value, Is.EqualTo(inA || inB));
        }

        [TestCase(new bool[4] { true, true, false, true })]
        [TestCase(new bool[3] { false, false, false })]
        [TestCase(new bool[2] { true, true })]
        public void MultiInput(bool[] inputs)
        {
            var inputBits = new NBitArray(inputs.Select(input => new Bit(input)).ToArray());
            var orGate = new OrGate(inputBits);

            Assert.That(orGate.Output.Value, Is.EqualTo(inputs.Any(input => input)));
        }

        [Test]
        public void InputsUpdateGateOutput()
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
