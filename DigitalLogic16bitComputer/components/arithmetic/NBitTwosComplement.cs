using DigitalLogic16bitComputer.components;
using DigitalLogic16bitComputer.components.gates;

namespace DigitalLogic16bitComputer.components.arithmetic
{
    public class NBitTwosComplement
    {
        public NBitArray OutputNum { get; }

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
