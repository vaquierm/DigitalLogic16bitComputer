namespace DigitalLogic16bitComputer.components.gates
{
    /// <summary>
    /// A XOR gate implementation
    /// </summary>
    public class XorGate
    {
        /// <summary>
        /// Output bit of the XOR gate
        /// </summary>
        public Bit Output { get; }

        readonly NotGate notGateA;
        readonly NotGate notGateB;
        readonly NandGate nandGateA;
        readonly NandGate nandGateB;
        readonly NandGate nandGateC;

        /// <summary>
        /// Initializes a new instance of the <see cref="XorGate"/> class.
        /// </summary>
        /// <param name="inputA">First input for the XOR gate</param>
        /// <param name="inputB">Second input for the XOR gate</param>
        public XorGate(Bit inputA, Bit inputB)
        {
            this.notGateA = new NotGate(inputB);
            this.notGateB = new NotGate(inputA);
            this.nandGateA = new NandGate(inputA, this.notGateA.Output);
            this.nandGateB = new NandGate(inputB, this.notGateB.Output);
            this.nandGateC = new NandGate(this.nandGateA.Output, this.nandGateB.Output);
            this.Output = this.nandGateC.Output;
        }
    }
}
