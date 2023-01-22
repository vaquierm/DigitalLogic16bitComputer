namespace DigitalLogic16bitComputer.components.control
{
    /// <summary>
    /// Represents a N-bit buffer circuit that connects or disconnects a N-bit input to a N-bit output based on the value of the enable bit.
    /// </summary>
    public class NBitBuffer
    {
        /// <summary>
        /// The N-bit output of the buffer circuit.
        /// </summary>
        public NBitArray NBitOutput { get; }
        /// <summary>
        /// The N-bit input of the buffer circuit.
        /// </summary>
        public NBitArray NBitInput { get; }
        /// <summary>
        /// The enable bit that controls whether the input is connected to the output or not.
        /// </summary>
        public Bit Enable { get; }
        private Buffer[] buffers;

        /// <summary>
        /// Creates a N-bit buffer circuit that connects or disconnects a N-bit input to a N-bit output based on the value of the enable bit.
        /// </summary>
        /// <param name="nBitInput">The N-bit input of the buffer circuit.</param>
        /// <param name="nBitOutput">The N-bit output of the buffer circuit.</param>
        /// <param name="enable">The enable bit that controls whether the input is connected to the output or not.</param>
        /// <exception cref="ArgumentException">Input and Output must have the same length</exception>
        public NBitBuffer(NBitArray nBitInput, NBitArray nBitOutput, Bit enable)
        {
            if (nBitInput.Length != nBitOutput.Length)
            {
                throw new ArgumentException("Input and Output must have the same length");
            }
            this.NBitInput = nBitInput;
            this.NBitOutput = nBitOutput;
            this.Enable = enable;
            this.buffers = new Buffer[nBitInput.Length];
            for (int i = 0; i < nBitInput.Length; i++)
            {
                this.buffers[i] = new Buffer(nBitInput[i], nBitOutput[i], enable);
            }
        }
    }
}
