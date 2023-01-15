namespace DigitalLogic16bitComputer.components.gates
{
    public class OrGate : IUpdatable
    {
        internal Bit InputA { get; private set; }
        internal Bit InputB { get; private set; }
        public Bit Output { get; private set; }

        public OrGate(Bit inputA, Bit inputB)
        {
            this.InitializeInputs(inputA, inputB);
        }

        public OrGate(NBitArray inputs)
        {
            if (inputs.Length < 2)
            {
                throw new ArgumentException("Not enough inputs");
            }
            else if (inputs.Length == 2)
            {
                this.InitializeInputs(inputs[0], inputs[1]);
            }
            else
            {
                var firstInput = inputs.First();
                var innerGate = new OrGate(new NBitArray(inputs.TakeLast(inputs.Length - 1).ToArray()));
                this.InitializeInputs(firstInput, innerGate.Output);
            }
        }

        private void InitializeInputs(Bit inputA, Bit inputB)
        {
            this.InputA = inputA;
            this.InputB = inputB;
            this.InputA.RegisterUpdate(this);
            this.InputB.RegisterUpdate(this);
            this.Output = new Bit();
            this.Update();
        }

        public void Update()
        {
            this.Output.Value = this.InputA.Value || this.InputB.Value;
        }

        public void Dispose()
        {
            this.InputA.UnregisterUpdate(this);
            this.InputB.UnregisterUpdate(this);
        }
    }
}
