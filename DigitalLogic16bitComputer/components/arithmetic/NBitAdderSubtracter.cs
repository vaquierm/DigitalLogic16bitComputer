using DigitalLogic16bitComputer.components.gates;

namespace DigitalLogic16bitComputer.components.arithmetic
{
    public class NBitAdderSubtracter
    {
        public Bit Subtract { get; }
        public NBitArray NumA { get; }
        public NBitArray NumB { get; }

        public NBitArray OutputNum { get; }

        public NBitAdderSubtracter(NBitArray numA, NBitArray numB, Bit subtract)
        {
            this.NumA = numA;
            this.NumB = numB;
            this.Subtract = subtract;

            if (numA.Length != numB.Length)
            {
                throw new ArgumentException("Two numbers must have the same number of bits");
            }
            else if (numA.Length < 2)
            {
                throw new ArgumentException("Two numbers must both have at least two bits");
            }

            var onesComplement = new Bit[numA.Length];
            for (var i = 0; i < numA.Length; i++)
            {
                var complementXor = new XorGate(numB[i], subtract);
                onesComplement[i] = complementXor.Output;
            }

            var nBitAdder = new NBitAdder(numA, new NBitArray(onesComplement), subtract);
            this.OutputNum = nBitAdder.OutputNum;
        }
    }
}
