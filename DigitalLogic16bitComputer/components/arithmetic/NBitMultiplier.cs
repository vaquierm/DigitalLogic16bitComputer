using DigitalLogic16bitComputer.components.control;
using DigitalLogic16bitComputer.components.gates;

namespace DigitalLogic16bitComputer.components.arithmetic
{
    /// <summary>
    /// Multiplication module for two N-bit integers.
    /// </summary>
    /// <param name="numA">Number A</param>
    /// <param name="numB">Number B</param>
    /// <exception cref="ArgumentException">Both numbers must have at least 3 bits each and be of the same length</exception>
    public class NBitMultiplier
    {
        /// <summary>
        /// The N first bits of the resulting product of the multiplication in 2's complement representation.
        /// </summary>
        public NBitArray OutputNum { get; }

        /// <summary>
        /// The resulting product of the multiplication in full 2's complement representation.
        /// </summary>
        public NBitArray FullOutputNum { get; }


        /// <summary>
        /// The overflow bit indicating if the result of the multiplication exceeds the range of an N-bit number.
        /// </summary>
        public Bit OutputOverflow { get; }

        /// <summary>
        /// Multiplication module for two N-bit integers. 
        /// </summary>
        /// <param name="numA">Number A</param>
        /// <param name="numB">Number B</param>
        /// <exception cref="ArgumentException">Both numbers must have at least 3 bits each and be of the same length</exception>
        public NBitMultiplier(NBitArray numA, NBitArray numB)
        {
            if (numA.Length != numB.Length)
            {
                throw new ArgumentException("Two numbers must have the same number of bits");
            }
            else if (numA.Length < 3)
            {
                throw new ArgumentException("Two numbers must both have at least two bits");
            }

            var inputASign = numA[0];
            var inputBSign = numB[0];
            var twosComplement = new NBitTwosComplement(numA);
            var inputANegative = twosComplement.OutputNum;
            twosComplement = new NBitTwosComplement(numB);
            var inputBNegative = twosComplement.OutputNum;

            var inputAMultiplexer = new NBitMultiplexer(inputANegative, numA, inputASign);
            var inputBMultiplexer = new NBitMultiplexer(inputBNegative, numB, inputBSign);

            var positiveMultiplier = new NBitPositiveMultiplier(inputAMultiplexer.NBitOutput, inputBMultiplexer.NBitOutput);

            var resultSign = new XorGate(inputASign, inputBSign).Output;
            var resultTwosComplement = new NBitTwosComplement(positiveMultiplier.FullOutputNum);
            var outputMultiplexer = new NBitMultiplexer(resultTwosComplement.OutputNum, positiveMultiplier.FullOutputNum, resultSign);
            this.FullOutputNum = outputMultiplexer.NBitOutput;

            this.OutputNum = new NBitArray(this.FullOutputNum.TakeLast(numA.Length).ToArray());

            this.OutputOverflow = positiveMultiplier.OutputOverflow;
        }
    }
}
