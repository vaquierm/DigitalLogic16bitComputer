using DigitalLogic16bitComputer.components.gates;

namespace DigitalLogic16bitComputer.components.arithmetic
{
    public class NBitAdder
    {
        public NBitArray OutputNum { get; }
        public Bit OutputCarry { get; }
        public Bit OutputOverflow { get; }
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
