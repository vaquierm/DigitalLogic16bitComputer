using DigitalLogic16bitComputer.components;
using DigitalLogic16bitComputer.components.gates;


namespace DigitalLogic16bitComputerTest.gates
{
    public class AndGateTest
    {
        [TestCase(true, true)]
        [TestCase(true, false)]
        [TestCase(false, true)]
        [TestCase(false, false)]
        public void TruthTable(bool inA, bool inB)
        {
            var inputA = new Bit(inA);
            var inputB = new Bit(inB);
            var andGate = new AndGate(inputA, inputB);

            Assert.That(andGate.Output.Value, Is.EqualTo(inA && inB));
        }

        [TestCase(new bool[4] { true, true, false, true })]
        [TestCase(new bool[3] { false, false, false })]
        [TestCase(new bool[2] { true, true })]
        public void MultiInput(bool[] inputs)
        {
            var inputBits = new NBitArray(inputs.Select(input => new Bit(input)).ToArray());
            var andGate = new AndGate(inputBits);

            Assert.That(andGate.Output.Value, Is.EqualTo(inputs.All(input => input)));
        }

        [Test]
        public void InputsUpdateGateOutput()
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
