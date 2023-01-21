using DigitalLogic16bitComputer.components.gates;

namespace DigitalLogic16bitComputer.components.arithmetic.logic
{
    /// <summary>
    /// Represents a bitwise binary XOR operation on two N-bit numbers.
    /// </summary>
    public class NBitBitwiseXor
    {
        /// <summary>
        /// The output of the bitwise XOR operation.
        /// </summary>
        public NBitArray OutputNum { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="NBitBitwiseXor"/> class.
        /// </summary>
        /// <param name="numA">The first N-bit number.</param>
        /// <param name="numB">The second N-bit number.</param>
        public NBitBitwiseXor(NBitArray numA, NBitArray numB)
        {
            var outpuBitArray = new Bit[numA.Length];

            for (var i = 0; i < numA.Length; i++)
            {
                outpuBitArray[i] = new XorGate(numA[i], numB[i]).Output;
            }

            this.OutputNum = new NBitArray(outpuBitArray);
        }
    }
}