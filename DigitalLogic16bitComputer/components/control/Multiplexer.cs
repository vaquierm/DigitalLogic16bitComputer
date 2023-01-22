using DigitalLogic16bitComputer.components.gates;

namespace DigitalLogic16bitComputer.components.control
{
    /// <summary>
    /// A Multiplexer (MUX) is a combinational logic circuit that selects one of several inputs and forwards it to the output.
    /// </summary>
    public class Multiplexer
    {
        /// <summary>
        /// The output of the multiplexer.
        /// </summary>
        public Bit Output { get; }

        /// <summary>
        /// Creates a new 2:1 multiplexer with the specified inputs and select bit.
        /// </summary>
        /// <param name="inputA">The first input bit</param>
        /// <param name="inputB">The second input bit</param>
        /// <param name="select">The select bit</param>
        public Multiplexer(Bit inputA, Bit inputB, Bit select)
        {
            var notSelect = new NotGate(select);
            var nandGateA = new NandGate(inputA, notSelect.Output);
            var nandGateB = new NandGate(inputB, select);
            var nandGateOut = new NandGate(nandGateA.Output, nandGateB.Output);
            this.Output = nandGateOut.Output;
        }

        /// <summary>
        /// Creates a new N:1 multiplexer with the specified inputs and select bits.
        /// </summary>
        /// <param name="inputs">The input bits</param>
        /// <param name="selectBits">The select bits</param>
        /// <exception cref="ArgumentException">If the number of inputs is not a power of 2 or if the number of select bits is not equal to log2(inputs.Length)</exception>
        public Multiplexer(NBitArray inputs, NBitArray selectBits)
        {
            if (inputs.Length == 2 && selectBits.Length == 1)
            {
                var mux = new Multiplexer(inputs[0], inputs[1], selectBits[0]);
                this.Output = mux.Output;
                return;
            }

            var lengthLog2 = Math.Log2(inputs.Length);
            if (lengthLog2 != (int)lengthLog2)
            {
                throw new ArgumentException("Inputs must have a power of 2 number of bits.");
            }
            else if (selectBits.Length != lengthLog2)
            {
                throw new ArgumentException("The number of input bits must equal 2^<number of input bits>");
            }

            var firstMuxRowOut = new Bit[inputs.Length / 2];
            var firstRowSelectBit = selectBits.Last();

            for (var inputIndex = 0; inputIndex < inputs.Length; inputIndex += 2)
            {
                var mux = new Multiplexer(inputs[inputIndex], inputs[inputIndex + 1], firstRowSelectBit);
                firstMuxRowOut[inputIndex / 2] = mux.Output;
            }

            var nextRow = new Multiplexer(new NBitArray(firstMuxRowOut), selectBits.SubArray(0, selectBits.Length - 2));
            this.Output = nextRow.Output;
        }
    }
}
