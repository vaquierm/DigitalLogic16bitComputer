using DigitalLogic16bitComputer.components.gates;

namespace DigitalLogic16bitComputer.components.control
{
    public class Multiplexer
    {
        public Bit Output { get; }

        public Multiplexer(Bit inputA, Bit inputB, Bit select)
        {
            var notSelect = new NotGate(select);
            var nandGateA = new NandGate(inputA, select);
            var nandGateB = new NandGate(inputB, notSelect.Output);
            var nandGateOut = new NandGate(nandGateA.Output, nandGateB.Output);
            this.Output = nandGateOut.Output;
        }
    }
}
