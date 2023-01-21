using DigitalLogic16bitComputer.components.gates;

namespace DigitalLogic16bitComputer.components.arithmetic
{
    /// <summary>
    /// Represents a N-bit multiplier circuit for positive integers.
    /// </summary>
    public class NBitPositiveMultiplier
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
        /// Represents the overflow bit of the multiplication operation. 
        /// </summary>
        public Bit OutputOverflow { get; }


        /// <summary>
        /// Multiplication module for two N-bit POSITIVE integers. This module does not work if negative numbers are passed
        /// </summary>
        /// <param name="numA">Number A</param>
        /// <param name="numB">Number B</param>
        /// <exception cref="ArgumentException">Both numbers must have at least 3 bits each and be of the same length</exception>
        public NBitPositiveMultiplier(NBitArray numA, NBitArray numB)
        {
            if (numA.Length != numB.Length)
            {
                throw new ArgumentException("Two numbers must have the same number of bits");
            }
            else if (numA.Length < 3)
            {
                throw new ArgumentException("Two numbers must both have at least two bits");
            }

            var fullOutputBits = new Bit[numA.Length * 2];
            var outputBitIndex = fullOutputBits.Length - 1;


            var andB_0 = this.AndAll(numA, numB[numB.Length - 1]);
            fullOutputBits[outputBitIndex--] = andB_0.Last();

            var andB_1 = this.AndAll(numA, numB[numB.Length - 2]);


            var nBitAdder = new NBitAdder(andB_1, this.ConcatFirst(this.RemoveLastBit(andB_0), new Bit(false)), new Bit(false));
            fullOutputBits[outputBitIndex--] = nBitAdder.OutputNum.Last();

            for (var i = numB.Length - 3; i >= 0; i--)
            {
                var andB_i = this.AndAll(numA, numB[i]);
                nBitAdder = new NBitAdder(andB_i, this.ConcatFirst(this.RemoveLastBit(nBitAdder.OutputNum), nBitAdder.OutputCarry), new Bit(false));
                fullOutputBits[outputBitIndex--] = nBitAdder.OutputNum.Last();
            }

            for (var i = nBitAdder.OutputNum.Length - 2; i >= 0; i--)
            {
                fullOutputBits[outputBitIndex--] = nBitAdder.OutputNum[i];
            }

            fullOutputBits[0] = nBitAdder.OutputCarry;

            this.FullOutputNum = new NBitArray(fullOutputBits);
            this.OutputNum = new NBitArray(fullOutputBits.TakeLast(numA.Length).ToArray());

            var overflowBitsOr = new OrGate(new NBitArray(fullOutputBits.Take(numA.Length).ToArray()));
            this.OutputOverflow = overflowBitsOr.Output;
        }

        /// <summary>
        /// Perform bitwise AND operation on all bits of <paramref name="num"/> using <paramref name="bit"/>
        /// </summary>
        /// <param name="num">The NBitArray to perform the operation on</param>
        /// <param name="bit">The Bit to compare with</param>
        /// <returns>The NBitArray with the result of the operation</returns>
        private NBitArray AndAll(NBitArray num, Bit bit)
        {
            var outBits = new Bit[num.Length];
            for (var i = num.Length - 1; i >= 0; i--)
            {
                var andGate = new AndGate(num[i], bit);
                outBits[i] = andGate.Output;
            }

            return new NBitArray(outBits);
        }

        /// <summary>
        /// Remove the last bit of <paramref name="num"/>
        /// </summary>
        /// <param name="num">The NBitArray to remove the last bit from</param>
        /// <returns>The NBitArray with the last bit removed</returns>
        private NBitArray RemoveLastBit(NBitArray num)
        {
            return new NBitArray(num.Take(num.Length - 1).ToArray());
        }

        /// <summary>
        /// Create a new NBitArray by concatenating <paramref name="bit"/> at the beginning of <paramref name="num"/>
        /// </summary>
        /// <param name="num">The NBitArray to append to</param>
        /// <param name="bit">The Bit to append</param>
        /// <returns>The new NBitArray</returns>
        private NBitArray ConcatFirst(NBitArray num, Bit bit)
        {
            return new NBitArray(num.Prepend(bit).ToArray());
        }
    }
}
