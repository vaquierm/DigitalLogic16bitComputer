using DigitalLogic16bitComputer.components.gates;

namespace DigitalLogic16bitComputer.components.arithmetic.logic
{
    /// <summary>
    /// Represents a N-bit bitwise NOT circuit for positive integers.
    /// </summary>
    public class NBitBitwiseNot
    {
        /// <summary>
        /// The output of the bitwise NOT operation.
        /// </summary>
        public NBitArray OutputNum { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="NBitBitwiseNot"/> class.
        /// </summary>
        /// <param name="num">The N-bit input number.</param>
        public NBitBitwiseNot(NBitArray num)
        {
            var outputBitArray = new Bit[num.Length];

            for (var i = 0; i < num.Length; i++)
            {
                outputBitArray[i] = new NotGate(num[i]).Output;
            }

            this.OutputNum = new NBitArray(outputBitArray);
        }
    }
}
