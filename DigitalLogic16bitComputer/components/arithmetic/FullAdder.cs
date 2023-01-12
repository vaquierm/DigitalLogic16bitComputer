using DigitalLogic16bitComputer.components.gates;

namespace DigitalLogic16bitComputer.components.arithmetic
{
    public class FullAdder
    {
        Bit InputA { get; }
        Bit InputB { get; }
        Bit InputCarry { get; }
        public Bit Output { get; }
        public Bit OutputCarry { get; }

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
