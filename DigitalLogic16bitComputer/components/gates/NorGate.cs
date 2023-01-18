namespace DigitalLogic16bitComputer.components.gates
{
    /// <summary>
    /// A logical NOR gate implementation
    /// </summary>
    public class NorGate
    {
        /// <summary>
        /// The output of the Nor gate
        /// </summary>
        public Bit Output { get; }

        readonly OrGate OrGate;
        readonly NotGate NotGate;

        /// <summary>
        /// Initializes a new instance of the NorGate class with two input bits
        /// </summary>
        /// <param name="inputA">The first input bit</param>
        /// <param name="inputB">The second input bit</param>
        public NorGate(Bit inputA, Bit inputB)
        {
            this.OrGate = new OrGate(inputA, inputB);
            this.NotGate = new NotGate(this.OrGate.Output);
            this.Output = this.NotGate.Output;
        }

        /// <summary>
        /// Initializes a new instance of the NorGate class with an NBitArray of inputs
        /// </summary>
        /// <param name="inputs">The NBitArray of inputs</param>
        public NorGate(NBitArray inputs)
        {
            if (inputs.Length < 2)
            {
                throw new ArgumentException("Not enough inputs");
            }
            else if (inputs.Length == 2)
            {
                this.OrGate = new OrGate(inputs[0], inputs[1]);
            }
            else
            {
                this.OrGate = new OrGate(inputs);
            }
            
            this.NotGate = new NotGate(this.OrGate.Output);
            this.Output = this.NotGate.Output;
        }
    }
}
