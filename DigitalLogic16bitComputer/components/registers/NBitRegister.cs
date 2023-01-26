
namespace DigitalLogic16bitComputer.components.registers
{
    /// <summary>
    /// A class that represents a register that stores an N-bit number.
    /// </summary>
    public class NBitRegister
    {
        /// <summary>
        /// The input N-bit number for the register.
        /// </summary>
        NBitArray Input { get; }

        /// <summary>
        /// The output N-bit number for the register.
        /// </summary>
        public NBitArray Output { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="NBitRegister"/> class.
        /// </summary>
        /// <param name="input">The input N-bit number for the register.</param>
        /// <param name="clk">The clock input for the register.</param>
        /// <param name="enable">The enable input for the register.</param>
        public NBitRegister(NBitArray input, Bit clk, Bit enable)
        {
            this.Input = input;
            var registers = new Register[input.Length];
            var outputBits = new Bit[input.Length];
            for (var i = 0; i < input.Length; i++)
            {
                registers[i] = new Register(input[i], clk, enable);
                outputBits[i] = registers[i].Output;
            }

            this.Output = new NBitArray(outputBits);
        }
    }
}