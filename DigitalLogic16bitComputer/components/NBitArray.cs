using System.Collections;

namespace DigitalLogic16bitComputer.components
{
    /// <summary>
    /// Wrapper for an array of bits with a few utility functions
    /// </summary>
    public class NBitArray : IEnumerable<Bit>
    {
        private readonly Bit[] bitArray;

        /// <summary>
        /// The number of bits in the array
        /// </summary>
        public int Length
        {
            get { return bitArray.Length; }
        }

        /// <summary>
        /// Initializes a new instance of the NBitArray class with a given array of bits
        /// </summary>
        /// <param name="bitArray">The array of bits to be wrapped</param>
        public NBitArray(Bit[] bitArray)
        {
            this.bitArray = bitArray;
        }

        /// <summary>
        /// Indexer for accessing individual bits in the array
        /// </summary>
        /// <param name="i">The index of the desired bit</param>
        public Bit this[int i]
        {
            get { return bitArray[i]; }
        }

        /// <summary>
        /// Gets an enumerator for the bits in the array
        /// </summary>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.bitArray.ToList().GetEnumerator();
        }

        /// <summary>
        /// Gets an enumerator for the bits in the array
        /// </summary>
        public IEnumerator<Bit> GetEnumerator()
        {
            return this.bitArray.ToList().GetEnumerator();
        }

        /// <summary>
        /// Converts the bit array to a string representation
        /// </summary>
        public override string ToString()
        {
            return this.ToInt().ToString();
        }

        /// <summary>
        /// Converts the bit array to an integer
        /// </summary>
        public int ToInt()
        {
            var binaryString = this.ToBinaryString();
            binaryString = binaryString.PadLeft(32, binaryString[0]);
            return Convert.ToInt32(binaryString, 2);
        }

        /// <summary>
        /// Converts the bit array to a binary string
        /// </summary>
        public string ToBinaryString()
        {
            var binaryString = "";
            for (int i = 0; i < this.bitArray.Length; i++)
            {
                if (this.bitArray[i].Value)
                {
                    binaryString += "1";
                }
                else
                {
                    binaryString += "0";
                }
            }

            return binaryString;
        }

        /// <summary>
        /// Converts an integer to a NBitArray
        /// </summary>
        /// <param name="value">The integer to be converted</param>
        /// <param name="nBits">The number of bits in the resulting NBitArray</param>
        public static NBitArray IntToNBitArray(int value, int nBits)
        {
            var twoToN = Math.Pow(2, nBits - 1);
            if (value >= twoToN || value < -twoToN)
            {
                throw new ArgumentException("The value " + value + " cannot be converted to a decimal representation of " + nBits + " bits.");
            }
            var binaryString = Convert.ToString(value, 2);

            if (binaryString.Length < nBits)
            {
                binaryString = binaryString.PadLeft(nBits, '0');
            }
            else if (binaryString.Length > nBits)
            {
                binaryString = binaryString.Substring(binaryString.Length - nBits);
            }

            return NBitArray.BinaryStringToNBitArray(binaryString);
        }

        /// <summary>
        /// Converts a binary string to a NBitArray
        /// </summary>
        /// <param name="binaryString">The binary string to be converted</param>
        public static NBitArray BinaryStringToNBitArray(string binaryString)
        {
            var returnBits = new Bit[binaryString.Length];
            for (int i = 0; i < binaryString.Length; i++)
            {
                if (binaryString[i] == '0')
                {
                    returnBits[i] = new Bit(false);
                }
                else
                {
                    returnBits[i] = new Bit(true);
                }
            }

            return new NBitArray(returnBits);
        }

        
    }
}

