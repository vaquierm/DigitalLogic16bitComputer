using DigitalLogic16bitComputer.components.gates;

namespace DigitalLogic16bitComputer.components.registers
{

    public class SRLatch
    {
        readonly NandGate nandGate1;
        readonly NandGate nandGate2;

        public Bit OutputQ { get; }
        public Bit OutputQPrime { get; }


        public SRLatch(Bit inputS, Bit inputR) {
            var tempBit1 = new Bit();
            var tempBit2 = new Bit();
            this.nandGate1 = new NandGate(tempBit2, inputR);
            this.nandGate2 = new NandGate(tempBit1, inputS);
            tempBit1.ConnectFrom(this.nandGate1.Output);
            tempBit2.ConnectFrom(this.nandGate2.Output);
            this.OutputQ = this.nandGate1.Output;
            this.OutputQPrime = this.nandGate2.Output;
        }
    }
}
