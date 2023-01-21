using DigitalLogic16bitComputer.components.gates;

namespace DigitalLogic16bitComputer.components.arithmetic.logic
{
    /// <summary>
    /// Represents a N-bit bitwise NOR circuit for two N-bit arrays of integers.
    /// </summary>
    public class NBitBitwiseNor
    {
        /// <summary>
        /// The output of the bitwise NOR operation.
        /// </summary>
        public NBitArray OutputNum { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="NBitBitwiseNor"/> class.
        /// Performs a bitwise NOR operation on two N-bit arrays.
        /// </summary>
        /// <param name="numA">The first N-bit array to perform the operation on.</param>
        /// <param name="numB">The second N-bit array to perform the operation on.</param>
        public NBitBitwiseNor(NBitArray numA, NBitArray numB)
        {
            var outputBitArray = new Bit[numA.Length];

            for (var i = 0; i < numA.Length; i++)
            {
                outputBitArray[i] = new NorGate(numA[i], numB[i]).Output;
            }

            this.OutputNum = new NBitArray(outputBitArray);
        }
    }
}
