using DigitalLogic16bitComputer.components;
using DigitalLogic16bitComputer.components.gates;


namespace DigitalLogic16bitComputerTest.gates
{
    public class NandGateTest
    {
        [TestCase(true, true)]
        [TestCase(true, false)]
        [TestCase(false, true)]
        [TestCase(false, false)]
        public void TruthTable(bool inA, bool inB)
        {
            var inputA = new Bit(inA);
            var inputB = new Bit(inB);
            var nandGate = new NandGate(inputA, inputB);

            Assert.That(nandGate.Output.Value, Is.EqualTo(!(inA && inB)));
        }

        [TestCase(new bool[4] { true, true, false, true })]
        [TestCase(new bool[3] { false, false, false })]
        [TestCase(new bool[2] { true, true })]
        public void MultiInput(bool[] inputs)
        {
            var inputBits = new NBitArray(inputs.Select(input => new Bit(input)).ToArray());
            var nandGate = new NandGate(inputBits);

            Assert.That(nandGate.Output.Value, Is.EqualTo(inputs.Any(input => !input)));
        }
    }
}
