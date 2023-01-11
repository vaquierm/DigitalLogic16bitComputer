using DigitalLogic16bitComputer.components.gates;

namespace DigitalLogic16bitComputer.components.registers
{
    public class SRLatch : IUpdatable
    {
        readonly NorGate norGate1;
        readonly NorGate norGate2;

        Bit InputS { get; }
        Bit InputR { get; }

        public Bit OutputQ { get; }
        public Bit OutputQPrime { get; }


        public SRLatch(Bit inputS, Bit inputR) {
            this.InputS = inputS;
            this.InputR = inputR;
            this.InputS.RegisterUpdate(this);
            this.InputR.RegisterUpdate(this);
            this.Update();
            var tempBit1 = new Bit();
            var tempBit2 = new Bit();
            this.norGate1 = new NorGate(tempBit2, inputR);
            this.norGate2 = new NorGate(tempBit1, inputS);
            // This order of these connection is super important to make sure
            // that the latch is initialized correctly when both inputs are false
            tempBit2.ConnectFrom(this.norGate2.Output);
            tempBit1.ConnectFrom(this.norGate1.Output);
            this.OutputQ = this.norGate1.Output;
            this.OutputQPrime = this.norGate2.Output;
        }

        public void Update()
        {
            if (this.InputS.Value == true && this.InputR.Value == true)
            {
                throw new Exception("SR Latch in invalid state");
            }
        }

        public void Dispose()
        {
            return;
        }
    }
}
