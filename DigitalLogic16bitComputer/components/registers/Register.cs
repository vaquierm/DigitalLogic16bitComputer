using DigitalLogic16bitComputer.components.gates;

namespace DigitalLogic16bitComputer.components.registers
{
    public class Register
    {
        readonly DFlipFlop inputFlipFlop;
        readonly DFlipFlop outputFlipFlop;

        Bit Input { get; }

        public Bit Output { get; }

        public Register(Bit input, Bit clk, Bit enable)
        {
            this.Input = input;
            var notClk = new NotGate(clk);
            var andEnableInput = new AndGate(clk, enable);
            var andEnableOutput = new AndGate(notClk.Output, enable);
            this.inputFlipFlop = new DFlipFlop(input, andEnableInput.Output);
            this.outputFlipFlop = new DFlipFlop(this.inputFlipFlop.Output, andEnableOutput.Output);
            this.Output = this.outputFlipFlop.Output;
        }
    }
}
