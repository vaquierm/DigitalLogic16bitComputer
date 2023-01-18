using DigitalLogic16bitComputer.components.gates;

namespace DigitalLogic16bitComputer.components.arithmetic
{
    /// <summary>
    /// A class that represents a N-Bit Adder, which takes in two N-bit numbers and an input carry
    /// and outputs the sum of the two numbers, the carry out, and the overflow bit.
    /// </summary>
    public class NBitAdder
    {
        /// <summary>
        /// The resulting sum of the two input numbers, in the form of an <see cref="NBitArray"/>
        /// </summary>
        /// 
        public NBitArray OutputNum { get; }

        /// <summary>
        /// The carry out bit of the addition, indicating whether a carry occurred from the most significant bit
        /// </summary>
        public Bit OutputCarry { get; }

        /// <summary>
        /// The overflow bit of the addition, indicating whether an overflow occurred from the addition
        /// </summary>
        public Bit OutputOverflow { get; }

        /// <summary>
        /// Constructs an NBitAdder, which takes in two N-bit numbers and an input carry
        /// and outputs the sum of the two numbers, the carry out, and the overflow bit.
        /// </summary>
        /// <param name="numA">The first N-bit number to be added</param>
        /// <param name="numB">The second N-bit number to be added</param>
        /// <param name="inputCarry">The input carry bit, indicating whether a carry is being propagated from a previous addition</param>
        public NBitAdder(NBitArray numA, NBitArray numB, Bit inputCarry)
        {
            if (numA.Length != numB.Length)
            {
                throw new ArgumentException("Two numbers must have the same number of bits");
            }
            else if (numA.Length < 2)
            {
                throw new ArgumentException("Two numbers must both have at least two bits");
            }

            var adderArray = new FullAdder[numA.Length];
            for (var i = numA.Length - 1; i >= 0 ; i--)
            {
                var inputCarryI = (i != numA.Length - 1) ? adderArray[i + 1].OutputCarry : inputCarry;
                adderArray[i] = new FullAdder(numA[i], numB[i], inputCarryI);

                if (i == 0)
                {
                    this.OutputCarry = adderArray[i].OutputCarry;
                    var overflowDetectorXor = new XorGate(adderArray[i].OutputCarry, inputCarryI);
                    this.OutputOverflow = overflowDetectorXor.Output;
                }
            }

            this.OutputNum = new NBitArray(adderArray.Select(adder => adder.Output).ToArray());
        }
    }
}
