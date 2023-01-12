using DigitalLogic16bitComputer.components;
using DigitalLogic16bitComputer.components.arithmetic;

namespace DigitalLogic16bitComputerTest.components.arithmetic
{
    public class FullAdderTest
    {
        [TestCase(true, true, true, true, true)]
        [TestCase(true, true, false, false, true)]
        [TestCase(true, false, true, false, true)]
        [TestCase(true, false, false, true, false)]
        [TestCase(false, true, true, false, true)]
        [TestCase(false, true, false, true, false)]
        [TestCase(false, false, true, true, false)]
        [TestCase(false, false, false, false, false)]
        public void FullAdderTruthTable(bool inputAVal, bool inputBVal, bool inputCaryVal, bool outputExpected, bool outputCarryExpected)
        {
            var inputA = new Bit(inputAVal);
            var inputB = new Bit(inputBVal);
            var inputCary = new Bit(inputCaryVal);

            var fullAdder = new FullAdder(inputA, inputB, inputCary);
            
            Assert.That(fullAdder.Output.Value, Is.EqualTo(outputExpected));
            Assert.That(fullAdder.OutputCarry.Value, Is.EqualTo(outputCarryExpected));
        }
    }
}
