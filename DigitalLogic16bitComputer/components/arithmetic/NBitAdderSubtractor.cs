using DigitalLogic16bitComputer.components.gates;

namespace DigitalLogic16bitComputer.components.arithmetic
{
    /// <summary>
    /// Represents a N-bit adder-subtractor circuit.
    /// </summary>
    public class NBitAdderSubtractor
    {
        /// <summary>
        /// Indicates whether the circuit is in subtraction mode.
        /// </summary>
        public Bit Subtract { get; }

        /// <summary>
        /// The N-bit output of the circuit.
        /// </summary>
        public NBitArray OutputNum { get; }

        /// <param name="numA">The first N-bit number to be added or subtracted.</param>
        /// <param name="numB">The second N-bit number to be added or subtracted.</param>
        /// <param name="subtract">A bit that determines whether the operation is addition or subtraction.</param>
        public NBitAdderSubtractor(NBitArray numA, NBitArray numB, Bit subtract)
        {
            this.Subtract = subtract;

            if (numA.Length != numB.Length)
            {
                throw new ArgumentException("Two numbers must have the same number of bits");
            }
            else if (numA.Length < 2)
            {
                throw new ArgumentException("Two numbers must both have at least two bits");
            }

            var onesComplement = new Bit[numA.Length];
            for (var i = 0; i < numA.Length; i++)
            {
                var complementXor = new XorGate(numB[i], subtract);
                onesComplement[i] = complementXor.Output;
            }

            var nBitAdder = new NBitAdder(numA, new NBitArray(onesComplement), subtract);
            this.OutputNum = nBitAdder.OutputNum;
        }
    }
}
