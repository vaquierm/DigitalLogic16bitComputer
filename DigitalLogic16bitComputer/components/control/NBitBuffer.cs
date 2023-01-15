namespace DigitalLogic16bitComputer.components.control
{
    public class NBitBuffer
    {
        public NBitArray NBitOutput { get; }
        public NBitArray NBitInput { get; }
        public Bit Enable { get; }
        private Buffer[] buffers;

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
