using DigitalLogic16bitComputer.components.gates;

namespace DigitalLogic16bitComputer.components.arithmetic.logic
{
    /// <summary>
    /// Represents a N-bit bitwise NAND circuit for two N-bit arrays of integers.
    /// </summary>
    public class NBitBitwiseNand
    {
        /// <summary>
        /// The output of the bitwise NAND operation.
        /// </summary>
        public NBitArray OutputNum { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="NBitBitwiseNand"/> class.
        /// Performs a bitwise NAND operation on two N-bit arrays.
        /// </summary>
        /// <param name="numA">The first N-bit array to perform the operation on.</param>
        /// <param name="numB">The second N-bit array to perform the operation on.</param>
        public NBitBitwiseNand(NBitArray numA, NBitArray numB)
        {
            var outputBitArray = new Bit[numA.Length];

            for (var i = 0; i < numA.Length; i++)
            {
                outputBitArray[i] = new NandGate(numA[i], numB[i]).Output;
            }

            this.OutputNum = new NBitArray(outputBitArray);
        }
    }
}
