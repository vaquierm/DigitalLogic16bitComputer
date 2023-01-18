using DigitalLogic16bitComputer.components.gates;

namespace DigitalLogic16bitComputer.components.registers
{
    /// <summary>
    /// A D Flip-Flop is a type of bistable latch that has two stable states, one of which is the set state and the other is the reset state.
    /// The output of the flip-flop is the stored state which can be set or reset by the input D and the input Clock.
    /// </summary>
    public class DFlipFlop
    {
        private readonly SRLatch srLatch;

        /// <summary>
        /// The output of the D Flip-Flop. This is the stored state.
        /// </summary>
        public Bit Output { get; }

        /// <summary>
        /// Constructs a D Flip-Flop with input D and input Clock
        /// </summary>
        /// <param name="inputD">The input to set or reset the stored state</param>
        /// <param name="inputClk">The input to control when to set or reset the stored state</param>
        public DFlipFlop(Bit inputD, Bit inputClk) {
            var notInputD = new NotGate(inputD);
            var nand1 = new AndGate(inputD, inputClk);
            var nand2 = new AndGate(notInputD.Output, inputClk);
            this.srLatch = new SRLatch(nand1.Output, nand2.Output);
            this.Output = this.srLatch.OutputQ;
        }
    }
}
