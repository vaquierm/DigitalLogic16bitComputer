
using DigitalLogic16bitComputer.components.control;

namespace DigitalLogic16bitComputer.components.arithmetic.shift
{
    /// <summary>
    /// Represents a N-bit left shift circuit for positive integers.
    /// </summary>
    public class NBitLeftShift
    {
        /// <summary>
        /// The output of the left shift operation
        /// </summary>
        public NBitArray OutputNum { get; }

        /// <summary>
        /// Constructs a new N-bit left shift circuit for positive integers.
        /// </summary>
        /// <param name="num">The input number to be shifted</param>
        /// <param name="shiftN">The number of bits to shift</param>
        /// <exception cref="ArgumentException">The input num must have a number of bits that is a power of 2</exception>
        public NBitLeftShift(NBitArray num, NBitArray shiftN)
        {
            var lengthLog2 = Math.Log2(shiftN.Length);

            if (lengthLog2 != (int)lengthLog2)
            {
                throw new ArgumentException("The input num must have a number of bits that is a power of 2");
            }

            var shiftNLastBits = shiftN.SubArray(shiftN.Length - (int)lengthLog2, shiftN.Length - 1);
            var shiftedResults = new NBitArray[num.Length];
            shiftedResults[0] = num;
            for (var i = 1; i < num.Length; i++)
            {
                var shiftedBits = num.SubArray(i, num.Length - 1);
                var shiftedResult = shiftedBits;
                var falseBit = new Bit(false);
                for (var j = 0; j < i; j++)
                {
                    shiftedResult = shiftedResult.Append(falseBit);
                }

                shiftedResults[i] = shiftedResult;
            }

            this.OutputNum = new NBitMultiplexer(shiftedResults, shiftNLastBits).NBitOutput;
        }
	}
}

