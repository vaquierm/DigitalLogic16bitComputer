using DigitalLogic16bitComputer.components;
using DigitalLogic16bitComputer.components.registers;


namespace DigitalLogic16bitComputerTest.registers
{
    public class DFlipFlopTest
    {
        [Test]
        public void DFlipFlopTruthTable()
        {
            var inputD = new Bit();
            var clk = new Bit();
            var dFlipFlop = new DFlipFlop(inputD, clk);

            Assert.That(dFlipFlop.Output.Value, Is.EqualTo(false));

            inputD.Value = true;

            Assert.That(dFlipFlop.Output.Value, Is.EqualTo(false));

            clk.Value = true;

            Assert.That(dFlipFlop.Output.Value, Is.EqualTo(true));

            clk.Value = false;

            Assert.That(dFlipFlop.Output.Value, Is.EqualTo(true));

            inputD.Value = false;

            Assert.That(dFlipFlop.Output.Value, Is.EqualTo(true));

            clk.Value = true;

            Assert.That(dFlipFlop.Output.Value, Is.EqualTo(false));
        }
    }
}
