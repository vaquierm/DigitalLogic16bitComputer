using DigitalLogic16bitComputer.components.control;

namespace DigitalLogic16bitComputer.components.arithmetic.shift
{
    /// <summary>
    /// Represents a N-bit right shift circuit for positive integers.
    /// </summary>
    public class NBitRightShift
    {
        /// <summary>
        /// The output number after the right shift operation.
        /// </summary>
        public NBitArray OutputNum { get; }

		/// <summary>
		/// Initializes a new instance of the <see cref="NBitRightShift"/> class.
		/// </summary>
		/// <param name="num">The number to shift</param>
		/// <param name="shiftN">The number of bits to shift by</param>
		/// <param name="shiftedOutBitsToShiftedInBitsDelegate">A delegate that converts the shifted out bits to the shifted in bits</param>
		/// <exception cref="ArgumentException">The input num must have a number of bits that is a power of 2</exception>
		public NBitRightShift(NBitArray num, NBitArray shiftN, Func<NBitArray, Bit, NBitArray> shiftedOutBitsToShiftedInBitsDelegate)
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
				var shiftedOutBits = num.SubArray(num.Length - i, num.Length - 1);
				var shiftedBits = num.SubArray(0, num.Length - 1 - i);
				var shiftedResult = shiftedBits;
				var shiftedInBits = shiftedOutBitsToShiftedInBitsDelegate(shiftedOutBits, num[0]);
				for (var j = shiftedInBits.Length - 1; j >= 0; j--)
				{
					shiftedResult = shiftedResult.Prepend(shiftedInBits[j]);
				}

				shiftedResults[i] = shiftedResult;
			}

			this.OutputNum = new NBitMultiplexer(shiftedResults, shiftNLastBits).NBitOutput;
		}
	}
}

