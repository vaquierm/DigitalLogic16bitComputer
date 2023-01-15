using DigitalLogic16bitComputer.components;
using DigitalLogic16bitComputer.components.gates;


namespace DigitalLogic16bitComputerTest.gates
{
    public class XorGateTest
    {
        [TestCase(true, true)]
        [TestCase(true, false)]
        [TestCase(false, true)]
        [TestCase(false, false)]
        public void TruthTable(bool inA, bool inB)
        {
            var inputA = new Bit(inA);
            var inputB = new Bit(inB);
            var xorGate = new XorGate(inputA, inputB);

            Assert.That(xorGate.Output.Value, Is.EqualTo(inA ^ inB));
        }
    }
}
