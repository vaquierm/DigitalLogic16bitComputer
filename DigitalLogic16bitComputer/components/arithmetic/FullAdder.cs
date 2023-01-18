using DigitalLogic16bitComputer.components.gates;

namespace DigitalLogic16bitComputer.components.arithmetic
{
    /// <summary>
    /// A full adder is a digital circuit that performs the arithmetic operation of addition, specifically, 
    /// the addition of two binary digits and a carry. 
    /// </summary>
    public class FullAdder
    {
        /// <summary>
        /// First input bit to be added
        /// </summary>
        Bit InputA { get; }

        /// <summary>
        /// Second input bit to be added
        /// </summary>
        Bit InputB { get; }

        /// <summary>
        /// Carry input from a previous addition
        /// </summary>
        Bit InputCarry { get; }

        /// <summary>
        /// Output of the addition of the three input bits
        /// </summary>
        public Bit Output { get; }

        /// <summary>
        /// Carry output for the next addition
        /// </summary>
        public Bit OutputCarry { get; }

        /// <summary>
        /// Constructs a FullAdder object with input bits and carry. 
        /// </summary>
        /// <param name="inputA">First input bit to be added</param>
        /// <param name="inputB">Second input bit to be added</param>
        /// <param name="inputCarry">Carry input from a previous addition</param>
        public FullAdder(Bit inputA, Bit inputB, Bit inputCarry)
        {
            this.InputA = inputA;
            this.InputB = inputB;

            this.InputCarry = inputCarry;

            var inputXor = new XorGate(inputA, inputB);
            var inputAnd = new AndGate(inputA, inputB);
            var outputXor = new XorGate(inputCarry, inputXor.Output);
            var carryAnd = new AndGate(inputCarry, inputXor.Output);
            var outputOr = new OrGate(inputAnd.Output, carryAnd.Output);

            this.Output = outputXor.Output;
            this.OutputCarry = outputOr.Output;
        }
    }
}
