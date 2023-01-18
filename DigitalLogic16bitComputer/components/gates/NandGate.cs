namespace DigitalLogic16bitComputer.components.gates
{
    /// <summary>
    /// A logical NAND gate implementation
    /// </summary>
    public class NandGate
    {
        /// <summary>
        /// The output of the NAND gate
        /// </summary>
        public Bit Output { get; }

        readonly AndGate AndGate;
        readonly NotGate NotGate;

        /// <summary>
        /// Initializes a new instance of the NandGate class with two input bits
        /// </summary>
        /// <param name="inputA">The first input bit</param>
        /// <param name="inputB">The second input bit</param>
        public NandGate(Bit inputA, Bit inputB)
        {
            this.AndGate = new AndGate(inputA, inputB);
            this.NotGate = new NotGate(this.AndGate.Output);
            this.Output = this.NotGate.Output;
        }

        /// <summary>
        /// Initializes a new instance of the NandGate class with an NBitArray of inputs
        /// </summary>
        /// <param name="inputs">The NBitArray of inputs</param>
        public NandGate(NBitArray inputs)
        {
            if (inputs.Length < 2)
            {
                throw new ArgumentException("Not enough inputs");
            }
            else if (inputs.Length == 2)
            {
                this.AndGate = new AndGate(inputs[0], inputs[1]);
            }
            else
            {
                this.AndGate = new AndGate(inputs);
            }

            this.NotGate = new NotGate(this.AndGate.Output);
            this.Output = this.NotGate.Output;
        }
    }
}
