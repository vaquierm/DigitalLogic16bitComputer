using DigitalLogic16bitComputer.components.control;
using DigitalLogic16bitComputer.components.gates;

namespace DigitalLogic16bitComputer.components.arithmetic
{
    /// <summary>
    /// Division module for two N-bit integers.
    /// </summary>
    /// <param name="numA">Number A</param>
    /// <param name="numB">Number B</param>
    /// <exception cref="ArgumentException">Both numbers must have at least 3 bits each and be of the same length</exception>
    public class NBitDivider
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
        /// Division module for two N-bit integers. 
        /// </summary>
        /// <param name="numA">Number A</param>
        /// <param name="numB">Number B</param>
        /// <exception cref="ArgumentException">Both numbers must have at least 3 bits each and be of the same length</exception>
        public NBitDivider(NBitArray numA, NBitArray numB)
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

            var positiveDivider = new NBitPositiveDivider(inputAMultiplexer.NBitOutput, inputBMultiplexer.NBitOutput);

            var resultSign = new XorGate(inputASign, inputBSign).Output;
            var resultTwosComplement = new NBitTwosComplement(positiveDivider.OutputNum);
            var remainderTwosComplement = new NBitTwosComplement(positiveDivider.OutputRemainder);
            var outputMultiplexer = new NBitMultiplexer(resultTwosComplement.OutputNum, positiveDivider.OutputNum, resultSign);
            var outputRemainderMultiplexer = new NBitMultiplexer(remainderTwosComplement.OutputNum, positiveDivider.OutputRemainder, numA[0]);

            this.OutputNum = outputMultiplexer.NBitOutput;
            this.OutputRemainder = outputRemainderMultiplexer.NBitOutput;
        }
    }
}
