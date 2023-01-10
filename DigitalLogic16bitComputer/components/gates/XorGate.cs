namespace DigitalLogic16bitComputer.components.gates
{
    public class XorGate
    {
        public Bit Output { get; }

        readonly NotGate notGateA;
        readonly NotGate notGateB;
        readonly NandGate nandGateA;
        readonly NandGate nandGateB;
        readonly NandGate nandGateC;


        public XorGate(Bit inputA, Bit inputB)
        {
            this.notGateA = new NotGate(inputB);
            this.notGateB = new NotGate(inputA);
            this.nandGateA = new NandGate(inputA, this.notGateA.Output);
            this.nandGateB = new NandGate(inputB, this.notGateB.Output);
            this.nandGateC = new NandGate(this.nandGateA.Output, this.nandGateB.Output);
            this.Output = this.nandGateC.Output;
        }
    }
}
