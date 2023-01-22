using DigitalLogic16bitComputer.components.control;
using DigitalLogic16bitComputer.components.gates;

namespace DigitalLogic16bitComputer.components.arithmetic
{
	public class NBitPositiveDivider
	{
        /// <summary>
        /// The result of the devision.
        /// </summary>
        public NBitArray OutputNum { get; }

        /// <summary>
        /// The remainder of the division.
        /// </summary>
        public NBitArray OutputRemainder { get; }

        /// <summary>
        /// Division module for two N-bit POSITIVE integers. This module does not work if negative numbers are passed
        /// </summary>
        /// <param name="numA">Number A</param>
        /// <param name="numB">Number B</param>
        /// <exception cref="ArgumentException">Both numbers must have at least 3 bits each and be of the same length</exception>
        public NBitPositiveDivider(NBitArray numA, NBitArray numB)
        {
            if (numA.Length != numB.Length)
            {
                throw new ArgumentException("Two numbers must have the same number of bits");
            }
            else if (numA.Length < 3)
            {
                throw new ArgumentException("Two numbers must both have at least two bits");
            }

            var outptNumBitArray = new Bit[numA.Length];
            var remainder = numA;
            for (var i = 0; i < numB.Length; i++)
            {
                var dividend = numB.SubArray(numB.Length - 1 - i, numB.Length - 1);
                var validDividendSub = new NBitAdderSubtractor(dividend.Prepend(new Bit(false), numB.Length - 1 - i), numB, new Bit(true));

                // If this Bit is true the divident is valid at this shift level
                var validDividendBit = new NotGate(validDividendSub.OutputNum[0]).Output;

                var subtractDividend = new NBitAdderSubtractor(remainder.Prepend(new Bit(false)), dividend.Append(new Bit(false), numB.Length - 1 - i).Prepend(new Bit(false)), new Bit(true));

                // If this Bit is true the divident at this level of shift level does divide
                var validSubBit = new NotGate(subtractDividend.OutputNum[0]).Output;

                // If the divident is valid at this level of shift and it subtracts from the demainder, this output bit will be 1
                var outputBitAnd = new AndGate(validDividendBit, validSubBit);
                outptNumBitArray[i] = outputBitAnd.Output;

                // If the output bit is true, the new remainder will be the result of the subtraction, if not, the remainder remains unchanged
                var newRemainderMux = new NBitMultiplexer(remainder, subtractDividend.OutputNum.SubArray(1, remainder.Length), outputBitAnd.Output);

                // Update the new remainder
                remainder = newRemainderMux.NBitOutput;
            }

            this.OutputNum = new NBitArray(outptNumBitArray);
            this.OutputRemainder = remainder;
        }
	}
}

