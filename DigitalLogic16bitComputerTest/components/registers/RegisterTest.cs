using DigitalLogic16bitComputer.components;
using DigitalLogic16bitComputer.components.registers;


namespace DigitalLogic16bitComputerTest.registers
{
    public class RegisterTest
    {
        [Test]
        public void RegisterInitializationToZero()
        {
            var input = new Bit(true);
            var clk = new Bit();
            var enable = new Bit(true);

            var register = new Register(input, clk, enable);

            Assert.That(register.Output.Value, Is.EqualTo(false));
        }

        [Test]
        public void RegisterChangesInput()
        {
            var input = new Bit(true);
            var clk = new Bit();
            var enable = new Bit(true);

            var register = new Register(input, clk, enable);

            clk.Value = true;

            Assert.That(register.Output.Value, Is.EqualTo(false));

            clk.Value = false;

            Assert.That(register.Output.Value, Is.EqualTo(true));

            input.Value = false;

            Assert.That(register.Output.Value, Is.EqualTo(true));

            clk.Value = true;

            Assert.That(register.Output.Value, Is.EqualTo(true));

            clk.Value = false;

            Assert.That(register.Output.Value, Is.EqualTo(false));
        }

        [Test]
        public void RegisterNoChangeWhenDisabled()
        {
            var input = new Bit(true);
            var clk = new Bit();
            var enable = new Bit(false);

            var register = new Register(input, clk, enable);

            clk.Value = true;

            Assert.That(register.Output.Value, Is.EqualTo(false));

            clk.Value = false;

            Assert.That(register.Output.Value, Is.EqualTo(false));

            enable.Value = true;
            clk.Value = true;
            clk.Value = false;
            enable.Value = false;
            input.Value = false;

            Assert.That(register.Output.Value, Is.EqualTo(true));

            clk.Value = true;

            Assert.That(register.Output.Value, Is.EqualTo(true));

            clk.Value = false;

            Assert.That(register.Output.Value, Is.EqualTo(true));
        }
    }
}
