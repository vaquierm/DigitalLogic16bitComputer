using DigitalLogic16bitComputer.components.gates;

namespace DigitalLogic16bitComputer.components.registers
{
    public class DFlipFlop
    {
        private readonly SRLatch srLatch;

        public Bit Output { get; }

        public DFlipFlop(Bit inputD, Bit inputClk) {
            var notInputD = new NotGate(inputD);
            var nand1 = new AndGate(inputD, inputClk);
            var nand2 = new AndGate(notInputD.Output, inputClk);
            this.srLatch = new SRLatch(nand1.Output, nand2.Output);
            this.Output = this.srLatch.OutputQ;
        }
    }
}
