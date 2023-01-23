using DigitalLogic16bitComputer.components.control;
using DigitalLogic16bitComputer.components.gates;


namespace DigitalLogic16bitComputer.components.arithmetic.shift
{
    /// <summary>
    /// Represents a N-bit shift circuit that can perform left shift, right shift, rotate right, and arithmetic shift right operations.
    /// </summary>
    public class NBitShift
    {
        /// <summary>
        /// The output of the shift operation
        /// </summary>
        public NBitArray OutputNum { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="NBitShift"/> class.
        /// opSelect1, opSelect2 => OP
        /// false, false => LSL
        /// false, true => LSR
        /// true, false => ROR
        /// true, true => ASR
        /// </summary>
        /// <param name="num">The number to be shifted</param>
        /// <param name="shiftN">The number of bits to shift the input by</param>
        /// <param name="opSelect1">The first select bit for the operation</param>
        /// <param name="opSelect2">The second select bit for the operation</param>
        /// <exception cref="ArgumentException">The input num must have a number of bits that is a power of 2</exception>
        public NBitShift(NBitArray num, NBitArray shiftN, Bit opSelect1, Bit opSelect2)
		{
            var shiftedOutBitsToShiftedInBitsDelegate = delegate (NBitArray shiftedOutBits, Bit msb)
            {
                var zeros = new Bit[shiftedOutBits.Length];
                var msbs = new Bit[shiftedOutBits.Length];
                var zero = new Bit(false);
                for (var i = 0; i < zeros.Length; i++)
                {
                    zeros[i] = zero;
                    msbs[i] = msb;
                }
                var zerosNBitArray = new NBitArray(zeros);
                var msbsNbitArray = new NBitArray(msbs);

                var mux = new NBitMultiplexer(new NBitArray[] { zerosNBitArray, zerosNBitArray, shiftedOutBits, msbsNbitArray }, new NBitArray(new Bit[] { opSelect1, opSelect2 }));
                return mux.NBitOutput;
            };

            var rightShift = new NBitRightShift(num, shiftN, shiftedOutBitsToShiftedInBitsDelegate);
            var leftShift = new NBitLeftShift(num, shiftN);

            var shiftDirectionSelect = new OrGate(opSelect1, opSelect2);
            var outputMux = new NBitMultiplexer(leftShift.OutputNum, rightShift.OutputNum, shiftDirectionSelect.Output);
            this.OutputNum = outputMux.NBitOutput;
        }
	}
}

