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

        public NandGate(NBitArray inputs)
        {
            if (inputs.Length < 2)
            {
                throw new ArgumentException("Not enough inputs");
            }
            else if (inputs.Length == 2)
            {
                this.AndGate = new AndGate(inputs[0], inputs[1]);
            }
            else
            {
                this.AndGate = new AndGate(inputs);
            }

            this.NotGate = new NotGate(this.AndGate.Output);
            this.Output = this.NotGate.Output;
        }
    }
}
