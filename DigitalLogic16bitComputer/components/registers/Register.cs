using DigitalLogic16bitComputer.components.gates;

namespace DigitalLogic16bitComputer.components.registers
{
    /// <summary>
    /// A class that represents a register that stores a single bit.
    /// </summary>
    public class Register
    {
        /// <summary>
        /// A D-flip-flop that serves as the input for the register.
        /// </summary>
        readonly DFlipFlop inputFlipFlop;

        /// <summary>
        /// A D-flip-flop that serves as the output for the register.
        /// </summary>
        readonly DFlipFlop outputFlipFlop;

        /// <summary>
        /// The input bit for the register.
        /// </summary>
        Bit Input { get; }

        /// <summary>
        /// The output bit for the register.
        /// </summary>
        public Bit Output { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Register"/> class.
        /// </summary>
        /// <param name="input">The input bit for the register.</param>
        /// <param name="clk">The clock input for the register.</param>
        /// <param name="enable">The enable input for the register.</param>
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
