using DigitalLogic16bitComputer.components.gates;

namespace DigitalLogic16bitComputer.components.arithmetic.logic
{
    /// <summary>
    /// Represents a N-bit bitwise OR circuit for positive integers.
    /// </summary>
    public class NBitBitwiseOr
    {
        /// <summary>
        /// The output of the bitwise OR operation.
        /// </summary>
        public NBitArray OutputNum { get; }

        /// <summary>
        /// Creates a new N-bit bitwise OR circuit for two positive integers.
        /// </summary>
        /// <param name="numA">The first number.</param>
        /// <param name="numB">The second number.</param>
        public NBitBitwiseOr(NBitArray numA, NBitArray numB)
        {
            var outpuBitArray = new Bit[numA.Length];

            for (var i = 0; i < numA.Length; i++)
            {
                outpuBitArray[i] = new OrGate(numA[i], numB[i]).Output;
            }

            this.OutputNum = new NBitArray(outpuBitArray);
        }
    }
}