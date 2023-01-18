using DigitalLogic16bitComputer.components.gates;

namespace DigitalLogic16bitComputer.components.registers
{
    /// <summary>
    /// SR Latch is a fundamental building block of many sequential logic circuits.
    /// It is a bistable circuit that has two stable states, and can be used to store a bit of information.
    /// The circuit has two inputs, S (set) and R (reset), and two outputs, Q and Q' (Q prime).
    /// When S is true and R is false, the circuit's output will be Q = 1, Q' = 0.
    /// When S is false and R is true, the circuit's output will be Q = 0, Q' = 1.
    /// If both S and R are true, the circuit is in an invalid state.
    /// </summary>
    public class SRLatch : IUpdatable
    {
        readonly NorGate norGate1;
        readonly NorGate norGate2;

        /// <summary>
        /// The S input
        /// </summary>
        Bit InputS { get; }

        /// <summary>
        /// The R input
        /// </summary>
        Bit InputR { get; }

        /// <summary>
        /// The Q output
        /// </summary>
        public Bit OutputQ { get; }

        /// <summary>
        /// The Q' output
        /// </summary>
        public Bit OutputQPrime { get; }

        /// <summary>
        /// Initializes a new SR Latch with the provided input S and input R
        /// </summary>
        /// <param name="inputS">The S input</param>
        /// <param name="inputR">The R input</param>
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

        /// <summary>
        /// Updates the circuit's output based on the inputs
        /// </summary>
        public void Update()
        {
            if (this.InputS.Value == true && this.InputR.Value == true)
            {
                throw new Exception("SR Latch in invalid state");
            }
        }

        /// <summary>
        /// Disposes of the SR Latch
        /// </summary>
        public void Dispose()
        {
            return;
        }
    }
}
