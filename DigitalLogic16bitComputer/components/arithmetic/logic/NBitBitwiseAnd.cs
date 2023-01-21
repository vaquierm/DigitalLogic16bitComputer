using DigitalLogic16bitComputer.components.gates;

namespace DigitalLogic16bitComputer.components.arithmetic.logic
{
    /// <summary>
    /// Represents a N-bit bitwise AND circuit for positive integers.
    /// </summary>
    public class NBitBitwiseAnd
    {
        /// <summary>
        /// The result of the bitwise AND operation.
        /// </summary>
        public NBitArray OutputNum { get; }

        /// <summary>
        /// Performs a bitwise AND operation on two N-bit arrays of positive integers.
        /// </summary>
        /// <param name="numA">The first N-bit array of positive integers</param>
        /// <param name="numB">The second N-bit array of positive integers</param>
        public NBitBitwiseAnd(NBitArray numA, NBitArray numB)
        {
            var outpuBitArray = new Bit[numA.Length];

            for (var i = 0; i < numA.Length; i++)
            {
                outpuBitArray[i] = new AndGate(numA[i], numB[i]).Output;
            }

            this.OutputNum = new NBitArray(outpuBitArray);
        }
    }
}
