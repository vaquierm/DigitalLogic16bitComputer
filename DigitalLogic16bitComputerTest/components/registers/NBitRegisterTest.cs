using DigitalLogic16bitComputer.components;
using DigitalLogic16bitComputer.components.registers;

namespace DigitalLogic16bitComputerTest.components.registers
{
	public class NBitRegisterTest
	{
        [Test]
        public void RegisterInitializationToZero()
        {
            var bits = new Bit[] { new Bit(true), new Bit(true), new Bit(true) };
            var input = new NBitArray(bits);
            var clk = new Bit();
            var enable = new Bit(true);

            var register = new NBitRegister(input, clk, enable);

            Assert.That(register.Output.ToInt, Is.EqualTo(0));
        }

        [Test]
        public void RegisterChangesInput()
        {
            var input = NBitArray.IntToNBitArray(37, 8);
            var clk = new Bit();
            var enable = new Bit(true);

            var register = new NBitRegister(input, clk, enable);

            clk.Value = true;

            Assert.That(register.Output.ToInt(), Is.EqualTo(0));

            clk.Value = false;

            Assert.That(register.Output.ToInt(), Is.EqualTo(37));

            foreach (var inBit in input)
            {
                inBit.Value = false;
            }

            Assert.That(register.Output.ToInt(), Is.EqualTo(37));

            clk.Value = true;

            Assert.That(register.Output.ToInt(), Is.EqualTo(37));

            clk.Value = false;

            Assert.That(register.Output.ToInt(), Is.EqualTo(0));
        }

        [Test]
        public void RegisterNoChangesWhenDisabled()
        {
            var input = NBitArray.IntToNBitArray(37, 8);
            var clk = new Bit();
            var enable = new Bit();

            var register = new NBitRegister(input, clk, enable);

            clk.Value = true;

            Assert.That(register.Output.ToInt(), Is.EqualTo(0));

            clk.Value = false;

            Assert.That(register.Output.ToInt(), Is.EqualTo(0));

            clk.Value = true;

            Assert.That(register.Output.ToInt(), Is.EqualTo(0));

            enable.Value = true;

            Assert.That(register.Output.ToInt(), Is.EqualTo(0));

            clk.Value = false;

            Assert.That(register.Output.ToInt(), Is.EqualTo(37));
        }
    }
}

