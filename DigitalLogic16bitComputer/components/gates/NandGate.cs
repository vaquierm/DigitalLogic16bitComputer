namespace DigitalLogic16bitComputer.components.gates
{
    public class NandGate
    {
        public Bit Output { get; }

        readonly AndGate AndGate;
        readonly NotGate NotGate;

        public NandGate(Bit inputA, Bit inputB)
        {
            this.AndGate = new AndGate(inputA, inputB);
            this.NotGate = new NotGate(this.AndGate.Output);
            this.Output = this.NotGate.Output;
        }
    }
}
