using DigitalLogic16bitComputer.components.gates;

namespace DigitalLogic16bitComputer.components.arithmetic
{
    public class NBitPositiveMultiplier
    {
        public NBitArray OutputNum { get; }

        public NBitArray FullOutputNum { get; }

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

        private NBitArray RemoveLastBit(NBitArray num)
        {
            return new NBitArray(num.Take(num.Length - 1).ToArray());
        }

        private NBitArray ConcatFirst(NBitArray num, Bit bit)
        {
            return new NBitArray(num.Prepend(bit).ToArray());
        }
    }
}
