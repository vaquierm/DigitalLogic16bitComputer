namespace DigitalLogic16bitComputer.components.gates
{
    public class NorGate
    {
        public Bit Output { get; }

        readonly OrGate OrGate;
        readonly NotGate NotGate;

        public NorGate(Bit inputA, Bit inputB)
        {
            this.OrGate = new OrGate(inputA, inputB);
            this.NotGate = new NotGate(this.OrGate.Output);
            this.Output = this.NotGate.Output;
        }
    }
}
