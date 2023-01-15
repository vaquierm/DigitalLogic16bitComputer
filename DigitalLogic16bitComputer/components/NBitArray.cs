using System.Collections;

namespace DigitalLogic16bitComputer.components
{
    /// <summary>
    /// Wrapper for an array of bits with a few utility functions
    /// </summary>
    public class NBitArray : IEnumerable<Bit>
    {
        private readonly Bit[] bitArray;

        public int Length
        {
            get { return bitArray.Length; }
        }

        public NBitArray(Bit[] bitArray)
        {
            this.bitArray = bitArray;
        }

        public Bit this[int i]
        {
            get { return bitArray[i]; }
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.bitArray.ToList().GetEnumerator();
        }

        public IEnumerator<Bit> GetEnumerator()
        {
            return this.bitArray.ToList().GetEnumerator();
        }

        public override string ToString()
        {
            return this.ToInt().ToString();
        }

        public int ToInt()
        {
            var binaryString = this.ToBinaryString();
            binaryString = binaryString.PadLeft(32, binaryString[0]);
            return Convert.ToInt32(binaryString, 2);
        }

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

