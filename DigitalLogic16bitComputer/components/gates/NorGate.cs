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

        public NorGate(NBitArray inputs)
        {
            if (inputs.Length < 2)
            {
                throw new ArgumentException("Not enough inputs");
            }
            else if (inputs.Length == 2)
            {
                this.OrGate = new OrGate(inputs[0], inputs[1]);
            }
            else
            {
                this.OrGate = new OrGate(inputs);
            }
            
            this.NotGate = new NotGate(this.OrGate.Output);
            this.Output = this.NotGate.Output;
        }
    }
}
