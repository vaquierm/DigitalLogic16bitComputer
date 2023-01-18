using DigitalLogic16bitComputer.components;
using DigitalLogic16bitComputer.components.gates;

namespace DigitalLogic16bitComputer.components.arithmetic
{
    /// <summary>
    /// Class for creating the two's complement representation of a number.
    /// </summary>
    public class NBitTwosComplement
    {
        /// <summary>
        /// The two's complement of the input number
        /// </summary>
        public NBitArray OutputNum { get; }
        /// <summary>
        /// Creates a new instance of the class.
        /// </summary>
        /// <param name="number">The input number to convert to two's complement</param>
        /// <exception cref="ArgumentException">Thrown when the number of bits in the input number is less than 2</exception>
        public NBitTwosComplement(NBitArray number)
        {
            if (number.Length < 2)
            {
                throw new ArgumentException("The input number must be at least two bits");
            }

            var onesComplement = new Bit[number.Length];
            var zeroBitArray = new Bit[number.Length];

            for (var i = 0; i < number.Length; i++)
            {
                var complementXor = new XorGate(number[i], new Bit(true));
                onesComplement[i] = complementXor.Output;
                zeroBitArray[i] = new Bit(false);
            }

            var twosComplement = new NBitAdder(new NBitArray(onesComplement), new NBitArray(zeroBitArray), new Bit(true));
            this.OutputNum = twosComplement.OutputNum;
        }
    }
}
